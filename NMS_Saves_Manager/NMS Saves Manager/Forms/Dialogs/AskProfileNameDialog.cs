using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMS_Saves_Manager.Forms.Dialogs
{
    public partial class AskProfileNameDialog : Form
    {
        private bool _IsFirstClick = true;

        public string Result = string.Empty;

        public AskProfileNameDialog()
        {
            InitializeComponent();
        }

        #region Events
        private void TBX_ProfileName_Enter(object sender, EventArgs e)
        {
            if (_IsFirstClick)
            {
                TBX_ProfileName.Clear();
                _IsFirstClick = false;
            }
        }

        private void AskProfileNameDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Result = TBX_ProfileName.Text;
        }

        #endregion

    }
}
