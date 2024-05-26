namespace SliceOfHeaven.Model
{
    partial class QuantityInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuantityInputForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Increment = new System.Windows.Forms.Button();
            this.btn_Decrement = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.btn_OK = new ReaLTaiizor.Controls.CyberButton();
            this.cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 96);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_Increment
            // 
            this.btn_Increment.BackColor = System.Drawing.Color.Transparent;
            this.btn_Increment.FlatAppearance.BorderSize = 0;
            this.btn_Increment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Increment.Image = global::SliceOfHeaven.Properties.Resources.icons8_plus_100;
            this.btn_Increment.Location = new System.Drawing.Point(219, 121);
            this.btn_Increment.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Increment.Name = "btn_Increment";
            this.btn_Increment.Size = new System.Drawing.Size(65, 51);
            this.btn_Increment.TabIndex = 18;
            this.btn_Increment.UseVisualStyleBackColor = false;
            // 
            // btn_Decrement
            // 
            this.btn_Decrement.FlatAppearance.BorderSize = 0;
            this.btn_Decrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Decrement.Image = global::SliceOfHeaven.Properties.Resources.icons8_minus_100;
            this.btn_Decrement.Location = new System.Drawing.Point(24, 121);
            this.btn_Decrement.Name = "btn_Decrement";
            this.btn_Decrement.Size = new System.Drawing.Size(65, 51);
            this.btn_Decrement.TabIndex = 17;
            this.btn_Decrement.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SliceOfHeaven.Properties.Resources.icons8_quantity_100;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(100, 121);
            this.txt_Quantity.Multiline = true;
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(107, 51);
            this.txt_Quantity.TabIndex = 19;
            this.txt_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_OK
            // 
            this.btn_OK.Alpha = 20;
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OK.BackColor = System.Drawing.Color.Transparent;
            this.btn_OK.Background = true;
            this.btn_OK.Background_WidthPen = 4F;
            this.btn_OK.BackgroundPen = true;
            this.btn_OK.ColorBackground = System.Drawing.Color.Maroon;
            this.btn_OK.ColorBackground_1 = System.Drawing.Color.Transparent;
            this.btn_OK.ColorBackground_2 = System.Drawing.Color.Maroon;
            this.btn_OK.ColorBackground_Pen = System.Drawing.Color.Maroon;
            this.btn_OK.ColorLighting = System.Drawing.Color.LightCoral;
            this.btn_OK.ColorPen_1 = System.Drawing.Color.Maroon;
            this.btn_OK.ColorPen_2 = System.Drawing.Color.Maroon;
            this.btn_OK.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btn_OK.Effect_1 = true;
            this.btn_OK.Effect_1_ColorBackground = System.Drawing.Color.LightCoral;
            this.btn_OK.Effect_1_Transparency = 25;
            this.btn_OK.Effect_2 = true;
            this.btn_OK.Effect_2_ColorBackground = System.Drawing.Color.Maroon;
            this.btn_OK.Effect_2_Transparency = 20;
            this.btn_OK.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Lighting = false;
            this.btn_OK.LinearGradient_Background = false;
            this.btn_OK.LinearGradientPen = false;
            this.btn_OK.Location = new System.Drawing.Point(41, 198);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.PenWidth = 15;
            this.btn_OK.Rounding = true;
            this.btn_OK.RoundingInt = 70;
            this.btn_OK.Size = new System.Drawing.Size(100, 32);
            this.btn_OK.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_OK.TabIndex = 20;
            this.btn_OK.Tag = "Cyber";
            this.btn_OK.TextButton = "Confirm";
            this.btn_OK.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_OK.Timer_Effect_1 = 5;
            this.btn_OK.Timer_RGB = 300;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click_1);
            // 
            // cyberButton1
            // 
            this.cyberButton1.Alpha = 20;
            this.cyberButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cyberButton1.BackColor = System.Drawing.Color.Transparent;
            this.cyberButton1.Background = true;
            this.cyberButton1.Background_WidthPen = 4F;
            this.cyberButton1.BackgroundPen = true;
            this.cyberButton1.ColorBackground = System.Drawing.Color.Maroon;
            this.cyberButton1.ColorBackground_1 = System.Drawing.Color.Transparent;
            this.cyberButton1.ColorBackground_2 = System.Drawing.Color.Maroon;
            this.cyberButton1.ColorBackground_Pen = System.Drawing.Color.Maroon;
            this.cyberButton1.ColorLighting = System.Drawing.Color.LightCoral;
            this.cyberButton1.ColorPen_1 = System.Drawing.Color.Maroon;
            this.cyberButton1.ColorPen_2 = System.Drawing.Color.Maroon;
            this.cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberButton1.Effect_1 = true;
            this.cyberButton1.Effect_1_ColorBackground = System.Drawing.Color.LightCoral;
            this.cyberButton1.Effect_1_Transparency = 25;
            this.cyberButton1.Effect_2 = true;
            this.cyberButton1.Effect_2_ColorBackground = System.Drawing.Color.Maroon;
            this.cyberButton1.Effect_2_Transparency = 20;
            this.cyberButton1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cyberButton1.ForeColor = System.Drawing.Color.White;
            this.cyberButton1.Lighting = false;
            this.cyberButton1.LinearGradient_Background = false;
            this.cyberButton1.LinearGradientPen = false;
            this.cyberButton1.Location = new System.Drawing.Point(147, 198);
            this.cyberButton1.Name = "cyberButton1";
            this.cyberButton1.PenWidth = 15;
            this.cyberButton1.Rounding = true;
            this.cyberButton1.RoundingInt = 70;
            this.cyberButton1.Size = new System.Drawing.Size(100, 32);
            this.cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberButton1.TabIndex = 21;
            this.cyberButton1.Tag = "Cyber";
            this.cyberButton1.TextButton = "Cancel";
            this.cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberButton1.Timer_Effect_1 = 5;
            this.cyberButton1.Timer_RGB = 300;
            this.cyberButton1.Click += new System.EventHandler(this.cyberButton1_Click);
            // 
            // QuantityInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 242);
            this.Controls.Add(this.cyberButton1);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.btn_Increment);
            this.Controls.Add(this.btn_Decrement);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuantityInputForm";
            this.Text = "QuantityInputForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Decrement;
        private System.Windows.Forms.Button btn_Increment;
        private System.Windows.Forms.TextBox txt_Quantity;
        private ReaLTaiizor.Controls.CyberButton btn_OK;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
    }
}