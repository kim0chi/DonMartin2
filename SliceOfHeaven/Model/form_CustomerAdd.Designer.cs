namespace SliceOfHeaven.Model
{
    partial class form_CustomerAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_CustomerAdd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flp_Control = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Driver = new System.Windows.Forms.Label();
            this.cbox_Driver = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txtbox_Phone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flp_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 138);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Customer Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SliceOfHeaven.Properties.Resources.staffred100;
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::SliceOfHeaven.Properties.Resources.icons8_power_96;
            this.pictureBox2.Location = new System.Drawing.Point(346, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // flp_Control
            // 
            this.flp_Control.Controls.Add(this.lbl_Driver);
            this.flp_Control.Controls.Add(this.cbox_Driver);
            this.flp_Control.Controls.Add(this.label2);
            this.flp_Control.Controls.Add(this.lbl_Name);
            this.flp_Control.Controls.Add(this.txtbox_Name);
            this.flp_Control.Controls.Add(this.label6);
            this.flp_Control.Controls.Add(this.lbl_Phone);
            this.flp_Control.Controls.Add(this.txtbox_Phone);
            this.flp_Control.Controls.Add(this.button1);
            this.flp_Control.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_Control.Location = new System.Drawing.Point(28, 144);
            this.flp_Control.Name = "flp_Control";
            this.flp_Control.Padding = new System.Windows.Forms.Padding(10);
            this.flp_Control.Size = new System.Drawing.Size(353, 304);
            this.flp_Control.TabIndex = 1;
            // 
            // lbl_Driver
            // 
            this.lbl_Driver.AutoSize = true;
            this.lbl_Driver.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Driver.Location = new System.Drawing.Point(13, 10);
            this.lbl_Driver.Name = "lbl_Driver";
            this.lbl_Driver.Size = new System.Drawing.Size(53, 21);
            this.lbl_Driver.TabIndex = 5;
            this.lbl_Driver.Text = "Driver";
            // 
            // cbox_Driver
            // 
            this.cbox_Driver.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Driver.FormattingEnabled = true;
            this.cbox_Driver.Location = new System.Drawing.Point(13, 34);
            this.cbox_Driver.Name = "cbox_Driver";
            this.cbox_Driver.Size = new System.Drawing.Size(267, 29);
            this.cbox_Driver.TabIndex = 0;
            this.cbox_Driver.SelectedIndexChanged += new System.EventHandler(this.cbox_Driver_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(13, 87);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(55, 21);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "Name:";
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Name.Location = new System.Drawing.Point(13, 111);
            this.txtbox_Name.MaxLength = 25;
            this.txtbox_Name.Multiline = true;
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(267, 37);
            this.txtbox_Name.TabIndex = 1;
            this.txtbox_Name.TextChanged += new System.EventHandler(this.txtbox_Name_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(13, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(13, 171);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(57, 21);
            this.lbl_Phone.TabIndex = 5;
            this.lbl_Phone.Text = "Phone:";
            // 
            // txtbox_Phone
            // 
            this.txtbox_Phone.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Phone.Location = new System.Drawing.Point(13, 195);
            this.txtbox_Phone.MaxLength = 11;
            this.txtbox_Phone.Multiline = true;
            this.txtbox_Phone.Name = "txtbox_Phone";
            this.txtbox_Phone.Size = new System.Drawing.Size(267, 37);
            this.txtbox_Phone.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_CustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 460);
            this.Controls.Add(this.flp_Control);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_CustomerAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_CustomerAdd";
            this.Load += new System.EventHandler(this.form_CustomerAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flp_Control.ResumeLayout(false);
            this.flp_Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flp_Control;
        private System.Windows.Forms.Label lbl_Driver;
        private System.Windows.Forms.ComboBox cbox_Driver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txtbox_Phone;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}