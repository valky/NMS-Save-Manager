namespace NMS_Saves_Manager.UserControls
{
    partial class SavesUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CKB_UseNMSE = new System.Windows.Forms.CheckBox();
            this.BTN_ModSettings = new System.Windows.Forms.Button();
            this.BTN_GameSettings = new System.Windows.Forms.Button();
            this.BTN_OpenModsFolder = new System.Windows.Forms.Button();
            this.BTN_OpenBinariesFolder = new System.Windows.Forms.Button();
            this.LBL_CurrentProfile = new System.Windows.Forms.Label();
            this.LBL_LastProfileLoaded = new System.Windows.Forms.Label();
            this.LBL_Label_LastSession = new System.Windows.Forms.Label();
            this.CKB_AutoQWERTY = new System.Windows.Forms.CheckBox();
            this.LBL_25MIN = new System.Windows.Forms.Label();
            this.LBL_20MIN = new System.Windows.Forms.Label();
            this.LBL_15MIN = new System.Windows.Forms.Label();
            this.LBL_10MIN = new System.Windows.Forms.Label();
            this.LBL_5MIN = new System.Windows.Forms.Label();
            this.CKB_AutoBackUp = new System.Windows.Forms.CheckBox();
            this.TBR_AutoSave = new System.Windows.Forms.TrackBar();
            this.BTN_LoadProfile = new System.Windows.Forms.Button();
            this.BTN_BackUpProfile = new System.Windows.Forms.Button();
            this.BTN_RefreshListProfile = new System.Windows.Forms.Button();
            this.LTB_ProfilesList = new System.Windows.Forms.ListBox();
            this.BTN_OpenSavesFolder = new System.Windows.Forms.Button();
            this.BTN_NewProfile = new System.Windows.Forms.Button();
            this.TLP_LabelInfoSession = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_Label_CurrentSession = new System.Windows.Forms.Label();
            this.BTN_RestoreProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TBR_AutoSave)).BeginInit();
            this.TLP_LabelInfoSession.SuspendLayout();
            this.SuspendLayout();
            // 
            // CKB_UseNMSE
            // 
            this.CKB_UseNMSE.AccessibleDescription = "";
            this.CKB_UseNMSE.AutoSize = true;
            this.CKB_UseNMSE.Location = new System.Drawing.Point(282, 253);
            this.CKB_UseNMSE.Name = "CKB_UseNMSE";
            this.CKB_UseNMSE.Size = new System.Drawing.Size(116, 17);
            this.CKB_UseNMSE.TabIndex = 48;
            this.CKB_UseNMSE.Tag = "";
            this.CKB_UseNMSE.Text = "Use NMS extender";
            this.CKB_UseNMSE.UseVisualStyleBackColor = true;
            // 
            // BTN_ModSettings
            // 
            this.BTN_ModSettings.Location = new System.Drawing.Point(246, 320);
            this.BTN_ModSettings.Name = "BTN_ModSettings";
            this.BTN_ModSettings.Size = new System.Drawing.Size(135, 38);
            this.BTN_ModSettings.TabIndex = 47;
            this.BTN_ModSettings.Text = "Mods Settings";
            this.BTN_ModSettings.UseVisualStyleBackColor = true;
            // 
            // BTN_GameSettings
            // 
            this.BTN_GameSettings.Location = new System.Drawing.Point(246, 276);
            this.BTN_GameSettings.Name = "BTN_GameSettings";
            this.BTN_GameSettings.Size = new System.Drawing.Size(135, 38);
            this.BTN_GameSettings.TabIndex = 46;
            this.BTN_GameSettings.Text = "Game Settings";
            this.BTN_GameSettings.UseVisualStyleBackColor = true;
            // 
            // BTN_OpenModsFolder
            // 
            this.BTN_OpenModsFolder.Location = new System.Drawing.Point(16, 315);
            this.BTN_OpenModsFolder.Name = "BTN_OpenModsFolder";
            this.BTN_OpenModsFolder.Size = new System.Drawing.Size(135, 24);
            this.BTN_OpenModsFolder.TabIndex = 45;
            this.BTN_OpenModsFolder.Text = "Open Mods Folder";
            this.BTN_OpenModsFolder.UseVisualStyleBackColor = true;
            this.BTN_OpenModsFolder.Click += new System.EventHandler(this.BTN_OpenModsFolder_Click);
            // 
            // BTN_OpenBinariesFolder
            // 
            this.BTN_OpenBinariesFolder.Location = new System.Drawing.Point(16, 283);
            this.BTN_OpenBinariesFolder.Name = "BTN_OpenBinariesFolder";
            this.BTN_OpenBinariesFolder.Size = new System.Drawing.Size(135, 24);
            this.BTN_OpenBinariesFolder.TabIndex = 44;
            this.BTN_OpenBinariesFolder.Text = "Open Binaries Folder";
            this.BTN_OpenBinariesFolder.UseVisualStyleBackColor = true;
            this.BTN_OpenBinariesFolder.Click += new System.EventHandler(this.BTN_OpenBinariesFolder_Click);
            // 
            // LBL_CurrentProfile
            // 
            this.LBL_CurrentProfile.AutoSize = true;
            this.LBL_CurrentProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CurrentProfile.Location = new System.Drawing.Point(96, 18);
            this.LBL_CurrentProfile.Name = "LBL_CurrentProfile";
            this.LBL_CurrentProfile.Size = new System.Drawing.Size(0, 12);
            this.LBL_CurrentProfile.TabIndex = 42;
            // 
            // LBL_LastProfileLoaded
            // 
            this.LBL_LastProfileLoaded.AutoSize = true;
            this.LBL_LastProfileLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_LastProfileLoaded.Location = new System.Drawing.Point(96, 0);
            this.LBL_LastProfileLoaded.Name = "LBL_LastProfileLoaded";
            this.LBL_LastProfileLoaded.Size = new System.Drawing.Size(0, 12);
            this.LBL_LastProfileLoaded.TabIndex = 41;
            // 
            // LBL_Label_LastSession
            // 
            this.LBL_Label_LastSession.AutoSize = true;
            this.LBL_Label_LastSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Label_LastSession.Location = new System.Drawing.Point(3, 0);
            this.LBL_Label_LastSession.Name = "LBL_Label_LastSession";
            this.LBL_Label_LastSession.Size = new System.Drawing.Size(60, 12);
            this.LBL_Label_LastSession.TabIndex = 40;
            this.LBL_Label_LastSession.Text = "Last session:";
            // 
            // CKB_AutoQWERTY
            // 
            this.CKB_AutoQWERTY.AccessibleDescription = "";
            this.CKB_AutoQWERTY.AutoSize = true;
            this.CKB_AutoQWERTY.Location = new System.Drawing.Point(282, 231);
            this.CKB_AutoQWERTY.Name = "CKB_AutoQWERTY";
            this.CKB_AutoQWERTY.Size = new System.Drawing.Size(99, 17);
            this.CKB_AutoQWERTY.TabIndex = 39;
            this.CKB_AutoQWERTY.Tag = "";
            this.CKB_AutoQWERTY.Text = "Auto QWERTY";
            this.CKB_AutoQWERTY.UseVisualStyleBackColor = true;
            // 
            // LBL_25MIN
            // 
            this.LBL_25MIN.AutoSize = true;
            this.LBL_25MIN.Location = new System.Drawing.Point(243, 184);
            this.LBL_25MIN.Name = "LBL_25MIN";
            this.LBL_25MIN.Size = new System.Drawing.Size(38, 13);
            this.LBL_25MIN.TabIndex = 37;
            this.LBL_25MIN.Text = "25 min";
            // 
            // LBL_20MIN
            // 
            this.LBL_20MIN.AutoSize = true;
            this.LBL_20MIN.Location = new System.Drawing.Point(196, 184);
            this.LBL_20MIN.Name = "LBL_20MIN";
            this.LBL_20MIN.Size = new System.Drawing.Size(19, 13);
            this.LBL_20MIN.TabIndex = 38;
            this.LBL_20MIN.Text = "20";
            // 
            // LBL_15MIN
            // 
            this.LBL_15MIN.AutoSize = true;
            this.LBL_15MIN.Location = new System.Drawing.Point(149, 184);
            this.LBL_15MIN.Name = "LBL_15MIN";
            this.LBL_15MIN.Size = new System.Drawing.Size(19, 13);
            this.LBL_15MIN.TabIndex = 36;
            this.LBL_15MIN.Text = "15";
            // 
            // LBL_10MIN
            // 
            this.LBL_10MIN.AutoSize = true;
            this.LBL_10MIN.Location = new System.Drawing.Point(102, 184);
            this.LBL_10MIN.Name = "LBL_10MIN";
            this.LBL_10MIN.Size = new System.Drawing.Size(19, 13);
            this.LBL_10MIN.TabIndex = 35;
            this.LBL_10MIN.Text = "10";
            // 
            // LBL_5MIN
            // 
            this.LBL_5MIN.AutoSize = true;
            this.LBL_5MIN.Location = new System.Drawing.Point(59, 184);
            this.LBL_5MIN.Name = "LBL_5MIN";
            this.LBL_5MIN.Size = new System.Drawing.Size(13, 13);
            this.LBL_5MIN.TabIndex = 34;
            this.LBL_5MIN.Text = "5";
            // 
            // CKB_AutoBackUp
            // 
            this.CKB_AutoBackUp.AutoSize = true;
            this.CKB_AutoBackUp.Checked = true;
            this.CKB_AutoBackUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_AutoBackUp.Location = new System.Drawing.Point(282, 209);
            this.CKB_AutoBackUp.Name = "CKB_AutoBackUp";
            this.CKB_AutoBackUp.Size = new System.Drawing.Size(90, 17);
            this.CKB_AutoBackUp.TabIndex = 32;
            this.CKB_AutoBackUp.Text = "Backup auto.";
            this.CKB_AutoBackUp.UseVisualStyleBackColor = true;
            this.CKB_AutoBackUp.CheckedChanged += new System.EventHandler(this.CKB_AutoBackUp_CheckedChanged);
            // 
            // TBR_AutoSave
            // 
            this.TBR_AutoSave.Location = new System.Drawing.Point(5, 196);
            this.TBR_AutoSave.Maximum = 25;
            this.TBR_AutoSave.Name = "TBR_AutoSave";
            this.TBR_AutoSave.Size = new System.Drawing.Size(259, 45);
            this.TBR_AutoSave.SmallChange = 5;
            this.TBR_AutoSave.TabIndex = 33;
            this.TBR_AutoSave.TickFrequency = 5;
            this.TBR_AutoSave.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TBR_AutoSave.Value = 15;
            // 
            // BTN_LoadProfile
            // 
            this.BTN_LoadProfile.Location = new System.Drawing.Point(246, 364);
            this.BTN_LoadProfile.Name = "BTN_LoadProfile";
            this.BTN_LoadProfile.Size = new System.Drawing.Size(135, 38);
            this.BTN_LoadProfile.TabIndex = 31;
            this.BTN_LoadProfile.Text = "Load Profile";
            this.BTN_LoadProfile.UseVisualStyleBackColor = true;
            this.BTN_LoadProfile.Click += new System.EventHandler(this.BTN_LoadProfile_Click);
            // 
            // BTN_BackUpProfile
            // 
            this.BTN_BackUpProfile.Location = new System.Drawing.Point(148, 12);
            this.BTN_BackUpProfile.Name = "BTN_BackUpProfile";
            this.BTN_BackUpProfile.Size = new System.Drawing.Size(113, 38);
            this.BTN_BackUpProfile.TabIndex = 29;
            this.BTN_BackUpProfile.Text = "Backup Profile";
            this.BTN_BackUpProfile.UseVisualStyleBackColor = true;
            this.BTN_BackUpProfile.Click += new System.EventHandler(this.BTN_BackUpProfile_Click);
            // 
            // BTN_RefreshListProfile
            // 
            this.BTN_RefreshListProfile.Location = new System.Drawing.Point(282, 68);
            this.BTN_RefreshListProfile.Name = "BTN_RefreshListProfile";
            this.BTN_RefreshListProfile.Size = new System.Drawing.Size(75, 23);
            this.BTN_RefreshListProfile.TabIndex = 28;
            this.BTN_RefreshListProfile.Text = "Refresh";
            this.BTN_RefreshListProfile.UseVisualStyleBackColor = true;
            this.BTN_RefreshListProfile.Click += new System.EventHandler(this.BTN_RefreshListProfile_Click);
            // 
            // LTB_ProfilesList
            // 
            this.LTB_ProfilesList.Location = new System.Drawing.Point(29, 110);
            this.LTB_ProfilesList.Name = "LTB_ProfilesList";
            this.LTB_ProfilesList.Size = new System.Drawing.Size(328, 69);
            this.LTB_ProfilesList.TabIndex = 30;
            this.LTB_ProfilesList.SelectedIndexChanged += new System.EventHandler(this.LTB_ProfilesList_SelectedIndexChanged);
            // 
            // BTN_OpenSavesFolder
            // 
            this.BTN_OpenSavesFolder.Location = new System.Drawing.Point(16, 253);
            this.BTN_OpenSavesFolder.Name = "BTN_OpenSavesFolder";
            this.BTN_OpenSavesFolder.Size = new System.Drawing.Size(135, 24);
            this.BTN_OpenSavesFolder.TabIndex = 25;
            this.BTN_OpenSavesFolder.Text = "Open Saves Folder";
            this.BTN_OpenSavesFolder.UseVisualStyleBackColor = true;
            this.BTN_OpenSavesFolder.Click += new System.EventHandler(this.BTN_OpenSavesFolder_Click);
            // 
            // BTN_NewProfile
            // 
            this.BTN_NewProfile.Location = new System.Drawing.Point(29, 12);
            this.BTN_NewProfile.Name = "BTN_NewProfile";
            this.BTN_NewProfile.Size = new System.Drawing.Size(113, 38);
            this.BTN_NewProfile.TabIndex = 24;
            this.BTN_NewProfile.Text = "New Profile";
            this.BTN_NewProfile.UseVisualStyleBackColor = true;
            this.BTN_NewProfile.Click += new System.EventHandler(this.BTN_NewProfile_Click);
            // 
            // TLP_LabelInfoSession
            // 
            this.TLP_LabelInfoSession.ColumnCount = 2;
            this.TLP_LabelInfoSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_LabelInfoSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_LabelInfoSession.Controls.Add(this.LBL_CurrentProfile, 1, 1);
            this.TLP_LabelInfoSession.Controls.Add(this.LBL_LastProfileLoaded, 1, 0);
            this.TLP_LabelInfoSession.Controls.Add(this.LBL_Label_LastSession, 0, 0);
            this.TLP_LabelInfoSession.Controls.Add(this.LBL_Label_CurrentSession, 0, 1);
            this.TLP_LabelInfoSession.Location = new System.Drawing.Point(16, 364);
            this.TLP_LabelInfoSession.Name = "TLP_LabelInfoSession";
            this.TLP_LabelInfoSession.RowCount = 2;
            this.TLP_LabelInfoSession.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_LabelInfoSession.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_LabelInfoSession.Size = new System.Drawing.Size(186, 37);
            this.TLP_LabelInfoSession.TabIndex = 49;
            // 
            // LBL_Label_CurrentSession
            // 
            this.LBL_Label_CurrentSession.AutoSize = true;
            this.LBL_Label_CurrentSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.LBL_Label_CurrentSession.Location = new System.Drawing.Point(3, 18);
            this.LBL_Label_CurrentSession.Name = "LBL_Label_CurrentSession";
            this.LBL_Label_CurrentSession.Size = new System.Drawing.Size(74, 12);
            this.LBL_Label_CurrentSession.TabIndex = 43;
            this.LBL_Label_CurrentSession.Text = "Actually Loaded:";
            // 
            // BTN_RestoreProfile
            // 
            this.BTN_RestoreProfile.Location = new System.Drawing.Point(267, 12);
            this.BTN_RestoreProfile.Name = "BTN_RestoreProfile";
            this.BTN_RestoreProfile.Size = new System.Drawing.Size(114, 38);
            this.BTN_RestoreProfile.TabIndex = 50;
            this.BTN_RestoreProfile.Text = "Restore Profile";
            this.BTN_RestoreProfile.UseVisualStyleBackColor = true;
            this.BTN_RestoreProfile.Click += new System.EventHandler(this.BTN_RestoreProfile_Click);
            // 
            // SavesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_RestoreProfile);
            this.Controls.Add(this.TLP_LabelInfoSession);
            this.Controls.Add(this.CKB_UseNMSE);
            this.Controls.Add(this.BTN_ModSettings);
            this.Controls.Add(this.BTN_GameSettings);
            this.Controls.Add(this.BTN_OpenModsFolder);
            this.Controls.Add(this.BTN_OpenBinariesFolder);
            this.Controls.Add(this.CKB_AutoQWERTY);
            this.Controls.Add(this.LBL_25MIN);
            this.Controls.Add(this.LBL_20MIN);
            this.Controls.Add(this.LBL_15MIN);
            this.Controls.Add(this.LBL_10MIN);
            this.Controls.Add(this.LBL_5MIN);
            this.Controls.Add(this.CKB_AutoBackUp);
            this.Controls.Add(this.TBR_AutoSave);
            this.Controls.Add(this.BTN_LoadProfile);
            this.Controls.Add(this.BTN_BackUpProfile);
            this.Controls.Add(this.BTN_RefreshListProfile);
            this.Controls.Add(this.LTB_ProfilesList);
            this.Controls.Add(this.BTN_OpenSavesFolder);
            this.Controls.Add(this.BTN_NewProfile);
            this.Name = "SavesUserControl";
            this.Size = new System.Drawing.Size(402, 415);
            ((System.ComponentModel.ISupportInitialize)(this.TBR_AutoSave)).EndInit();
            this.TLP_LabelInfoSession.ResumeLayout(false);
            this.TLP_LabelInfoSession.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CKB_UseNMSE;
        private System.Windows.Forms.Button BTN_ModSettings;
        private System.Windows.Forms.Button BTN_GameSettings;
        private System.Windows.Forms.Button BTN_OpenModsFolder;
        private System.Windows.Forms.Button BTN_OpenBinariesFolder;
        private System.Windows.Forms.Label LBL_CurrentProfile;
        private System.Windows.Forms.Label LBL_LastProfileLoaded;
        private System.Windows.Forms.Label LBL_Label_LastSession;
        private System.Windows.Forms.CheckBox CKB_AutoQWERTY;
        private System.Windows.Forms.Label LBL_25MIN;
        private System.Windows.Forms.Label LBL_20MIN;
        private System.Windows.Forms.Label LBL_15MIN;
        private System.Windows.Forms.Label LBL_10MIN;
        private System.Windows.Forms.Label LBL_5MIN;
        private System.Windows.Forms.CheckBox CKB_AutoBackUp;
        private System.Windows.Forms.TrackBar TBR_AutoSave;
        private System.Windows.Forms.Button BTN_LoadProfile;
        private System.Windows.Forms.Button BTN_BackUpProfile;
        private System.Windows.Forms.Button BTN_RefreshListProfile;
        private System.Windows.Forms.ListBox LTB_ProfilesList;
        private System.Windows.Forms.Button BTN_OpenSavesFolder;
        private System.Windows.Forms.Button BTN_NewProfile;
        private System.Windows.Forms.TableLayoutPanel TLP_LabelInfoSession;
        private System.Windows.Forms.Label LBL_Label_CurrentSession;
        private System.Windows.Forms.Button BTN_RestoreProfile;
    }
}
