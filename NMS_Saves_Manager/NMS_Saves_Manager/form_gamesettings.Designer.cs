namespace NMS_Saves_Manager
{
    partial class form_gamesettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_gamesettings));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbl_reflections = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_monitor = new System.Windows.Forms.Label();
            this.lbl_generation = new System.Windows.Forms.Label();
            this.lbl_textures = new System.Windows.Forms.Label();
            this.lbl_shadows = new System.Windows.Forms.Label();
            this.lbl_aa = new System.Windows.Forms.Label();
            this.lbl_aniso = new System.Windows.Forms.Label();
            this.lbl_fovfoot = new System.Windows.Forms.Label();
            this.lbl_fovship = new System.Windows.Forms.Label();
            this.lbl_brightness = new System.Windows.Forms.Label();
            this.lbl_framerate = new System.Windows.Forms.Label();
            this.chk_Fullscreen = new System.Windows.Forms.CheckBox();
            this.chk_borderless = new System.Windows.Forms.CheckBox();
            this.chk_vsync = new System.Windows.Forms.CheckBox();
            this.chk_gsync = new System.Windows.Forms.CheckBox();
            this.chk_screenres = new System.Windows.Forms.CheckBox();
            this.chk_hud = new System.Windows.Forms.CheckBox();
            this.cb_monitor = new System.Windows.Forms.ComboBox();
            this.cb_framerate = new System.Windows.Forms.ComboBox();
            this.cb_generation = new System.Windows.Forms.ComboBox();
            this.cb_reflections = new System.Windows.Forms.ComboBox();
            this.cb_aniso = new System.Windows.Forms.ComboBox();
            this.cb_shadows = new System.Windows.Forms.ComboBox();
            this.cb_textures = new System.Windows.Forms.ComboBox();
            this.cb_aa = new System.Windows.Forms.ComboBox();
            this.trb_fovfoot = new System.Windows.Forms.TrackBar();
            this.trb_fovship = new System.Windows.Forms.TrackBar();
            this.trb_brightness = new System.Windows.Forms.TrackBar();
            this.tb_fovfoot = new System.Windows.Forms.TextBox();
            this.tb_fovship = new System.Windows.Forms.TextBox();
            this.tb_brightness = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_screeninfo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trb_reswidth = new System.Windows.Forms.TrackBar();
            this.trb_resheight = new System.Windows.Forms.TrackBar();
            this.tb_reswidth = new System.Windows.Forms.TextBox();
            this.tb_resheight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trb_fovfoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_fovship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_reswidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_resheight)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(481, 84);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lbl_reflections
            // 
            this.lbl_reflections.AutoSize = true;
            this.lbl_reflections.Location = new System.Drawing.Point(207, 406);
            this.lbl_reflections.Name = "lbl_reflections";
            this.lbl_reflections.Size = new System.Drawing.Size(95, 13);
            this.lbl_reflections.TabIndex = 5;
            this.lbl_reflections.Text = "Reflections Quality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resolution Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Resolution Width";
            // 
            // lbl_monitor
            // 
            this.lbl_monitor.AutoSize = true;
            this.lbl_monitor.Location = new System.Drawing.Point(27, 358);
            this.lbl_monitor.Name = "lbl_monitor";
            this.lbl_monitor.Size = new System.Drawing.Size(42, 13);
            this.lbl_monitor.TabIndex = 9;
            this.lbl_monitor.Text = "Monitor";
            // 
            // lbl_generation
            // 
            this.lbl_generation.AutoSize = true;
            this.lbl_generation.Location = new System.Drawing.Point(207, 382);
            this.lbl_generation.Name = "lbl_generation";
            this.lbl_generation.Size = new System.Drawing.Size(97, 13);
            this.lbl_generation.TabIndex = 12;
            this.lbl_generation.Text = "Generation  Details";
            // 
            // lbl_textures
            // 
            this.lbl_textures.AutoSize = true;
            this.lbl_textures.Location = new System.Drawing.Point(27, 406);
            this.lbl_textures.Name = "lbl_textures";
            this.lbl_textures.Size = new System.Drawing.Size(83, 13);
            this.lbl_textures.TabIndex = 13;
            this.lbl_textures.Text = "Textures Details";
            // 
            // lbl_shadows
            // 
            this.lbl_shadows.AutoSize = true;
            this.lbl_shadows.Location = new System.Drawing.Point(27, 382);
            this.lbl_shadows.Name = "lbl_shadows";
            this.lbl_shadows.Size = new System.Drawing.Size(86, 13);
            this.lbl_shadows.TabIndex = 14;
            this.lbl_shadows.Text = "Shadows Details";
            // 
            // lbl_aa
            // 
            this.lbl_aa.AutoSize = true;
            this.lbl_aa.Location = new System.Drawing.Point(27, 430);
            this.lbl_aa.Name = "lbl_aa";
            this.lbl_aa.Size = new System.Drawing.Size(64, 13);
            this.lbl_aa.TabIndex = 15;
            this.lbl_aa.Text = "Anti Aliasing";
            // 
            // lbl_aniso
            // 
            this.lbl_aniso.AutoSize = true;
            this.lbl_aniso.Location = new System.Drawing.Point(207, 430);
            this.lbl_aniso.Name = "lbl_aniso";
            this.lbl_aniso.Size = new System.Drawing.Size(85, 13);
            this.lbl_aniso.TabIndex = 16;
            this.lbl_aniso.Text = "Anisotropy Level";
            // 
            // lbl_fovfoot
            // 
            this.lbl_fovfoot.AutoSize = true;
            this.lbl_fovfoot.Location = new System.Drawing.Point(24, 486);
            this.lbl_fovfoot.Name = "lbl_fovfoot";
            this.lbl_fovfoot.Size = new System.Drawing.Size(67, 13);
            this.lbl_fovfoot.TabIndex = 17;
            this.lbl_fovfoot.Text = "FoV On Foot";
            // 
            // lbl_fovship
            // 
            this.lbl_fovship.AutoSize = true;
            this.lbl_fovship.Location = new System.Drawing.Point(24, 514);
            this.lbl_fovship.Name = "lbl_fovship";
            this.lbl_fovship.Size = new System.Drawing.Size(62, 13);
            this.lbl_fovship.TabIndex = 18;
            this.lbl_fovship.Text = "FoV In Ship";
            // 
            // lbl_brightness
            // 
            this.lbl_brightness.AutoSize = true;
            this.lbl_brightness.Location = new System.Drawing.Point(27, 542);
            this.lbl_brightness.Name = "lbl_brightness";
            this.lbl_brightness.Size = new System.Drawing.Size(56, 13);
            this.lbl_brightness.TabIndex = 19;
            this.lbl_brightness.Text = "Brightness";
            // 
            // lbl_framerate
            // 
            this.lbl_framerate.AutoSize = true;
            this.lbl_framerate.Location = new System.Drawing.Point(207, 358);
            this.lbl_framerate.Name = "lbl_framerate";
            this.lbl_framerate.Size = new System.Drawing.Size(77, 13);
            this.lbl_framerate.TabIndex = 20;
            this.lbl_framerate.Text = "Max Framerate";
            // 
            // chk_Fullscreen
            // 
            this.chk_Fullscreen.AutoSize = true;
            this.chk_Fullscreen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_Fullscreen.Location = new System.Drawing.Point(30, 213);
            this.chk_Fullscreen.Name = "chk_Fullscreen";
            this.chk_Fullscreen.Size = new System.Drawing.Size(74, 17);
            this.chk_Fullscreen.TabIndex = 22;
            this.chk_Fullscreen.Text = "Fullscreen";
            this.chk_Fullscreen.UseVisualStyleBackColor = true;
            // 
            // chk_borderless
            // 
            this.chk_borderless.AutoSize = true;
            this.chk_borderless.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_borderless.Location = new System.Drawing.Point(30, 236);
            this.chk_borderless.Name = "chk_borderless";
            this.chk_borderless.Size = new System.Drawing.Size(75, 17);
            this.chk_borderless.TabIndex = 23;
            this.chk_borderless.Text = "Borderless";
            this.chk_borderless.UseVisualStyleBackColor = true;
            // 
            // chk_vsync
            // 
            this.chk_vsync.AutoSize = true;
            this.chk_vsync.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_vsync.Location = new System.Drawing.Point(165, 213);
            this.chk_vsync.Name = "chk_vsync";
            this.chk_vsync.Size = new System.Drawing.Size(55, 17);
            this.chk_vsync.TabIndex = 24;
            this.chk_vsync.Text = "Vsync";
            this.chk_vsync.UseVisualStyleBackColor = true;
            // 
            // chk_gsync
            // 
            this.chk_gsync.AutoSize = true;
            this.chk_gsync.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_gsync.Location = new System.Drawing.Point(165, 236);
            this.chk_gsync.Name = "chk_gsync";
            this.chk_gsync.Size = new System.Drawing.Size(56, 17);
            this.chk_gsync.TabIndex = 25;
            this.chk_gsync.Text = "Gsync";
            this.chk_gsync.UseVisualStyleBackColor = true;
            // 
            // chk_screenres
            // 
            this.chk_screenres.AutoSize = true;
            this.chk_screenres.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_screenres.Location = new System.Drawing.Point(263, 213);
            this.chk_screenres.Name = "chk_screenres";
            this.chk_screenres.Size = new System.Drawing.Size(135, 17);
            this.chk_screenres.TabIndex = 26;
            this.chk_screenres.Text = "Use Screen Resolution";
            this.chk_screenres.UseVisualStyleBackColor = true;
            // 
            // chk_hud
            // 
            this.chk_hud.AutoSize = true;
            this.chk_hud.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_hud.Location = new System.Drawing.Point(335, 236);
            this.chk_hud.Name = "chk_hud";
            this.chk_hud.Size = new System.Drawing.Size(63, 17);
            this.chk_hud.TabIndex = 27;
            this.chk_hud.Text = "No Hud";
            this.chk_hud.UseVisualStyleBackColor = true;
            // 
            // cb_monitor
            // 
            this.cb_monitor.FormattingEnabled = true;
            this.cb_monitor.Location = new System.Drawing.Point(122, 354);
            this.cb_monitor.Name = "cb_monitor";
            this.cb_monitor.Size = new System.Drawing.Size(43, 21);
            this.cb_monitor.TabIndex = 29;
            // 
            // cb_framerate
            // 
            this.cb_framerate.FormattingEnabled = true;
            this.cb_framerate.Location = new System.Drawing.Point(319, 358);
            this.cb_framerate.Name = "cb_framerate";
            this.cb_framerate.Size = new System.Drawing.Size(43, 21);
            this.cb_framerate.TabIndex = 29;
            // 
            // cb_generation
            // 
            this.cb_generation.FormattingEnabled = true;
            this.cb_generation.Location = new System.Drawing.Point(319, 381);
            this.cb_generation.Name = "cb_generation";
            this.cb_generation.Size = new System.Drawing.Size(79, 21);
            this.cb_generation.TabIndex = 30;
            // 
            // cb_reflections
            // 
            this.cb_reflections.FormattingEnabled = true;
            this.cb_reflections.Location = new System.Drawing.Point(319, 404);
            this.cb_reflections.Name = "cb_reflections";
            this.cb_reflections.Size = new System.Drawing.Size(79, 21);
            this.cb_reflections.TabIndex = 30;
            // 
            // cb_aniso
            // 
            this.cb_aniso.FormattingEnabled = true;
            this.cb_aniso.Location = new System.Drawing.Point(319, 427);
            this.cb_aniso.Name = "cb_aniso";
            this.cb_aniso.Size = new System.Drawing.Size(79, 21);
            this.cb_aniso.TabIndex = 30;
            // 
            // cb_shadows
            // 
            this.cb_shadows.FormattingEnabled = true;
            this.cb_shadows.Location = new System.Drawing.Point(122, 381);
            this.cb_shadows.Name = "cb_shadows";
            this.cb_shadows.Size = new System.Drawing.Size(79, 21);
            this.cb_shadows.TabIndex = 30;
            // 
            // cb_textures
            // 
            this.cb_textures.FormattingEnabled = true;
            this.cb_textures.Location = new System.Drawing.Point(122, 404);
            this.cb_textures.Name = "cb_textures";
            this.cb_textures.Size = new System.Drawing.Size(79, 21);
            this.cb_textures.TabIndex = 30;
            // 
            // cb_aa
            // 
            this.cb_aa.FormattingEnabled = true;
            this.cb_aa.Location = new System.Drawing.Point(122, 427);
            this.cb_aa.Name = "cb_aa";
            this.cb_aa.Size = new System.Drawing.Size(79, 21);
            this.cb_aa.TabIndex = 30;
            // 
            // trb_fovfoot
            // 
            this.trb_fovfoot.Location = new System.Drawing.Point(186, 480);
            this.trb_fovfoot.Maximum = 200;
            this.trb_fovfoot.Minimum = 50;
            this.trb_fovfoot.Name = "trb_fovfoot";
            this.trb_fovfoot.Size = new System.Drawing.Size(212, 45);
            this.trb_fovfoot.TabIndex = 31;
            this.trb_fovfoot.Value = 50;
            this.trb_fovfoot.Scroll += new System.EventHandler(this.trb_fovfoot_Scroll);
            // 
            // trb_fovship
            // 
            this.trb_fovship.Location = new System.Drawing.Point(186, 511);
            this.trb_fovship.Maximum = 200;
            this.trb_fovship.Minimum = 50;
            this.trb_fovship.Name = "trb_fovship";
            this.trb_fovship.Size = new System.Drawing.Size(212, 45);
            this.trb_fovship.TabIndex = 31;
            this.trb_fovship.Value = 50;
            this.trb_fovship.Scroll += new System.EventHandler(this.trb_fovship_Scroll);
            // 
            // trb_brightness
            // 
            this.trb_brightness.LargeChange = 10;
            this.trb_brightness.Location = new System.Drawing.Point(186, 543);
            this.trb_brightness.Maximum = 128;
            this.trb_brightness.Name = "trb_brightness";
            this.trb_brightness.Size = new System.Drawing.Size(212, 45);
            this.trb_brightness.TabIndex = 31;
            this.trb_brightness.Scroll += new System.EventHandler(this.trb_brightness_Scroll);
            // 
            // tb_fovfoot
            // 
            this.tb_fovfoot.Enabled = false;
            this.tb_fovfoot.Location = new System.Drawing.Point(97, 483);
            this.tb_fovfoot.Name = "tb_fovfoot";
            this.tb_fovfoot.Size = new System.Drawing.Size(58, 20);
            this.tb_fovfoot.TabIndex = 32;
            // 
            // tb_fovship
            // 
            this.tb_fovship.Enabled = false;
            this.tb_fovship.Location = new System.Drawing.Point(97, 511);
            this.tb_fovship.Name = "tb_fovship";
            this.tb_fovship.Size = new System.Drawing.Size(58, 20);
            this.tb_fovship.TabIndex = 33;
            // 
            // tb_brightness
            // 
            this.tb_brightness.Enabled = false;
            this.tb_brightness.Location = new System.Drawing.Point(97, 539);
            this.tb_brightness.Name = "tb_brightness";
            this.tb_brightness.Size = new System.Drawing.Size(58, 20);
            this.tb_brightness.TabIndex = 34;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(298, 578);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 33);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save Settings";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_screeninfo
            // 
            this.lbl_screeninfo.AutoSize = true;
            this.lbl_screeninfo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_screeninfo.Location = new System.Drawing.Point(29, 317);
            this.lbl_screeninfo.Name = "lbl_screeninfo";
            this.lbl_screeninfo.Size = new System.Drawing.Size(126, 13);
            this.lbl_screeninfo.TabIndex = 35;
            this.lbl_screeninfo.Text = "Actual screen resolution :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NMS_Saves_Manager.Properties.Resources.NMS_head;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(419, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // trb_reswidth
            // 
            this.trb_reswidth.Location = new System.Drawing.Point(258, 265);
            this.trb_reswidth.Maximum = 9999;
            this.trb_reswidth.Name = "trb_reswidth";
            this.trb_reswidth.Size = new System.Drawing.Size(104, 45);
            this.trb_reswidth.TabIndex = 36;
            this.trb_reswidth.Visible = false;
            // 
            // trb_resheight
            // 
            this.trb_resheight.Location = new System.Drawing.Point(258, 307);
            this.trb_resheight.Maximum = 9999;
            this.trb_resheight.Name = "trb_resheight";
            this.trb_resheight.Size = new System.Drawing.Size(104, 45);
            this.trb_resheight.TabIndex = 36;
            this.trb_resheight.UseWaitCursor = true;
            this.trb_resheight.Visible = false;
            // 
            // tb_reswidth
            // 
            this.tb_reswidth.Location = new System.Drawing.Point(122, 271);
            this.tb_reswidth.Name = "tb_reswidth";
            this.tb_reswidth.Size = new System.Drawing.Size(100, 20);
            this.tb_reswidth.TabIndex = 37;
            this.tb_reswidth.TextChanged += new System.EventHandler(this.tb_reswidth_TextChanged_1);
            // 
            // tb_resheight
            // 
            this.tb_resheight.Location = new System.Drawing.Point(122, 294);
            this.tb_resheight.Name = "tb_resheight";
            this.tb_resheight.Size = new System.Drawing.Size(100, 20);
            this.tb_resheight.TabIndex = 38;
            this.tb_resheight.TextChanged += new System.EventHandler(this.tb_resheight_TextChanged_1);
            // 
            // form_gamesettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 623);
            this.Controls.Add(this.tb_resheight);
            this.Controls.Add(this.tb_reswidth);
            this.Controls.Add(this.trb_resheight);
            this.Controls.Add(this.trb_reswidth);
            this.Controls.Add(this.lbl_screeninfo);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_brightness);
            this.Controls.Add(this.tb_fovship);
            this.Controls.Add(this.tb_fovfoot);
            this.Controls.Add(this.trb_brightness);
            this.Controls.Add(this.trb_fovship);
            this.Controls.Add(this.trb_fovfoot);
            this.Controls.Add(this.cb_aa);
            this.Controls.Add(this.cb_aniso);
            this.Controls.Add(this.cb_textures);
            this.Controls.Add(this.cb_reflections);
            this.Controls.Add(this.cb_shadows);
            this.Controls.Add(this.cb_generation);
            this.Controls.Add(this.cb_framerate);
            this.Controls.Add(this.cb_monitor);
            this.Controls.Add(this.chk_hud);
            this.Controls.Add(this.chk_screenres);
            this.Controls.Add(this.chk_gsync);
            this.Controls.Add(this.chk_vsync);
            this.Controls.Add(this.chk_borderless);
            this.Controls.Add(this.chk_Fullscreen);
            this.Controls.Add(this.lbl_framerate);
            this.Controls.Add(this.lbl_brightness);
            this.Controls.Add(this.lbl_fovship);
            this.Controls.Add(this.lbl_fovfoot);
            this.Controls.Add(this.lbl_aniso);
            this.Controls.Add(this.lbl_aa);
            this.Controls.Add(this.lbl_shadows);
            this.Controls.Add(this.lbl_textures);
            this.Controls.Add(this.lbl_generation);
            this.Controls.Add(this.lbl_monitor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_reflections);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_gamesettings";
            this.Text = "NMS:SM Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.trb_fovfoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_fovship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_reswidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_resheight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_reflections;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_monitor;
        private System.Windows.Forms.Label lbl_generation;
        private System.Windows.Forms.Label lbl_textures;
        private System.Windows.Forms.Label lbl_shadows;
        private System.Windows.Forms.Label lbl_aa;
        private System.Windows.Forms.Label lbl_aniso;
        private System.Windows.Forms.Label lbl_fovfoot;
        private System.Windows.Forms.Label lbl_fovship;
        private System.Windows.Forms.Label lbl_brightness;
        private System.Windows.Forms.Label lbl_framerate;
        private System.Windows.Forms.CheckBox chk_Fullscreen;
        private System.Windows.Forms.CheckBox chk_borderless;
        private System.Windows.Forms.CheckBox chk_vsync;
        private System.Windows.Forms.CheckBox chk_gsync;
        private System.Windows.Forms.CheckBox chk_screenres;
        private System.Windows.Forms.CheckBox chk_hud;
        private System.Windows.Forms.TextBox tb_reswidth;
        private System.Windows.Forms.TextBox tb_resheight;
        private System.Windows.Forms.ComboBox cb_monitor;
        private System.Windows.Forms.ComboBox cb_framerate;
        private System.Windows.Forms.ComboBox cb_generation;
        private System.Windows.Forms.ComboBox cb_reflections;
        private System.Windows.Forms.ComboBox cb_aniso;
        private System.Windows.Forms.ComboBox cb_shadows;
        private System.Windows.Forms.ComboBox cb_textures;
        private System.Windows.Forms.ComboBox cb_aa;
        private System.Windows.Forms.TrackBar trb_fovfoot;
        private System.Windows.Forms.TrackBar trb_fovship;
        private System.Windows.Forms.TrackBar trb_brightness;
        private System.Windows.Forms.TextBox tb_fovfoot;
        private System.Windows.Forms.TextBox tb_fovship;
        private System.Windows.Forms.TextBox tb_brightness;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_screeninfo;
        private System.Windows.Forms.TrackBar trb_reswidth;
        private System.Windows.Forms.TrackBar trb_resheight;
    }
}