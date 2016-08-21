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
using System.IO;

namespace NMS_Saves_Manager.UserControls
{
    public partial class SavesUserControl : UserControl
    {
        private SaveManager _SaveManager = SaveManager.Instance;
        private NMSSMManager _NMSSMManager = NMSSMManager.Instance;

        public SavesUserControl()
        {
            InitializeComponent();
            RefreshProfileList();
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


        private void savecopy_Click(object sender, EventArgs e)
        {
            if (savelist.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a save first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name = savelist.SelectedItem.ToString();
                _SaveManager.BackupProfile(name);
                MessageBox.Show("Backup of " + name + "'s profile done. You can restore it by renaming " + name + "_old to " + name + " in saves folder", "NMS Saves Manager: Backup successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





        private void RefreshProfileList()
        {
            _SaveManager.GetProfileList().ForEach(s => savelist.Items.Add(s));
        }
    }
}
