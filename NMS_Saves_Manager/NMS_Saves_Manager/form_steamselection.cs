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
    public partial class form_steamselection : Form
    {
        public string steamID = "";
        static string version = "0.5.0b";
        private string newversion = "0.5.1";
        static string nmsprofilefolder = @"\HelloGames\NMS\";
        private string savepath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder);
        static string NMSpath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        static string lastloadedstorage = NMSpath + @"\profilstorage";
        static string steamIDstorage = NMSpath + @"\steamIDstorage"; 
        static string modstoragepath = NMSpath + @"\MODSTORAGE";
        static string NMSEpath = NMSpath + @"\NMSE";
        static string NMSmodspath = NMSpath.Replace(@"\Binaries", @"\GAMEDATA\PCBANKS");
        private string loaded = "DefaultUser";
        private string NMSpathexe = NMSpath + @"\NMS.exe";
        private string NMSextpath = NMSpath + @"\NMSELauncher.exe";
        private string lastloaded = "DefaultUser";
        private string profiltoload = "";
        private string userprofile = "DefaultUser";
        private string steamfolder = "";
        public string steamnum = "";

        public form_steamselection()
        {
            InitializeComponent();
            Globals.steamID = "";

            DirectoryInfo saves = new DirectoryInfo(savepath);
                FileSystemInfo[] filesAndDirs = saves.GetFileSystemInfos("st_*");

                foreach (FileSystemInfo foundFile in filesAndDirs)
                {
                if (!foundFile.Name.Contains("_old"))
                {
                    steamfolder = foundFile.Name;
                    steamnum = steamfolder.Replace(@"st_", @""); ;
                    listBox1.Items.Add(steamnum);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            steamID = listBox1.SelectedItem.ToString();
            btn_loadsteamprofile.Enabled = true;
        }

        private void btn_getID_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://steamid.co/");
        }

        private void btn_loadsteamprofile_Click(object sender, EventArgs e)
        {
            Globals.steamID = steamID;
            this.Close();
        }
    }
}
