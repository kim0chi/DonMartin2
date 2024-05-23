namespace SliceOfHeaven
{
    partial class form_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Admin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new ReaLTaiizor.Controls.CyberButton();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_share = new System.Windows.Forms.Button();
            this.btn_customize = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Center = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.nightControlBox1);
            this.panel2.Controls.Add(this.lbl_User);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(230, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 43);
            this.panel2.TabIndex = 6;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(815, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 0;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Yu Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(70, 13);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(53, 19);
            this.lbl_User.TabIndex = 5;
            this.lbl_User.Text = "Admin!";
            this.lbl_User.Click += new System.EventHandler(this.lbl_User_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_account);
            this.panel1.Controls.Add(this.btn_share);
            this.panel1.Controls.Add(this.btn_customize);
            this.panel1.Controls.Add(this.btn_products);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 790);
            this.panel1.TabIndex = 5;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Alpha = 20;
            this.btn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.Background = true;
            this.btn_Logout.Background_WidthPen = 4F;
            this.btn_Logout.BackgroundPen = true;
            this.btn_Logout.ColorBackground = System.Drawing.Color.Transparent;
            this.btn_Logout.ColorBackground_1 = System.Drawing.Color.RosyBrown;
            this.btn_Logout.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Logout.ColorBackground_Pen = System.Drawing.Color.Maroon;
            this.btn_Logout.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_Logout.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_Logout.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btn_Logout.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btn_Logout.Effect_1 = true;
            this.btn_Logout.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_Logout.Effect_1_Transparency = 25;
            this.btn_Logout.Effect_2 = true;
            this.btn_Logout.Effect_2_ColorBackground = System.Drawing.Color.Silver;
            this.btn_Logout.Effect_2_Transparency = 20;
            this.btn_Logout.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_Logout.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Logout.Lighting = false;
            this.btn_Logout.LinearGradient_Background = false;
            this.btn_Logout.LinearGradientPen = false;
            this.btn_Logout.Location = new System.Drawing.Point(12, 618);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.PenWidth = 15;
            this.btn_Logout.Rounding = true;
            this.btn_Logout.RoundingInt = 70;
            this.btn_Logout.Size = new System.Drawing.Size(82, 27);
            this.btn_Logout.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_Logout.TabIndex = 23;
            this.btn_Logout.Tag = "Cyber";
            this.btn_Logout.TextButton = "Logout";
            this.btn_Logout.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_Logout.Timer_Effect_1 = 5;
            this.btn_Logout.Timer_RGB = 300;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_account
            // 
            this.btn_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_account.FlatAppearance.BorderSize = 0;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_account.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_account.Image = ((System.Drawing.Image)(resources.GetObject("btn_account.Image")));
            this.btn_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_account.Location = new System.Drawing.Point(40, 397);
            this.btn_account.Margin = new System.Windows.Forms.Padding(0);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(190, 45);
            this.btn_account.TabIndex = 9;
            this.btn_account.Text = "          Account";
            this.btn_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_account.UseVisualStyleBackColor = true;
            // 
            // btn_share
            // 
            this.btn_share.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_share.FlatAppearance.BorderSize = 0;
            this.btn_share.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_share.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_share.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_share.Image = ((System.Drawing.Image)(resources.GetObject("btn_share.Image")));
            this.btn_share.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_share.Location = new System.Drawing.Point(39, 346);
            this.btn_share.Margin = new System.Windows.Forms.Padding(0);
            this.btn_share.Name = "btn_share";
            this.btn_share.Size = new System.Drawing.Size(190, 45);
            this.btn_share.TabIndex = 8;
            this.btn_share.Text = "          Staff";
            this.btn_share.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_share.UseVisualStyleBackColor = true;
            // 
            // btn_customize
            // 
            this.btn_customize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_customize.FlatAppearance.BorderSize = 0;
            this.btn_customize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customize.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_customize.Image = ((System.Drawing.Image)(resources.GetObject("btn_customize.Image")));
            this.btn_customize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customize.Location = new System.Drawing.Point(40, 293);
            this.btn_customize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_customize.Name = "btn_customize";
            this.btn_customize.Size = new System.Drawing.Size(190, 45);
            this.btn_customize.TabIndex = 7;
            this.btn_customize.Text = "          Kitchen";
            this.btn_customize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customize.UseVisualStyleBackColor = true;
            // 
            // btn_products
            // 
            this.btn_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_products.FlatAppearance.BorderSize = 0;
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_products.Image = ((System.Drawing.Image)(resources.GetObject("btn_products.Image")));
            this.btn_products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products.Location = new System.Drawing.Point(40, 242);
            this.btn_products.Margin = new System.Windows.Forms.Padding(0);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(190, 45);
            this.btn_products.TabIndex = 6;
            this.btn_products.Text = "          Products";
            this.btn_products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products.UseVisualStyleBackColor = true;
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(40, 190);
            this.btn_home.Margin = new System.Windows.Forms.Padding(0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(190, 45);
            this.btn_home.TabIndex = 4;
            this.btn_home.Text = "          Categories";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 128);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Center
            // 
            this.panel_Center.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Center.AutoScroll = true;
            this.panel_Center.AutoSize = true;
            this.panel_Center.Location = new System.Drawing.Point(230, 43);
            this.panel_Center.Name = "panel_Center";
            this.panel_Center.Size = new System.Drawing.Size(954, 747);
            this.panel_Center.TabIndex = 7;
            // 
            // form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 790);
            this.Controls.Add(this.panel_Center);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Admin";
            this.Load += new System.EventHandler(this.form_Admin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Button btn_share;
        private System.Windows.Forms.Button btn_customize;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Center;
        private ReaLTaiizor.Controls.CyberButton btn_Logout;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}