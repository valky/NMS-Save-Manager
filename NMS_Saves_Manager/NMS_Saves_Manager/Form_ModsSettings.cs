using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace NMS_Saves_Manager
{
    public partial class Form_ModsSettings : Form
    {
        static string NMSpath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        static string modstoragepath = NMSpath + @"\MODSTORAGE";
        static string pcbankspath = NMSpath.Replace(@"\Binaries", @"\GAMEDATA\PCBANKS");
        static string opengl = @"\opengl32.dll";
        static string _opengl = @"\_opengl32.dll";
        private bool openglloaded = false;
        public Form_ModsSettings()
        {
            InitializeComponent();
            backupmod();
            listmods();
            if (File.Exists(NMSpath + opengl))
            {
                chk_reshade.Enabled = true;
                chk_reshade.Checked = true;
            }
            if (File.Exists(NMSpath + _opengl))
            {
                chk_reshade.Enabled = true;
                chk_reshade.Checked = false;
            }
            openglloaded = true;
        }
       

        private void listmods()
        {
            lb_modlist.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(modstoragepath);
            FileInfo[] Files = dinfo.GetFiles("*.pak");

            foreach (FileInfo file in Files)
            {
                if (!file.Name.Contains("NMSARC"))
                {
                    lb_modlist.Items.Add(file.Name, false);
                }
            }

            DirectoryInfo dinfo2 = new DirectoryInfo(pcbankspath);
            FileInfo[] Files2 = dinfo2.GetFiles("*.pak");

            foreach (FileInfo file in Files2)
            {
                if (!file.Name.Contains("NMSARC"))
                {
                    if (!lb_modlist.Items.Contains(file.Name))
                        {
                        lb_modlist.Items.Add(file.Name, true);
                    }
                    else
                    {
                        string modname = file.Name;
                        lb_modlist.SelectedValue = modname;
                        int i = lb_modlist.FindString(file.Name);
                        lb_modlist.SetItemCheckState(i, CheckState.Checked);
                    }                
                }
            }
        }

        private void btn_refreshlist_Click(object sender, EventArgs e)
        {
            listmods();
        }

        private void lb_modlist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lb_modlist.SelectedItem != null)
            {
                string curitem = lb_modlist.SelectedItem.ToString();
                string sourcepath = modstoragepath;
                string destinationpath = pcbankspath;

                if (lb_modlist.CheckedItems.Contains(curitem) == false)
                {
                    foreach (string newPath in Directory.GetFiles(sourcepath, "*.*", SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(sourcepath, destinationpath), true);
                }
                else
                {
                    foreach (string newPath in Directory.GetFiles(sourcepath, "*.*", SearchOption.AllDirectories))
                    File.Delete(pcbankspath + @"\" + curitem);
                }
            }
        }

        private void backupmod()
        {
            if (!Directory.Exists(modstoragepath))
            {
                MessageBox.Show(String.Format("It's seems to be the first time you want to use mods or mods folder from NMS:SM. Please unzip all your .pak mods in " + modstoragepath + " from now !", "NMS"), "NMS Saves Manager: Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Directory.CreateDirectory(modstoragepath);
                System.Diagnostics.Process.Start(modstoragepath);
            }

            DirectoryInfo dinfo = new DirectoryInfo(pcbankspath);
            FileInfo[] Files = dinfo.GetFiles("*.pak");

            foreach (FileInfo file in Files)
            {
                if ((!file.Name.Contains("NMSARC")) && (!File.Exists(modstoragepath + @"/" + file.Name)))
                {
                        File.Copy(pcbankspath + @"/" + file.Name, modstoragepath + @"/" + file.Name);
                }
            }
        }

        private void btn_printmods_Click(object sender, EventArgs e)
        {
            string desktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newlist = desktoppath + @"\My NMS Mods.txt";
            string hour = DateTime.Now.ToString("hh:mm");
            string date = DateTime.Now.ToString("MM/dd/yyyy");            

            if (File.Exists(newlist))
            {
                File.Delete(newlist);
                File.Create(newlist).Close();
                File.WriteAllText(newlist, "My No man's sky mods the " + date + " at " + hour + " :" + Environment.NewLine + Environment.NewLine);
            }
            else
            {
                File.Create(newlist).Close();
                File.WriteAllText(newlist, "My No man's sky mods the " + date + " at " + hour + " :" + Environment.NewLine + Environment.NewLine);
            }

            DirectoryInfo dinfo = new DirectoryInfo(pcbankspath);
            FileInfo[] Files = dinfo.GetFiles("*.pak");

            foreach (FileInfo file in Files)
            {
                string modname = file.Name;
                if (!file.Name.Contains("NMSARC"))
                {
                    File.AppendAllText(newlist, modname + Environment.NewLine);
                }
            }
            MessageBox.Show(String.Format("A list of your actives mods has been created on your Desktop !", "NMS"), "NMS Saves Manager: Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_reshade_CheckedChanged(object sender, EventArgs e)
        {
            if ((chk_reshade.Checked == false) && (openglloaded == true))
            {
                if (File.Exists(NMSpath + opengl))
                {
                    System.IO.File.Move(NMSpath + opengl, NMSpath + _opengl);
                }
                else
                {
                    MessageBox.Show(String.Format("Mod not installed or opengl32.dll is missing in " + NMSpath, MessageBoxButtons.OK, MessageBoxIcon.Error));
                    chk_reshade.Checked = true;
                }
            }
            if ((chk_reshade.Checked == true) && (openglloaded == true))
            {
                if (File.Exists(NMSpath + _opengl))
                    System.IO.File.Move(NMSpath + _opengl, NMSpath + opengl);
                else
                {
                    MessageBox.Show(String.Format("Reshade can't be re-enabled. Is _opengl32.dll missing from " + NMSpath + " ?", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    chk_reshade.Checked = false;
                }
            }
        }
    }
}
