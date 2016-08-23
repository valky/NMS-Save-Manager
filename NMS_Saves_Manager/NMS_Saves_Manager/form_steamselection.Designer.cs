namespace NMS_Saves_Manager
{
    partial class form_steamselection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_steamselection));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_getID = new System.Windows.Forms.Button();
            this.btn_loadsteamprofile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(419, 69);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btn_getID
            // 
            this.btn_getID.Location = new System.Drawing.Point(30, 180);
            this.btn_getID.Name = "btn_getID";
            this.btn_getID.Size = new System.Drawing.Size(126, 39);
            this.btn_getID.TabIndex = 2;
            this.btn_getID.Text = "Get my SteamID";
            this.btn_getID.UseVisualStyleBackColor = true;
            this.btn_getID.Click += new System.EventHandler(this.btn_getID_Click);
            // 
            // btn_loadsteamprofile
            // 
            this.btn_loadsteamprofile.Enabled = false;
            this.btn_loadsteamprofile.Location = new System.Drawing.Point(358, 180);
            this.btn_loadsteamprofile.Name = "btn_loadsteamprofile";
            this.btn_loadsteamprofile.Size = new System.Drawing.Size(126, 39);
            this.btn_loadsteamprofile.TabIndex = 3;
            this.btn_loadsteamprofile.Text = "Select";
            this.btn_loadsteamprofile.UseVisualStyleBackColor = true;
            this.btn_loadsteamprofile.Click += new System.EventHandler(this.btn_loadsteamprofile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please select your Steam ID";
            // 
            // form_steamselection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 231);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_loadsteamprofile);
            this.Controls.Add(this.btn_getID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_steamselection";
            this.Text = "Steam account selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_getID;
        private System.Windows.Forms.Button btn_loadsteamprofile;
        private System.Windows.Forms.Label label2;
    }
}