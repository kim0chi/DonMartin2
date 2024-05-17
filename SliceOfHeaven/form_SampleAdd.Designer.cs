namespace SliceOfHeaven
{
    partial class form_SampleAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_SampleAdd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_header = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new ReaLTaiizor.Controls.CyberButton();
            this.btn_save = new ReaLTaiizor.Controls.CyberButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lbl_header);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 121);
            this.panel1.TabIndex = 0;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.Color.Maroon;
            this.lbl_header.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_header.Location = new System.Drawing.Point(156, 49);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(79, 25);
            this.lbl_header.TabIndex = 2;
            this.lbl_header.Text = "Header";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 103);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 83);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_close
            // 
            this.btn_close.Alpha = 20;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Background = true;
            this.btn_close.Background_WidthPen = 4F;
            this.btn_close.BackgroundPen = true;
            this.btn_close.ColorBackground = System.Drawing.Color.Linen;
            this.btn_close.ColorBackground_1 = System.Drawing.Color.RosyBrown;
            this.btn_close.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.ColorBackground_Pen = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_close.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_close.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_close.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btn_close.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btn_close.Effect_1 = true;
            this.btn_close.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_close.Effect_1_Transparency = 25;
            this.btn_close.Effect_2 = true;
            this.btn_close.Effect_2_ColorBackground = System.Drawing.Color.Silver;
            this.btn_close.Effect_2_Transparency = 20;
            this.btn_close.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_close.ForeColor = System.Drawing.Color.Maroon;
            this.btn_close.Lighting = false;
            this.btn_close.LinearGradient_Background = false;
            this.btn_close.LinearGradientPen = false;
            this.btn_close.Location = new System.Drawing.Point(161, 22);
            this.btn_close.Name = "btn_close";
            this.btn_close.PenWidth = 15;
            this.btn_close.Rounding = true;
            this.btn_close.RoundingInt = 70;
            this.btn_close.Size = new System.Drawing.Size(108, 37);
            this.btn_close.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_close.TabIndex = 25;
            this.btn_close.Tag = "Cyber";
            this.btn_close.TextButton = "Close";
            this.btn_close.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_close.Timer_Effect_1 = 5;
            this.btn_close.Timer_RGB = 300;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // btn_save
            // 
            this.btn_save.Alpha = 20;
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.Background = true;
            this.btn_save.Background_WidthPen = 4F;
            this.btn_save.BackgroundPen = true;
            this.btn_save.ColorBackground = System.Drawing.Color.Linen;
            this.btn_save.ColorBackground_1 = System.Drawing.Color.RosyBrown;
            this.btn_save.ColorBackground_2 = System.Drawing.Color.Linen;
            this.btn_save.ColorBackground_Pen = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_save.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_save.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btn_save.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btn_save.Effect_1 = true;
            this.btn_save.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_save.Effect_1_Transparency = 25;
            this.btn_save.Effect_2 = true;
            this.btn_save.Effect_2_ColorBackground = System.Drawing.Color.SpringGreen;
            this.btn_save.Effect_2_Transparency = 20;
            this.btn_save.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_save.ForeColor = System.Drawing.Color.Maroon;
            this.btn_save.Lighting = false;
            this.btn_save.LinearGradient_Background = false;
            this.btn_save.LinearGradientPen = false;
            this.btn_save.Location = new System.Drawing.Point(32, 22);
            this.btn_save.Name = "btn_save";
            this.btn_save.PenWidth = 15;
            this.btn_save.Rounding = true;
            this.btn_save.RoundingInt = 70;
            this.btn_save.Size = new System.Drawing.Size(108, 37);
            this.btn_save.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_save.TabIndex = 24;
            this.btn_save.Tag = "Cyber";
            this.btn_save.TextButton = "Save";
            this.btn_save.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_save.Timer_Effect_1 = 5;
            this.btn_save.Timer_RGB = 300;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // form_SampleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_SampleAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_SampleAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public ReaLTaiizor.Controls.CyberButton btn_close;
        public ReaLTaiizor.Controls.CyberButton btn_save;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_header;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel2;
    }
}