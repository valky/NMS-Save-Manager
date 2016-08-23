using NMS_Saves_Manager.Forms.Dialogs;
using NMS_Saves_Manager.Managers;
using System;
using System.Diagnostics;
using System.Windows.Forms;

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
            LBL_LastProfileLoaded.Text = _NMSSMManager.CurrentProfile;
            LTB_ProfilesList.SelectedItem  = _NMSSMManager.CurrentProfile;
        }

        #region Privates

        /// <summary>
        /// Update the profile list
        /// </summary>
        private void RefreshProfileList()
        {
            LTB_ProfilesList.Items.Clear();
            _SaveManager.GetProfileList().ForEach(s => LTB_ProfilesList.Items.Add(s));
        }

        #endregion

        #region Events

        private void BTN_NewProfile_Click(object sender, EventArgs e)
        {
            using (AskProfileNameDialog dialog = new AskProfileNameDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _SaveManager.CreateNewEmptyProfile(dialog.Result);
                }
            }
            RefreshProfileList();
        }

        private void BTN_LoadProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_NMSSMManager.CurrentProfile))
            {
                MessageBox.Show("Please select a save first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _NMSSMManager.SetLastProfileLoaded();
            }
        }

        private void BTN_BackUpProfile_Click(object sender, EventArgs e)
        {
            if (LTB_ProfilesList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a save first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _SaveManager.BackupProfile(_NMSSMManager.CurrentProfile);
                MessageBox.Show("Backup of " + _NMSSMManager.CurrentProfile + "'s profile done. You can restore it by renaming " + _NMSSMManager.CurrentProfile + "_old to " + _NMSSMManager.CurrentProfile + " in saves folder", "NMS Saves Manager: Backup successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_RestoreProfile_Click(object sender, EventArgs e)
        {
            if (LTB_ProfilesList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a save first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (SelectBackUpProfileDialog dialog = new SelectBackUpProfileDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        _SaveManager.RestoreBackUpProfile(dialog.Result, _NMSSMManager.CurrentProfile);
                    }

                }
            }
        }

        private void BTN_OpenModsFolder_Click(object sender, EventArgs e)
        {
            Process.Start(_NMSSMManager.NMSModsPath);
        }

        private void BTN_OpenSavesFolder_Click(object sender, EventArgs e)
        {
            Process.Start(_NMSSMManager.NMSSavePath);
        }

        private void BTN_RefreshListProfile_Click(object sender, EventArgs e)
        {
            RefreshProfileList();
        }

        private void BTN_OpenBinariesFolder_Click(object sender, EventArgs e)
        {
            Process.Start(_NMSSMManager.NMSBinariesPath);
        }

        private void CKB_AutoBackUp_CheckedChanged(object sender, EventArgs e)
        {
            TBR_AutoSave.Enabled = CKB_AutoBackUp.Checked;

        }

        private void LTB_ProfilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _NMSSMManager.CurrentProfile = LTB_ProfilesList.SelectedItem.ToString();
            LBL_CurrentProfile.Text = _NMSSMManager.CurrentProfile;
        }

        #endregion

    }
}
