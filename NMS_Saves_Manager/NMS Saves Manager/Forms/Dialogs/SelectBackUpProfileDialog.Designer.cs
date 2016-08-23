namespace NMS_Saves_Manager.Forms.Dialogs
{
    partial class SelectBackUpProfileDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectBackUpProfileDialog));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTN_NewSaveOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // BTN_NewSaveOK
            // 
            this.BTN_NewSaveOK.Location = new System.Drawing.Point(317, 14);
            this.BTN_NewSaveOK.Name = "BTN_NewSaveOK";
            this.BTN_NewSaveOK.Size = new System.Drawing.Size(39, 20);
            this.BTN_NewSaveOK.TabIndex = 29;
            this.BTN_NewSaveOK.Text = "OK";
            this.BTN_NewSaveOK.UseVisualStyleBackColor = true;
            this.BTN_NewSaveOK.Click += new System.EventHandler(this.BTN_NewSaveOK_Click);
            // 
            // SelectBackUpProfileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 45);
            this.Controls.Add(this.BTN_NewSaveOK);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 84);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(377, 84);
            this.Name = "SelectBackUpProfileDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select a backup to restore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectBackUpProfileDialog_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BTN_NewSaveOK;
    }
}