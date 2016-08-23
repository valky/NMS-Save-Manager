namespace NMS_Saves_Manager
{
    partial class form_main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.newsave = new System.Windows.Forms.Button();
            this.savefolder = new System.Windows.Forms.Button();
            this.savelist = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newsaveok = new System.Windows.Forms.Button();
            this.refreshlist = new System.Windows.Forms.Button();
            this.savecopy = new System.Windows.Forms.Button();
            this.loadsave = new System.Windows.Forms.Button();
            this.checkbkpauto = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelregle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkautoqwerty = new System.Windows.Forms.CheckBox();
            this.helplabel = new System.Windows.Forms.Label();
            this.lastsession = new System.Windows.Forms.Label();
            this.actloaded = new System.Windows.Forms.Label();
            this.actload = new System.Windows.Forms.Label();
            this.openbinaries = new System.Windows.Forms.Button();
            this.openmods = new System.Windows.Forms.Button();
            this.gamesettings = new System.Windows.Forms.Button();
            this.modssettings = new System.Windows.Forms.Button();
            this.useNMSe = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_restore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newsave
            // 
            this.newsave.Location = new System.Drawing.Point(24, 202);
            this.newsave.Name = "newsave";
            this.newsave.Size = new System.Drawing.Size(113, 38);
            this.newsave.TabIndex = 1;
            this.newsave.Text = "New Profile";
            this.newsave.UseVisualStyleBackColor = true;
            this.newsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // savefolder
            // 
            this.savefolder.Location = new System.Drawing.Point(48, 443);
            this.savefolder.Name = "savefolder";
            this.savefolder.Size = new System.Drawing.Size(135, 24);
            this.savefolder.TabIndex = 1;
            this.savefolder.Text = "Open Saves Folder";
            this.savefolder.UseVisualStyleBackColor = true;
            this.savefolder.Click += new System.EventHandler(this.button2_Click);
            // 
            // savelist
            // 
            this.savelist.Location = new System.Drawing.Point(48, 300);
            this.savelist.Name = "savelist";
            this.savelist.Size = new System.Drawing.Size(328, 69);
            this.savelist.TabIndex = 10;
            this.savelist.SelectedIndexChanged += new System.EventHandler(this.savelist_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(48, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "New Save Name";
            // 
            // newsaveok
            // 
            this.newsaveok.Enabled = false;
            this.newsaveok.Location = new System.Drawing.Point(214, 261);
            this.newsaveok.Name = "newsaveok";
            this.newsaveok.Size = new System.Drawing.Size(39, 20);
            this.newsaveok.TabIndex = 4;
            this.newsaveok.Text = "OK";
            this.newsaveok.UseVisualStyleBackColor = true;
            this.newsaveok.Click += new System.EventHandler(this.newsaveok_Click);
            // 
            // refreshlist
            // 
            this.refreshlist.Location = new System.Drawing.Point(301, 258);
            this.refreshlist.Name = "refreshlist";
            this.refreshlist.Size = new System.Drawing.Size(75, 23);
            this.refreshlist.TabIndex = 8;
            this.refreshlist.Text = "Refresh";
            this.refreshlist.UseVisualStyleBackColor = true;
            this.refreshlist.Click += new System.EventHandler(this.refreshlist_Click);
            // 
            // savecopy
            // 
            this.savecopy.Location = new System.Drawing.Point(155, 202);
            this.savecopy.Name = "savecopy";
            this.savecopy.Size = new System.Drawing.Size(113, 38);
            this.savecopy.TabIndex = 9;
            this.savecopy.Text = "Backup Profile";
            this.savecopy.UseVisualStyleBackColor = true;
            this.savecopy.Click += new System.EventHandler(this.savecopy_Click);
            // 
            // loadsave
            // 
            this.loadsave.Location = new System.Drawing.Point(265, 554);
            this.loadsave.Name = "loadsave";
            this.loadsave.Size = new System.Drawing.Size(135, 38);
            this.loadsave.TabIndex = 11;
            this.loadsave.Text = "Load Profile";
            this.loadsave.UseVisualStyleBackColor = true;
            this.loadsave.Click += new System.EventHandler(this.loadsave_Click);
            // 
            // checkbkpauto
            // 
            this.checkbkpauto.AutoSize = true;
            this.checkbkpauto.Checked = true;
            this.checkbkpauto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbkpauto.Location = new System.Drawing.Point(301, 399);
            this.checkbkpauto.Name = "checkbkpauto";
            this.checkbkpauto.Size = new System.Drawing.Size(90, 17);
            this.checkbkpauto.TabIndex = 12;
            this.checkbkpauto.Text = "Backup auto.";
            this.checkbkpauto.UseVisualStyleBackColor = true;
            this.checkbkpauto.CheckedChanged += new System.EventHandler(this.checkbkpauto_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(24, 386);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(259, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 13;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 15;
            // 
            // labelregle
            // 
            this.labelregle.AutoSize = true;
            this.labelregle.Location = new System.Drawing.Point(78, 374);
            this.labelregle.Name = "labelregle";
            this.labelregle.Size = new System.Drawing.Size(13, 13);
            this.labelregle.TabIndex = 14;
            this.labelregle.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "15";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "25 min";
            // 
            // checkautoqwerty
            // 
            this.checkautoqwerty.AccessibleDescription = "";
            this.checkautoqwerty.AutoSize = true;
            this.checkautoqwerty.Location = new System.Drawing.Point(301, 443);
            this.checkautoqwerty.Name = "checkautoqwerty";
            this.checkautoqwerty.Size = new System.Drawing.Size(99, 17);
            this.checkautoqwerty.TabIndex = 15;
            this.checkautoqwerty.Tag = "";
            this.checkautoqwerty.Text = "Auto QWERTY";
            this.checkautoqwerty.UseVisualStyleBackColor = true;
            // 
            // helplabel
            // 
            this.helplabel.AutoSize = true;
            this.helplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helplabel.Location = new System.Drawing.Point(50, 549);
            this.helplabel.Name = "helplabel";
            this.helplabel.Size = new System.Drawing.Size(71, 36);
            this.helplabel.TabIndex = 16;
            this.helplabel.Text = "Last session:    \r\n\r\nActually loaded:";
            // 
            // lastsession
            // 
            this.lastsession.AutoSize = true;
            this.lastsession.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastsession.Location = new System.Drawing.Point(127, 549);
            this.lastsession.Name = "lastsession";
            this.lastsession.Size = new System.Drawing.Size(29, 12);
            this.lastsession.TabIndex = 17;
            this.lastsession.Text = "label6";
            // 
            // actloaded
            // 
            this.actloaded.AutoSize = true;
            this.actloaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actloaded.Location = new System.Drawing.Point(123, 512);
            this.actloaded.Name = "actloaded";
            this.actloaded.Size = new System.Drawing.Size(0, 12);
            this.actloaded.TabIndex = 18;
            // 
            // actload
            // 
            this.actload.AutoSize = true;
            this.actload.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actload.Location = new System.Drawing.Point(127, 573);
            this.actload.Name = "actload";
            this.actload.Size = new System.Drawing.Size(29, 12);
            this.actload.TabIndex = 17;
            this.actload.Text = "label6";
            // 
            // openbinaries
            // 
            this.openbinaries.Location = new System.Drawing.Point(48, 473);
            this.openbinaries.Name = "openbinaries";
            this.openbinaries.Size = new System.Drawing.Size(135, 24);
            this.openbinaries.TabIndex = 19;
            this.openbinaries.Text = "Open Binaries Folder";
            this.openbinaries.UseVisualStyleBackColor = true;
            this.openbinaries.Click += new System.EventHandler(this.openbinaries_Click);
            // 
            // openmods
            // 
            this.openmods.Location = new System.Drawing.Point(48, 505);
            this.openmods.Name = "openmods";
            this.openmods.Size = new System.Drawing.Size(135, 24);
            this.openmods.TabIndex = 20;
            this.openmods.Text = "Open Mods Folder";
            this.openmods.UseVisualStyleBackColor = true;
            this.openmods.Click += new System.EventHandler(this.openmods_Click);
            // 
            // gamesettings
            // 
            this.gamesettings.Location = new System.Drawing.Point(265, 466);
            this.gamesettings.Name = "gamesettings";
            this.gamesettings.Size = new System.Drawing.Size(135, 38);
            this.gamesettings.TabIndex = 21;
            this.gamesettings.Text = "Game Settings";
            this.gamesettings.UseVisualStyleBackColor = true;
            this.gamesettings.Click += new System.EventHandler(this.gamesettings_Click);
            // 
            // modssettings
            // 
            this.modssettings.Location = new System.Drawing.Point(265, 510);
            this.modssettings.Name = "modssettings";
            this.modssettings.Size = new System.Drawing.Size(135, 38);
            this.modssettings.TabIndex = 22;
            this.modssettings.Text = "Mods Settings";
            this.modssettings.UseVisualStyleBackColor = true;
            this.modssettings.Click += new System.EventHandler(this.modssettings_Click);
            // 
            // useNMSe
            // 
            this.useNMSe.AccessibleDescription = "";
            this.useNMSe.AutoSize = true;
            this.useNMSe.Checked = true;
            this.useNMSe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useNMSe.Location = new System.Drawing.Point(301, 422);
            this.useNMSe.Name = "useNMSe";
            this.useNMSe.Size = new System.Drawing.Size(116, 17);
            this.useNMSe.TabIndex = 23;
            this.useNMSe.Tag = "";
            this.useNMSe.Text = "Use NMS extender";
            this.useNMSe.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NMS_Saves_Manager.Properties.Resources.NMS_head;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(286, 202);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(114, 38);
            this.btn_restore.TabIndex = 24;
            this.btn_restore.Text = "Restore Profile";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 601);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.openmods);
            this.Controls.Add(this.openbinaries);
            this.Controls.Add(this.actloaded);
            this.Controls.Add(this.actload);
            this.Controls.Add(this.lastsession);
            this.Controls.Add(this.helplabel);
            this.Controls.Add(this.savefolder);
            this.Controls.Add(this.useNMSe);
            this.Controls.Add(this.modssettings);
            this.Controls.Add(this.gamesettings);
            this.Controls.Add(this.checkautoqwerty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelregle);
            this.Controls.Add(this.checkbkpauto);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.loadsave);
            this.Controls.Add(this.savecopy);
            this.Controls.Add(this.refreshlist);
            this.Controls.Add(this.newsaveok);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.savelist);
            this.Controls.Add(this.newsave);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NMS Saves Manager";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button newsave;
        private System.Windows.Forms.Button savefolder;
        private System.Windows.Forms.ListBox savelist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button newsaveok;
        private System.Windows.Forms.Button refreshlist;
        private System.Windows.Forms.Button savecopy;
        private System.Windows.Forms.Button loadsave;
        private System.Windows.Forms.CheckBox checkbkpauto;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelregle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkautoqwerty;
        private System.Windows.Forms.Label helplabel;
        private System.Windows.Forms.Label lastsession;
        private System.Windows.Forms.Label actloaded;
        private System.Windows.Forms.Label actload;
        private System.Windows.Forms.Button openbinaries;
        private System.Windows.Forms.Button openmods;
        private System.Windows.Forms.Button gamesettings;
        private System.Windows.Forms.Button modssettings;
        private System.Windows.Forms.CheckBox useNMSe;
        private System.Windows.Forms.Button btn_restore;
    }
}

