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


        public string NMSBinariesPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);


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
                    _NMSSavePath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + NMSProfilesPath);
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
                    _NMSModsPath = NMSBinariesPath.Replace(@"\" + Resources.NMSBinaries, @"\" + Resources.NMSPcBanksPath);
                }
                return _NMSModsPath;
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

        private string _NMSProfilesPath = string.Empty;
        public string NMSProfilesPath
        {
            get
            {
                if (_NMSProfilesPath == string.Empty)
                {
                    _NMSProfilesPath = @"\" + Resources.NMSRoamingPath;
                }
                return _NMSProfilesPath;
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



    }
}
