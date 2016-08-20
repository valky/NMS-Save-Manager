using NMS_Saves_Manager.Enums;
using NMS_Saves_Manager.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NMS_Saves_Manager.Managers
{
    public class NMSSMManager
    {

        #region Singleton

        private static NMSSMManager _Instance = null;

        public static NMSSMManager Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NMSSMManager();
                }
                return _Instance;
            }
        }

        #endregion

        #region Properties

        private string _NMSExePath = string.Empty;
        public string NMSExePath
        {
            get
            {
                if (_NMSExePath == string.Empty)
                {
                    _NMSExePath = NMSBinariesPath + @"\" + Resources.NMSExeName;
                }
                return _NMSExePath;
            }
        }

        private string _NMSSavePath = string.Empty;
        public string NMSSavePath
        {
            get
            {
                if (_NMSSavePath == string.Empty)
                {
                    _NMSSavePath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + NMSProfilesFolder);
                }
                return _NMSSavePath;
            }
        }

        private string _NMSModsPath = string.Empty;
        public string NMSModsPath
        {
            get
            {
                if (_NMSModsPath == string.Empty)
                {
                    _NMSModsPath = NMSBinariesPath.Replace(@"\" + Resources.NMSBinaries, @"\" + Resources.NMSPcBanksFolder);
                }
                return _NMSModsPath;
            }
        }

        private string _NMSProfilesFolder = string.Empty;
        public string NMSProfilesFolder
        {
            get
            {
                if (_NMSProfilesFolder == string.Empty)
                {
                    _NMSProfilesFolder = @"\" + Resources.NMSProfilesFolder;
                }
                return _NMSProfilesFolder;
            }
        }

        private string _NMSExtenderPath = string.Empty;
        public string NMSExtenderPath
        {
            get
            {
                if (_NMSExtenderPath == string.Empty)
                {
                    _NMSExtenderPath = NMSBinariesPath + @"\" + Resources.NMSEExeName;
                }
                return _NMSExtenderPath;
            }
        }

        private string _ModsStoragePath = string.Empty;
        public string ModsStoragePath
        {
            get
            {
                if (_ModsStoragePath == string.Empty)
                {
                    _ModsStoragePath = NMSBinariesPath + @"\" + Resources.ModsStorage;
                }
                return _ModsStoragePath;
            }
        }

        private string _NMSDefaultSavePath = string.Empty;
        public string NMSDefaultSavePath
        {
            get
            {
                if (_NMSDefaultSavePath == string.Empty)
                {
                    switch (GameVersion)
                    {
                        case GameVersionsEnum.GOG:
                            _NMSDefaultSavePath = NMSSavePath + @"\" + "DefaultUser";
                            break;
                        case GameVersionsEnum.Steam:
                            _NMSDefaultSavePath = Directory.GetDirectories(NMSSavePath).FirstOrDefault(f => f.Contains("st_"));
                            break;
                        case GameVersionsEnum.NotSet:
                            break;
                        case GameVersionsEnum.Unknowed:
                            break;
                        default:
                            break;
                    }
                }
                return _NMSDefaultSavePath;
            }
        }

        public string NMSBinariesPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

        private GameVersionsEnum _GameVersion;
        public GameVersionsEnum GameVersion
        {
            get
            {
                if (_GameVersion == null)
                {
                    DetectGameVersion();
                }
                return _GameVersion;
            }
        }

        #endregion

        public NMSSMManager()
        {


        }



        private void DetectGameVersion()
        {
            if (!File.Exists(NMSSavePath))
                throw new Exception("path empty");

            string GOGFolder = NMSSavePath + @"\" + "DefaultUser";

            bool isGOG = File.Exists(GOGFolder);
            bool isSteam = Directory.GetFiles(NMSSavePath).Count(f => f.Contains("st_")) > 0;

            if (isGOG)
                _GameVersion = GameVersionsEnum.GOG;

            if (isSteam)
                _GameVersion = GameVersionsEnum.Steam;

            if (!isGOG && !isSteam)
                _GameVersion = GameVersionsEnum.NotSet;

            if (isGOG && isSteam)
                _GameVersion = GameVersionsEnum.Unknowed;
        }
    }
}
