namespace NMS_Saves_Manager
{
    partial class Form_ModsSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ModsSettings));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chk_reshade = new System.Windows.Forms.CheckBox();
            this.lb_modlist = new System.Windows.Forms.CheckedListBox();
            this.btn_refreshlist = new System.Windows.Forms.Button();
            this.btn_printmods = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_delshade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NMS_Saves_Manager.Properties.Resources.NMS_head;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(419, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // chk_reshade
            // 
            this.chk_reshade.AutoSize = true;
            this.chk_reshade.Enabled = false;
            this.chk_reshade.Location = new System.Drawing.Point(28, 580);
            this.chk_reshade.Name = "chk_reshade";
            this.chk_reshade.Size = new System.Drawing.Size(156, 17);
            this.chk_reshade.TabIndex = 4;
            this.chk_reshade.Text = "Use NMS Reshade Presets";
            this.chk_reshade.UseVisualStyleBackColor = true;
            this.chk_reshade.CheckedChanged += new System.EventHandler(this.chk_reshade_CheckedChanged);
            // 
            // lb_modlist
            // 
            this.lb_modlist.FormattingEnabled = true;
            this.lb_modlist.Location = new System.Drawing.Point(39, 196);
            this.lb_modlist.Name = "lb_modlist";
            this.lb_modlist.Size = new System.Drawing.Size(335, 319);
            this.lb_modlist.TabIndex = 5;
            this.lb_modlist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lb_modlist_ItemCheck);
            this.lb_modlist.SelectedIndexChanged += new System.EventHandler(this.lb_modlist_SelectedIndexChanged);
            // 
            // btn_refreshlist
            // 
            this.btn_refreshlist.Location = new System.Drawing.Point(294, 521);
            this.btn_refreshlist.Name = "btn_refreshlist";
            this.btn_refreshlist.Size = new System.Drawing.Size(75, 23);
            this.btn_refreshlist.TabIndex = 6;
            this.btn_refreshlist.Text = "Refresh";
            this.btn_refreshlist.UseVisualStyleBackColor = true;
            this.btn_refreshlist.Click += new System.EventHandler(this.btn_refreshlist_Click);
            // 
            // btn_printmods
            // 
            this.btn_printmods.Location = new System.Drawing.Point(28, 521);
            this.btn_printmods.Name = "btn_printmods";
            this.btn_printmods.Size = new System.Drawing.Size(117, 23);
            this.btn_printmods.TabIndex = 7;
            this.btn_printmods.Text = "Print Mods List";
            this.btn_printmods.UseVisualStyleBackColor = true;
            this.btn_printmods.Click += new System.EventHandler(this.btn_printmods_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(294, 555);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(96, 42);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_delshade
            // 
            this.btn_delshade.Location = new System.Drawing.Point(28, 551);
            this.btn_delshade.Name = "btn_delshade";
            this.btn_delshade.Size = new System.Drawing.Size(117, 23);
            this.btn_delshade.TabIndex = 9;
            this.btn_delshade.Text = "Delete Shadercache";
            this.btn_delshade.UseVisualStyleBackColor = true;
            this.btn_delshade.Click += new System.EventHandler(this.btn_delshade_Click);
            // 
            // Form_ModsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 609);
            this.Controls.Add(this.btn_delshade);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_printmods);
            this.Controls.Add(this.btn_refreshlist);
            this.Controls.Add(this.lb_modlist);
            this.Controls.Add(this.chk_reshade);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ModsSettings";
            this.Text = "NMS:SM Mods selection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chk_reshade;
        private System.Windows.Forms.CheckedListBox lb_modlist;
        private System.Windows.Forms.Button btn_refreshlist;
        private System.Windows.Forms.Button btn_printmods;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_delshade;
    }
}