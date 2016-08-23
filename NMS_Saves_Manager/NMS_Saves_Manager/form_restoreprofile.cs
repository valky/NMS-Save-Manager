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

    public partial class form_restoreprofile : Form
    {
        static string nmsprofilefolder = @"\HelloGames\NMS\";
        private string savepath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder);
        static string NMSpath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        static string lastloadedstorage = NMSpath + @"\profilstorage";
        static string steamIDstorage = NMSpath + @"\steamIDstorage";
        static string modstoragepath = NMSpath + @"\MODSTORAGE";
        static string NMSmodspath = NMSpath.Replace(@"\Binaries", @"\GAMEDATA\PCBANKS");
        private string loaded = "DefaultUser";
        private string NMSpathexe = NMSpath + @"\NMS.exe";
        private string NMSextpath = NMSpath + @"\NMSELauncher.exe";
        private string curItem = "";
        private string steamID = "";


        public form_restoreprofile()
        {
            InitializeComponent();
            if (File.Exists(steamIDstorage))
            {
                steamID = System.IO.File.ReadAllText(steamIDstorage);
            }
            refreshsaves();
        }

        private void refreshsaves()
        {
            lst_backup.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(savepath);
            DirectoryInfo[] Files = dinfo.GetDirectories();

            foreach (DirectoryInfo file in Files)
            {
                if (Globals.isgog == true && file.Name.Contains("_old"))
                {
                    lst_backup.Items.Add(file.Name);
                }
                if (Globals.isgog == false && file.Name.Contains(Globals.steamID) && file.Name.Contains("_old"))
                {
                    lst_backup.Items.Add(file.Name.Replace(Globals.steamID + "_", ""));
                }
            }
        }


private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to restore " + curItem + " ?", "Restore ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                restore();
            }
        }

        private void lst_backup_SelectedIndexChanged(object sender, EventArgs e)
        {
            curItem = lst_backup.SelectedItem.ToString();
        }

        private void restore()
        {
            if (Globals.isgog == true)
                {
                string source = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + curItem);
                string liveprofile = curItem.Replace("_old", "");
                string destination = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + liveprofile);

                if (Directory.Exists(destination))
                {
                    Directory.Delete(destination, true);
                    Directory.CreateDirectory(destination);
                }


                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(source, "*", SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(source, destination));

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(source, "*.*", SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(source, destination), true);
            }

            else
                {
                string source = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + Globals.steamID + "_" + curItem);
                string liveprofile = curItem.Replace("_old", "");
                string destination = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + Globals.steamID + "_" + liveprofile);

                if (Directory.Exists(destination))
                {
                    Directory.Delete(destination, true);
                    Directory.CreateDirectory(destination);
                }
                else
                {
                    Directory.CreateDirectory(destination);
                }


                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(source, "*", SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(source, destination));

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(source, "*.*", SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(source, destination), true);
            }
        }
    }
}
