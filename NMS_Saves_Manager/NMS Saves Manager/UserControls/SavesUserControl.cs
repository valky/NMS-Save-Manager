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
            _SaveManager = SaveManager.Instance;
            _NMSSMManager = NMSSMManager.Instance;

        }

        private void newsave_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            newsaveok.Enabled = true;
            textBox1.Text = "";
            this.ActiveControl = textBox1;
        }

        private void newsaveok_Click(object sender, EventArgs e)
        {
            _SaveManager.CreateNewEmptyProfile(textBox1.Text);
        }
    }
}
