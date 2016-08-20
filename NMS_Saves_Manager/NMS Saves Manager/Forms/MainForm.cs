using NMS_Saves_Manager.Managers;
using NMS_Saves_Manager.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMS_Saves_Manager.Forms
{
    public partial class MainForm : Form
    {
        private NMSSMManager _NMSSMManager;
        private SavesUserControl _SaveControl;


        public MainForm()
        {
            InitializeComponent();
            _NMSSMManager = NMSSMManager.Instance;
            LoadSaveControl();
        }

        private void LoadSaveControl()
        {
            _SaveControl = new SavesUserControl();
            _SaveControl.Dock = DockStyle.Fill;
            PNL_Main.Controls.Add(_SaveControl);
        }


    }
}
