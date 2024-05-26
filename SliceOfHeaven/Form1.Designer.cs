namespace SliceOfHeaven
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_Username = new System.Windows.Forms.TextBox();
            this.txtbox_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cyberButton3 = new ReaLTaiizor.Controls.CyberButton();
            this.cyberButton4 = new ReaLTaiizor.Controls.CyberButton();
            this.label4 = new System.Windows.Forms.Label();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(46)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 514);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-43, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            this.label2.Visible = false;
            // 
            // txtbox_Username
            // 
            this.txtbox_Username.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Username.Location = new System.Drawing.Point(370, 203);
            this.txtbox_Username.MaxLength = 20;
            this.txtbox_Username.Multiline = true;
            this.txtbox_Username.Name = "txtbox_Username";
            this.txtbox_Username.Size = new System.Drawing.Size(339, 32);
            this.txtbox_Username.TabIndex = 3;
            this.txtbox_Username.Visible = false;
            // 
            // txtbox_Password
            // 
            this.txtbox_Password.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Password.Location = new System.Drawing.Point(370, 300);
            this.txtbox_Password.MaxLength = 20;
            this.txtbox_Password.Multiline = true;
            this.txtbox_Password.Name = "txtbox_Password";
            this.txtbox_Password.PasswordChar = '*';
            this.txtbox_Password.Size = new System.Drawing.Size(339, 32);
            this.txtbox_Password.TabIndex = 5;
            this.txtbox_Password.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(607, 338);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cyberButton3
            // 
            this.cyberButton3.Alpha = 20;
            this.cyberButton3.BackColor = System.Drawing.Color.Transparent;
            this.cyberButton3.Background = true;
            this.cyberButton3.Background_WidthPen = 4F;
            this.cyberButton3.BackgroundPen = true;
            this.cyberButton3.ColorBackground = System.Drawing.SystemColors.Control;
            this.cyberButton3.ColorBackground_1 = System.Drawing.Color.RosyBrown;
            this.cyberButton3.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cyberButton3.ColorBackground_Pen = System.Drawing.Color.Maroon;
            this.cyberButton3.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton3.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton3.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton3.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberButton3.Effect_1 = true;
            this.cyberButton3.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton3.Effect_1_Transparency = 25;
            this.cyberButton3.Effect_2 = true;
            this.cyberButton3.Effect_2_ColorBackground = System.Drawing.Color.Silver;
            this.cyberButton3.Effect_2_Transparency = 20;
            this.cyberButton3.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberButton3.ForeColor = System.Drawing.Color.Maroon;
            this.cyberButton3.Lighting = false;
            this.cyberButton3.LinearGradient_Background = false;
            this.cyberButton3.LinearGradientPen = false;
            this.cyberButton3.Location = new System.Drawing.Point(370, 389);
            this.cyberButton3.Name = "cyberButton3";
            this.cyberButton3.PenWidth = 15;
            this.cyberButton3.Rounding = true;
            this.cyberButton3.RoundingInt = 70;
            this.cyberButton3.Size = new System.Drawing.Size(143, 47);
            this.cyberButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberButton3.TabIndex = 11;
            this.cyberButton3.Tag = "Cyber";
            this.cyberButton3.TextButton = "Back To User";
            this.cyberButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberButton3.Timer_Effect_1 = 5;
            this.cyberButton3.Timer_RGB = 300;
            this.cyberButton3.Click += new System.EventHandler(this.cyberButton3_Click);
            // 
            // cyberButton4
            // 
            this.cyberButton4.Alpha = 20;
            this.cyberButton4.BackColor = System.Drawing.Color.Transparent;
            this.cyberButton4.Background = true;
            this.cyberButton4.Background_WidthPen = 4F;
            this.cyberButton4.BackgroundPen = true;
            this.cyberButton4.ColorBackground = System.Drawing.SystemColors.Control;
            this.cyberButton4.ColorBackground_1 = System.Drawing.Color.RosyBrown;
            this.cyberButton4.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cyberButton4.ColorBackground_Pen = System.Drawing.Color.Maroon;
            this.cyberButton4.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton4.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton4.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton4.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberButton4.Effect_1 = true;
            this.cyberButton4.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton4.Effect_1_Transparency = 25;
            this.cyberButton4.Effect_2 = true;
            this.cyberButton4.Effect_2_ColorBackground = System.Drawing.Color.Silver;
            this.cyberButton4.Effect_2_Transparency = 20;
            this.cyberButton4.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberButton4.ForeColor = System.Drawing.Color.Maroon;
            this.cyberButton4.Lighting = false;
            this.cyberButton4.LinearGradient_Background = false;
            this.cyberButton4.LinearGradientPen = false;
            this.cyberButton4.Location = new System.Drawing.Point(601, 423);
            this.cyberButton4.Name = "cyberButton4";
            this.cyberButton4.PenWidth = 15;
            this.cyberButton4.Rounding = true;
            this.cyberButton4.RoundingInt = 70;
            this.cyberButton4.Size = new System.Drawing.Size(108, 37);
            this.cyberButton4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberButton4.TabIndex = 12;
            this.cyberButton4.Tag = "Cyber";
            this.cyberButton4.TextButton = "Sign Up!";
            this.cyberButton4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberButton4.Timer_Effect_1 = 5;
            this.cyberButton4.Timer_RGB = 300;
            this.cyberButton4.Visible = false;
            this.cyberButton4.Click += new System.EventHandler(this.cyberButton4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(586, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "No account yet?";
            this.label4.Visible = false;
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
            this.nightControlBox1.Location = new System.Drawing.Point(607, -1);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Admin Login";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 513);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nightControlBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cyberButton4);
            this.Controls.Add(this.cyberButton3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtbox_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_Username;
        private System.Windows.Forms.TextBox txtbox_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private ReaLTaiizor.Controls.CyberButton cyberButton3;
        private ReaLTaiizor.Controls.CyberButton cyberButton4;
        private System.Windows.Forms.Label label4;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

