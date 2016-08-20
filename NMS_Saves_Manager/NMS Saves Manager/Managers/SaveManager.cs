using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMS_Saves_Manager.Managers
{
    public class SaveManager
    {

        #region Singleton

        private static SaveManager _Instance = null;

        public static SaveManager Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SaveManager();
                }
                return _Instance;
            }
        }

        #endregion

        private NMSSMManager _NMSSMManager;



        public SaveManager()
        {
            _NMSSMManager = NMSSMManager.Instance;
        }

        public void CreateNewEmptyProfile(string profileName)
        {
            if (string.IsNullOrWhiteSpace(profileName))
            {
                throw new Exception("empty name");
                //MessageBox.Show("Enter New Profil Name Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string newProfileFolderPath = _NMSSMManager.NMSSavePath + @"\" + profileName;
            Directory.CreateDirectory(newProfileFolderPath);

            if (Directory.GetDirectories(_NMSSMManager.NMSSavePath).Count() < 3)
            {
                CopySaveToProfile(profileName);
            }

        }





        private void CopySaveToProfile(string profileName)
        {
            string sourcePath = _NMSSMManager.NMSDefaultSavePath;

            string profileFolderPath = _NMSSMManager.NMSSavePath + @"\" + profileName;

            if (!Directory.Exists(profileFolderPath))
            {
                Directory.CreateDirectory(profileFolderPath);
            }

            ////Now Create all of the directories
            //foreach (string dirPath in Directory.GetDirectories(sourcepath, "*", SearchOption.AllDirectories))
            //    Directory.CreateDirectory(dirPath.Replace(sourcepath, destinationpath));

            ////Copy all the files & Replaces any files with the same name
            //foreach (string newPath in Directory.GetFiles(sourcepath, "*.*", SearchOption.AllDirectories))
            //    File.Copy(newPath, newPath.Replace(sourcepath, destinationpath), true);
        }



    }
}
