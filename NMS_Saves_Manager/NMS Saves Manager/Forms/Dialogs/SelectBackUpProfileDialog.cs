using NMS_Saves_Manager.Managers;
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
    public partial class SelectBackUpProfileDialog : Form
    {
        private SaveManager _SaveManager = SaveManager.Instance;
        private NMSSMManager _NMSSMManager = NMSSMManager.Instance;

        public string Result = string.Empty;

        public SelectBackUpProfileDialog()
        {
            InitializeComponent();
            LoadBackUpList();
        }


        private void LoadBackUpList()
        {
            comboBox1.Items.Clear();
            _SaveManager.GetBackUpCurrentProfileList().ForEach(s => comboBox1.Items.Add(s));
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void SelectBackUpProfileDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Result = comboBox1.SelectedItem.ToString();
        }

        private void BTN_NewSaveOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to restore " + comboBox1.SelectedItem.ToString() + " ?", "Restore ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
