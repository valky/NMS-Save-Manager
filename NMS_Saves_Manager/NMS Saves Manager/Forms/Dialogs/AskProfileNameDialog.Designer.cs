namespace NMS_Saves_Manager.Forms.Dialogs
{
    partial class AskProfileNameDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskProfileNameDialog));
            this.BTN_NewSaveOK = new System.Windows.Forms.Button();
            this.TBX_ProfileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_NewSaveOK
            // 
            this.BTN_NewSaveOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_NewSaveOK.Location = new System.Drawing.Point(178, 12);
            this.BTN_NewSaveOK.Name = "BTN_NewSaveOK";
            this.BTN_NewSaveOK.Size = new System.Drawing.Size(39, 20);
            this.BTN_NewSaveOK.TabIndex = 28;
            this.BTN_NewSaveOK.Text = "OK";
            this.BTN_NewSaveOK.UseVisualStyleBackColor = true;
            // 
            // TBX_ProfileName
            // 
            this.TBX_ProfileName.Location = new System.Drawing.Point(12, 12);
            this.TBX_ProfileName.Name = "TBX_ProfileName";
            this.TBX_ProfileName.Size = new System.Drawing.Size(160, 20);
            this.TBX_ProfileName.TabIndex = 29;
            this.TBX_ProfileName.Text = "New Profile Name";
            this.TBX_ProfileName.Enter += new System.EventHandler(this.TBX_ProfileName_Enter);
            // 
            // AskProfileNameDialog
            // 
            this.AcceptButton = this.BTN_NewSaveOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 40);
            this.Controls.Add(this.BTN_NewSaveOK);
            this.Controls.Add(this.TBX_ProfileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 79);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(240, 79);
            this.Name = "AskProfileNameDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile Name";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskProfileNameDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_NewSaveOK;
        private System.Windows.Forms.TextBox TBX_ProfileName;
    }
}