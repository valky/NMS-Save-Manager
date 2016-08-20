namespace NMS_Saves_Manager.Forms
{
    partial class MainForm
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
            this.TLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.PBX_Head = new System.Windows.Forms.PictureBox();
            this.PNL_Main = new System.Windows.Forms.Panel();
            this.TLP_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Head)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP_Main
            // 
            this.TLP_Main.AutoSize = true;
            this.TLP_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_Main.ColumnCount = 1;
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Main.Controls.Add(this.PBX_Head, 0, 0);
            this.TLP_Main.Controls.Add(this.PNL_Main, 0, 1);
            this.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Main.Location = new System.Drawing.Point(0, 0);
            this.TLP_Main.Margin = new System.Windows.Forms.Padding(0);
            this.TLP_Main.Name = "TLP_Main";
            this.TLP_Main.RowCount = 2;
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Main.Size = new System.Drawing.Size(420, 601);
            this.TLP_Main.TabIndex = 0;
            // 
            // PBX_Head
            // 
            this.PBX_Head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBX_Head.Image = global::NMS_Saves_Manager.Properties.Resources.NMS_head;
            this.PBX_Head.Location = new System.Drawing.Point(0, 0);
            this.PBX_Head.Margin = new System.Windows.Forms.Padding(0);
            this.PBX_Head.Name = "PBX_Head";
            this.PBX_Head.Size = new System.Drawing.Size(420, 185);
            this.PBX_Head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBX_Head.TabIndex = 0;
            this.PBX_Head.TabStop = false;
            // 
            // PNL_Main
            // 
            this.PNL_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Main.Location = new System.Drawing.Point(3, 188);
            this.PNL_Main.Name = "PNL_Main";
            this.PNL_Main.Size = new System.Drawing.Size(414, 410);
            this.PNL_Main.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 601);
            this.Controls.Add(this.TLP_Main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NMS Saves Manager";
            this.TLP_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Head)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_Main;
        private System.Windows.Forms.PictureBox PBX_Head;
        private System.Windows.Forms.Panel PNL_Main;
    }
}

