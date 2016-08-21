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
    public partial class form_main : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);


        static string version = "0.5.0b";
        private string newversion = "0.5.1";
        static string nmsprofilefolder = @"\HelloGames\NMS\";
        private string savepath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder);
        static string NMSpath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        static string lastloadedstorage = NMSpath + @"\profilstorage";
        static string modstoragepath = NMSpath + @"\MODSTORAGE";
        static string NMSmodspath = NMSpath.Replace(@"\Binaries", @"\GAMEDATA\PCBANKS");
        private string loaded = "DefaultUser";
        private string NMSpathexe = NMSpath + @"\NMS.exe";
        private string NMSextpath = NMSpath + @"\NMSELauncher.exe";
        private string lastloaded = "DefaultUser";
        private string profiltoload = "";
        private string userprofile = "DefaultUser";
        private string steamfolder = "";

        private bool onloadprofil = false;
        private bool isfirstprofile = false;
        private int autobackupdelay = 0;
        private bool isgog = true;


        public form_main()
        {

            if (!Directory.Exists(savepath + "DefaultUser"))
            {
                isgog = false;
            }

            if (isgog == false)
            {
                DirectoryInfo saves = new DirectoryInfo(savepath);
                FileSystemInfo[] filesAndDirs = saves.GetFileSystemInfos("st_*");
                int processed = 0;

                foreach (FileSystemInfo foundFile in filesAndDirs)
                {
                    steamfolder = foundFile.Name;
                    userprofile = foundFile.Name;
                    if (++processed == 1) break;
                }
                if (steamfolder == "")
                {
                    MessageBox.Show("No Profile folder found. Please run ''No Man's Sky'' once before using NMS Saves Manager", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    foreach (var process in Process.GetProcessesByName("NMS_Saves_Manager"))
                    {
                        process.Kill();
                    }
                }
            }

            // >>>>>>>>>>>>>>> Get le numero de la nouvelle version
            //if (version != newversion)
            //{
            //    if (MessageBox.Show("A new version of NMS Manager is live ! Do you wish to update ?", "Visit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            //    {
            //        System.Diagnostics.Process.Start("http://nomansskymods.com/mods/nms-saves-and-mods-manager/");
            //        System.Diagnostics.Process.Start("http://www.nexusmods.com/nomanssky/mods/49?");
            //    }
            //}


                InitializeComponent();

                if (!File.Exists(lastloadedstorage))
                {
                    File.Create(lastloadedstorage).Close();
                    File.WriteAllText(lastloadedstorage, "DeleteThisProfile");

                }

                string loaded = System.IO.File.ReadAllText(lastloadedstorage);
                string lastloaded = System.IO.File.ReadAllText(lastloadedstorage);

                if (lastloaded != "" && lastloaded != "DefaultUser" && lastloaded != "DeleteThisProfile")
                {
                    string profil = System.IO.File.ReadAllText(lastloadedstorage);
                    string profilsave = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + profil);
                    string defaultuser = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + userprofile);

                    if (!Directory.Exists(defaultuser))
                    {
                        MessageBox.Show("No DefaultUser found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (Directory.Exists(profilsave))
                    {
                        Directory.Delete((profilsave), true);
                        Directory.CreateDirectory(profilsave);
                    }

                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(defaultuser, "*", SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(defaultuser, profilsave));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(defaultuser, "*.*", SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(defaultuser, profilsave), true);
                

                //if (Directory.Exists(profilsave))
                //{
                //    Directory.Delete(profilsave, true);
                //    Directory.CreateDirectory(profilsave);
                //}


                if (Directory.Exists(savepath + "DeleteThisProfile"))
                {
                    string deleteit = savepath + "DeleteThisProfile";
                    Directory.Delete((deleteit), true);
                }
   
                lastsession.Text = lastloaded;
                actload.Text = "-";
                refreshsaves();
                if (savelist.Items.Count == 0)
                {
                    MessageBox.Show("It seems it's the first time you are using NMS Saves Manager. Please create a new profile. NMS Saves Manager will then transfer your actual DefaultUser to this profile", "Welcome to NMS Saves Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isfirstprofile = true;
                }
            }
        }

    private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(savepath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled     = true;
            newsaveok.Enabled    = true;
            textBox1.Text        = "";
            this.ActiveControl   = textBox1;
        }

        private void newsaveok_Click(object sender, EventArgs e)
        {
            string newsavename = textBox1.Text;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter New Profil Name Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (isfirstprofile == true)
                {
                    var folder = Directory.CreateDirectory(savepath + "\\" + newsavename);
                    textBox1.Enabled = false;
                    newsaveok.Enabled = false;
                    string sourcepath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + userprofile);
                    string destinationpath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + newsavename);


                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcepath, "*", SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcepath, destinationpath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcepath, "*.*", SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcepath, destinationpath), true);
                    refreshsaves();
                    MessageBox.Show("Welcome " + newsavename + " ! If you already had multiple saves, you can either rename them manually and refresh the NMS Saves Manager profiles list or create new profiles and copy your backups in newly created folders", "NMS Saves Manager: Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var folder = Directory.CreateDirectory(savepath + @"\" + newsavename);
                    textBox1.Enabled = false;
                    newsaveok.Enabled = false;
                    string sourcepath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + userprofile);
                    string destinationpath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + userprofile + "_old");

                    if (Directory.Exists(destinationpath))
                    {
                        Directory.Delete(destinationpath, true);
                    }

                    if (Directory.Exists(sourcepath))
                    {
                        Directory.Delete(sourcepath, true);
                        Directory.CreateDirectory(sourcepath);
                    }
                    else
                    {
                        Directory.CreateDirectory(sourcepath);
                    }

                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sourcepath, "*", SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sourcepath, destinationpath));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sourcepath, "*.*", SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourcepath, destinationpath), true);
                    refreshsaves();

                }
                refreshsaves();
            }
        }

        private void refreshlist_Click(object sender, EventArgs e)
        {
            refreshsaves();
        }

        private void loadgame_Click_1(object sender, EventArgs e)
        {       
            

        }

        private void savecopy_Click(object sender, EventArgs e)
        {
            if (savelist.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a save first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name = savelist.SelectedItem.ToString();
                deletefolder();
                copypast();
                refreshsaves();
                MessageBox.Show("Backup of " + name + "'s profile done. You can restore it by renaming " + name +"_old to " + name + " in saves folder", "NMS Saves Manager: Backup successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void copypast()
        {
            string curitem = savelist.SelectedItem.ToString();
            string sourcepath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + curitem);
            string destinationpath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + curitem + "_old");

            if (Directory.Exists(destinationpath))
            {
                Directory.Delete(destinationpath, true);
                Directory.CreateDirectory(destinationpath);
            }
            else
            {
                Directory.CreateDirectory(destinationpath);
            }
            
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcepath, "*", SearchOption.AllDirectories))
            Directory.CreateDirectory(dirPath.Replace(sourcepath, destinationpath));

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcepath, "*.*",SearchOption.AllDirectories))
            File.Copy(newPath, newPath.Replace(sourcepath, destinationpath), true);
        }

        private void deletefolder()
        {
            if (onloadprofil == true)
            {
                string destinationpath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + profiltoload + "_old");
                if (Directory.Exists(destinationpath))
                {
                    Directory.Delete(destinationpath, true);
                }
            }
            else
            {
                string curitem = savelist.SelectedItem.ToString();
                string destinationpath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + curitem + "_old");
                string defaultpath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + userprofile);
                if (Directory.Exists(destinationpath))
                {
                    Directory.Delete(destinationpath, true);                    
                }
            }
            onloadprofil = false;
        }


        private void refreshsaves()
        {
            savelist.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(savepath);
            DirectoryInfo[] Files = dinfo.GetDirectories();

            foreach (DirectoryInfo file in Files)
                {
                    if (!file.Name.Contains(userprofile) && !file.Name.Contains("_old") && !file.Name.Contains("st_"))
                    {
                        savelist.Items.Add(file.Name);                    
                }
        }
        }//Refresh saves list

        private void checkbkpauto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbkpauto.Checked)
            {
                trackBar1.Enabled = true;
            }
            else
            {
                trackBar1.Enabled = false;
            }
        }

        private void loadsave_Click(object sender, EventArgs e)
        {
            if (savelist.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a save first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sourcepath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + userprofile);
                string destinationpath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + userprofile + "_old");
                onloadprofil = true;

                if (Directory.Exists(destinationpath))
                {
                    Directory.Delete(destinationpath, true);
                    Directory.CreateDirectory(destinationpath);
                }
                else
                {
                    Directory.CreateDirectory(destinationpath);
                }

                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(sourcepath, "*", SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(sourcepath, destinationpath));

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(sourcepath, "*.*", SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(sourcepath, destinationpath), true);

                Directory.Delete(sourcepath, true);
                Directory.CreateDirectory(sourcepath);

                string curitem = savelist.SelectedItem.ToString();
                string sourcenew = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + curitem);
                string destinationnew = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + userprofile);
                profiltoload = curitem; 


                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(sourcenew, "*", SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(sourcenew, destinationnew));

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(sourcenew, "*.*", SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(sourcenew, destinationnew), true);

                lastloaded = curitem;
                refreshsaves();
                
                actload.Text = lastloaded;
                loaded = lastloaded;
                System.IO.File.WriteAllText(lastloadedstorage, loaded);
                autobackupdelay = trackBar1.Value;

                if ((autobackupdelay != 0) && (checkbkpauto.Checked == true))
                {
                    var timer = new System.Threading.Timer(
                    f => autobackup(),
                    null,
                    TimeSpan.Zero,
                    TimeSpan.FromMinutes(autobackupdelay));
                    if ((File.Exists(NMSextpath)) && (useNMSe.Checked == true))
                    {
                        System.Diagnostics.Process.Start(NMSextpath);
                        System.Threading.Thread.Sleep(5000);
                    }
                    else
                    {
                            System.Diagnostics.Process.Start(NMSpathexe);
                    }
                    doautoqwerty();
                }
                else
                {
                    if ((File.Exists(NMSextpath)) && (useNMSe.Checked == true))
                    {
                        System.Diagnostics.Process.Start(NMSextpath);
                        System.Threading.Thread.Sleep(5000);
                    }
                    else
                    {
                            System.Diagnostics.Process.Start(NMSpathexe);
                    }
                    doautoqwerty();
                    System.Windows.Forms.Application.Exit();
                }
                loadsave.Enabled = false;
                trackBar1.Enabled = false;
            }
        }
        private void autobackup()
        {
            string profil = System.IO.File.ReadAllText(lastloadedstorage);
            string profilsave = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + profil);
            string defaultuser = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + nmsprofilefolder + userprofile);

            if (Directory.Exists(profilsave))
            {
                Directory.Delete(profilsave, true);
                Directory.CreateDirectory(profilsave);
            }

 
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(defaultuser, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(defaultuser, profilsave));

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(defaultuser, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(defaultuser, profilsave), true);      
        }

        private void savelist_SelectedIndexChanged(object sender, EventArgs e)
        {

            System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName("NMS");
            if (proc.Length == 0) 
            {
                loadsave.Enabled = true;
                if (checkbkpauto.Checked == true)
                {
                    trackBar1.Enabled = true;
                }
            }    
            else
            {
                MessageBox.Show(String.Format("No Man's Sky is still running ! You can't load a profile now.", "NMS"), "NMS Saves Manager: Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadsave.Enabled = false;
                trackBar1.Enabled = false;
            }
        }

        private void doautoqwerty()
        {
            if (checkautoqwerty.Checked == true)
            {
                Process p = Process.GetProcessesByName("NMS").FirstOrDefault();
                if (p != null)
                {
                    IntPtr h = p.MainWindowHandle;
                    System.Threading.Thread.Sleep(10000);
                    SetForegroundWindow(h);
                    SendKeys.SendWait("%(+)");
                }
            }
        }

        private void openbinaries_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(NMSpath);
        }

        private void openmods_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(modstoragepath))
            {
                MessageBox.Show(String.Format("It's seems to be the first time you want to use mods or mods folder from NMS:SM. Please unzip all your .pak mods in "+ modstoragepath +" from now !", "NMS"), "NMS Saves Manager: Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Directory.CreateDirectory(modstoragepath);
            }
            System.Diagnostics.Process.Start(modstoragepath);            
        }

        private void gamesettings_Click(object sender, EventArgs e)
        {
            form_gamesettings gamesets = new form_gamesettings();
            gamesets.Show();
        }

        private void modssettings_Click(object sender, EventArgs e)
        {
            Form_ModsSettings modset = new Form_ModsSettings();
            modset.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form_restoreprofile backup = new form_restoreprofile();
            backup.Show();
        }
    }
    public enum GameVersionsEnum
    {
        GOG,
        Steam,
        NotSet,
        Unknowed
    }
}
