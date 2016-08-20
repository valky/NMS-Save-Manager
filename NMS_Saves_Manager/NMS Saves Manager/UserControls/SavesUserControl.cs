using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NMS_Saves_Manager.Managers;

namespace NMS_Saves_Manager.UserControls
{
    public partial class SavesUserControl : UserControl
    {
        private SaveManager _SaveManager;
        private NMSSMManager _NMSSMManager;
        public SavesUserControl()
        {
            InitializeComponent();

            //_SaveManager = SaveManager.
            _NMSSMManager = NMSSMManager.Instance;

        }
    }
}
