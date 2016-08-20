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

        private NMSSMManager _NMSSMManager = NMSSMManager.Instance;



        public SaveManager()
        {

        }

        /// <summary>
        /// Create a new profile with the <paramref name="profileName"/>
        /// </summary>
        /// <param name="profileName"></param>
        public void CreateNewEmptyProfile(string profileName)
        {
            if (string.IsNullOrWhiteSpace(profileName))
            {
                throw new Exception("empty profile name");
                //MessageBox.Show("Enter New Profil Name Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (profileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                throw new Exception("Invalid profile name");
            }

            string newProfileFolderPath = _NMSSMManager.NMSSavePath + @"\" + profileName;

            if (Directory.Exists(newProfileFolderPath))
            {
                throw new Exception("profile already exist");
            }

            Directory.CreateDirectory(newProfileFolderPath);

            //If it the first profile we copy the existing savefiles in the new profile folder
            if (Directory.GetDirectories(_NMSSMManager.NMSSavePath).Count() < 3)
            {
                CopySaveToProfile(profileName);
            }

        }

        /// <summary>
        /// Copy the game saves into the profile (<paramref name="profileName"/> ) saves
        /// </summary>
        /// <param name="profileName"></param>
        public void CopySaveToProfile(string profileName)
        {
            string sourcePath = _NMSSMManager.NMSDefaultSavePath;

            string profileFolderPath = _NMSSMManager.NMSSavePath + @"\" + profileName;

            if (Directory.Exists(profileFolderPath))
            {
                Directory.Delete(profileFolderPath, true);
            }

            Directory.CreateDirectory(profileFolderPath);

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(sourcePath, profileFolderPath));

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(sourcePath, profileFolderPath), true);
        }

        /// <summary>
        /// Return the list of profiles
        /// </summary>
        /// <returns></returns>
        public List<string> GetProfileList()
        {
            List<string> profilesList = new List<string>();

            string[] filesPathes = Directory.GetDirectories(_NMSSMManager.NMSSavePath);

            foreach (string filePath in filesPathes)
            {
                if (!filePath.Contains(_NMSSMManager.NMSDefaultSavePath))
                {
                    profilesList.Add(filePath.Replace(_NMSSMManager.NMSSavePath + @"\", string.Empty));
                }
            }

            return profilesList;
        }

    }
}
