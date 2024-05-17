namespace SliceOfHeaven
{
    partial class form_SampleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_SampleView));
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbox_image = new System.Windows.Forms.PictureBox();
            this.btn_save = new ReaLTaiizor.Controls.CyberButton();
            this.label2 = new System.Windows.Forms.Label();
            this.crownSeparator1 = new ReaLTaiizor.Controls.CrownSeparator();
            this.lostSeparator1 = new ReaLTaiizor.Controls.LostSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_search
            // 
            this.txtbox_search.Location = new System.Drawing.Point(612, 100);
            this.txtbox_search.Multiline = true;
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(283, 40);
            this.txtbox_search.TabIndex = 0;
            this.txtbox_search.TextChanged += new System.EventHandler(this.txtbox_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(609, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "       Search";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbox_image
            // 
            this.pbox_image.Image = ((System.Drawing.Image)(resources.GetObject("pbox_image.Image")));
            this.pbox_image.Location = new System.Drawing.Point(78, 54);
            this.pbox_image.Name = "pbox_image";
            this.pbox_image.Size = new System.Drawing.Size(83, 74);
            this.pbox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_image.TabIndex = 2;
            this.pbox_image.TabStop = false;
            this.pbox_image.Click += new System.EventHandler(this.pbox_image_Click);
            // 
            // btn_save
            // 
            this.btn_save.Alpha = 20;
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.Background = true;
            this.btn_save.Background_WidthPen = 4F;
            this.btn_save.BackgroundPen = true;
            this.btn_save.ColorBackground = System.Drawing.SystemColors.Control;
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
            this.btn_save.Font = new System.Drawing.Font("Yu Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.Lighting = false;
            this.btn_save.LinearGradient_Background = false;
            this.btn_save.LinearGradientPen = false;
            this.btn_save.Location = new System.Drawing.Point(78, 134);
            this.btn_save.Name = "btn_save";
            this.btn_save.PenWidth = 15;
            this.btn_save.Rounding = true;
            this.btn_save.RoundingInt = 70;
            this.btn_save.Size = new System.Drawing.Size(71, 30);
            this.btn_save.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_save.TabIndex = 25;
            this.btn_save.Tag = "Cyber";
            this.btn_save.TextButton = "Upload";
            this.btn_save.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_save.Timer_Effect_1 = 5;
            this.btn_save.Timer_RGB = 300;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Header Text";
            // 
            // crownSeparator1
            // 
            this.crownSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.crownSeparator1.Location = new System.Drawing.Point(0, 0);
            this.crownSeparator1.Name = "crownSeparator1";
            this.crownSeparator1.Size = new System.Drawing.Size(933, 2);
            this.crownSeparator1.TabIndex = 27;
            this.crownSeparator1.Text = "crownSeparator1";
            // 
            // lostSeparator1
            // 
            this.lostSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lostSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lostSeparator1.Horizontal = false;
            this.lostSeparator1.Location = new System.Drawing.Point(37, 180);
            this.lostSeparator1.Name = "lostSeparator1";
            this.lostSeparator1.Size = new System.Drawing.Size(854, 10);
            this.lostSeparator1.TabIndex = 28;
            this.lostSeparator1.Text = "lostSeparator1";
            // 
            // form_SampleView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.lostSeparator1);
            this.Controls.Add(this.crownSeparator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pbox_image);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_search);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_SampleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_SampleView";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ReaLTaiizor.Controls.CyberButton btn_save;
        private ReaLTaiizor.Controls.CrownSeparator crownSeparator1;
        private ReaLTaiizor.Controls.LostSeparator lostSeparator1;
        public System.Windows.Forms.TextBox txtbox_search;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pbox_image;
    }
}