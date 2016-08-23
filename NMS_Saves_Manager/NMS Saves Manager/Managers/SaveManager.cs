using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
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
                //We filter on the default save path and the backups
                if (!filePath.Contains(_NMSSMManager.NMSDefaultSavePath) 
                    &&
                    !filePath.Contains(_NMSSMManager.NMSBackupsPath))
                {
                    profilesList.Add(filePath.Replace(_NMSSMManager.NMSSavePath + @"\", string.Empty));
                }
            }

            return profilesList;
        }

        /// <summary>
        /// Return the list of backup for the current profile
        /// </summary>
        /// <returns></returns>
        public List<string> GetBackUpCurrentProfileList()
        {
            return GetBackUpProfileList(_NMSSMManager.CurrentProfile);
        }

        /// <summary>
        /// Return the lsit of backup for a profile
        /// </summary>
        /// <param name="profileName"></param>
        /// <returns></returns>
        public List<string> GetBackUpProfileList(string profileName)
        {
            List<string> backupsList = new List<string>();

            string[] filesPathes = Directory.GetDirectories(_NMSSMManager.NMSBackupsPath);

            foreach (string filePath in filesPathes)
            {
                //We filter on the other backups
                if (filePath.Contains(profileName))
                {
                    backupsList.Add(filePath.Replace(_NMSSMManager.NMSBackupsPath + @"\", string.Empty));
                }
            }

            return backupsList;
        }

        /// <summary>
        /// Create a backup for the profile
        /// </summary>
        /// <param name="profileName"></param>
        public void BackupProfile(string profileName)
        {
            if (string.IsNullOrWhiteSpace(profileName))
            {
                throw new Exception("empty profile name");
            }

            if (profileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                throw new Exception("Invalid profile name");
            }

            string profileFolderPath = _NMSSMManager.NMSSavePath + @"\" + profileName;

            if (! Directory.Exists(profileFolderPath))
            {
                throw new Exception("profile doesn't exist");
            }

            string backupsFolderPath = _NMSSMManager.NMSBackupsPath;

            //If the backups folder didn t exist we create it
            if (!Directory.Exists(backupsFolderPath))
            {
                Directory.CreateDirectory(backupsFolderPath);
                File.SetAttributes(backupsFolderPath, FileAttributes.Normal);
            }

            string dest = backupsFolderPath + @"\" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString().Replace(":","-") + " - " + profileName;

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(profileFolderPath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(profileFolderPath, dest));

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(profileFolderPath, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(profileFolderPath, dest), true);
        }

        /// <summary>
        /// Restore a backup
        /// </summary>
        /// <param name="backupName">The name of tha backup to restore</param>
        /// <param name="profileName">The name of the profile</param>
        public void RestoreBackUpProfile(string backupName, string profileName)
        {
            if (string.IsNullOrWhiteSpace(backupName))
            {
                throw new Exception("empty backup Name");
            }

            if (backupName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                throw new Exception("Invalid backup name");
            }

            string backupFolderPath = _NMSSMManager.NMSBackupsPath + @"\" + backupName;

            if (!Directory.Exists(backupFolderPath))
            {
                throw new Exception("backup doesn't exist");
            }

            string profileFolderPath = _NMSSMManager.NMSSavePath + @"\" + profileName;

            //If the profile exist we delete it (to avoid old copy)
            if (Directory.Exists(profileFolderPath))
            {
                Directory.Delete(profileFolderPath,true);
            }

            //Create the destination folder
            Directory.CreateDirectory(profileFolderPath);
            //File.SetAttributes(profileFolderPath, FileAttributes.Normal);

            string dest = profileFolderPath;

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(backupFolderPath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(backupFolderPath, dest));

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(backupFolderPath, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(backupFolderPath, dest), true);
        }

    }
}
