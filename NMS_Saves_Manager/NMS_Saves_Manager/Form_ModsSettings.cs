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
        static string shadercachepath = NMSpath.Replace(@"\Binaries", @"\GAMEDATA\SHADERCACHE");
        static string NMSEpath = NMSpath + @"\NMSE";
        static string opengl = @"\opengl32.dll";
        static string _opengl = @"\_opengl32.dll";
        private bool openglloaded = false;
        public Form_ModsSettings()
        {
            InitializeComponent();
            backupmod();
            listpak();
            listdll();
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
       

        private void listpak()
        {
            lb_modlist.Items.Clear();
            DirectoryInfo pakimport = new DirectoryInfo(modstoragepath);
            FileInfo[] Files = pakimport.GetFiles("*.pak");

            foreach (FileInfo file in Files)
            {
                if (!file.Name.Contains("NMSARC"))
                {
                    lb_modlist.Items.Add(file.Name, false);
                }
            }

            DirectoryInfo pakexport = new DirectoryInfo(pcbankspath);
            FileInfo[] Files2 = pakexport.GetFiles("*.pak");

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

        private void listdll()
        {
            DirectoryInfo dllimport = new DirectoryInfo(modstoragepath);
            FileInfo[] Files = dllimport.GetFiles("*.dll");

            foreach (FileInfo file in Files)
            {
                    lb_modlist.Items.Add(file.Name, false);
            }

            DirectoryInfo dllexport = new DirectoryInfo(NMSEpath);
            FileInfo[] Files2 = dllexport.GetFiles("*.dll");

            foreach (FileInfo file in Files2)
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

        private void btn_refreshlist_Click(object sender, EventArgs e)
        {
            listpak();
            listdll();
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
                    foreach (string newPath in Directory.GetFiles(sourcepath, "*.pak", SearchOption.AllDirectories))
                         File.Copy(newPath, newPath.Replace(sourcepath, destinationpath), true);

                    foreach (string newPath in Directory.GetFiles(sourcepath, "*.dll", SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcepath, NMSEpath), true);

                }
                else
                {
                    foreach (string newPath in Directory.GetFiles(sourcepath, "*.pak*", SearchOption.AllDirectories))
                    File.Delete(pcbankspath + @"\" + curitem);

                    foreach (string newPath in Directory.GetFiles(sourcepath, "*.dll*", SearchOption.AllDirectories))
                    File.Delete(NMSEpath + @"\" + curitem);
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

            DirectoryInfo pakexport = new DirectoryInfo(pcbankspath);
            FileInfo[] Files = pakexport.GetFiles("*.pak");

            foreach (FileInfo file in Files)
            {
                if ((!file.Name.Contains("NMSARC")) && (!File.Exists(modstoragepath + @"/" + file.Name)))
                {
                        File.Copy(pcbankspath + @"/" + file.Name, modstoragepath + @"/" + file.Name);
                }
            }

            DirectoryInfo dllexport = new DirectoryInfo(NMSEpath);
            FileInfo[] Files2 = dllexport.GetFiles("*.dll");

            foreach (FileInfo file in Files2)
            {
                if (!File.Exists(modstoragepath + @"/" + file.Name))
                    File.Copy(NMSEpath + @"/" + file.Name, modstoragepath + @"/" + file.Name);
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

            DirectoryInfo pak = new DirectoryInfo(pcbankspath);
            FileInfo[] Files = pak.GetFiles("*.pak");

            foreach (FileInfo file in Files)
            {
                string modname = file.Name;
                if (!file.Name.Contains("NMSARC"))
                {
                    File.AppendAllText(newlist, modname + Environment.NewLine);
                }
            }

            DirectoryInfo dll = new DirectoryInfo(NMSEpath);
            FileInfo[] Files2 = dll.GetFiles("*.dll");

            foreach (FileInfo file in Files2)
            {
                string modname = file.Name;
                File.AppendAllText(newlist, modname + Environment.NewLine);
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

        private void lb_modlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_delshade_Click(object sender, EventArgs e)
        {
            Directory.Delete(shadercachepath, true);
            MessageBox.Show(String.Format("SHADERCACHE dumped !", MessageBoxButtons.OK, MessageBoxIcon.Information));

        }
    }
}
