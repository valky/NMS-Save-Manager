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
            LoadList();
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

        private void LoadList()
        {
            // Create a new FileSystemWatcher and set its properties.
            //FileSystemWatcher watcher = new FileSystemWatcher();
            //watcher.NotifyFilter = NotifyFilters.
            _SaveManager.GetProfileList().ForEach(s => savelist.Items.Add(s));
        }
    }
}
