namespace SliceOfHeaven.Model
{
    partial class form_StaffAdd
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
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtbox_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_Role = new ReaLTaiizor.Controls.PoisonComboBox();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.Text = "Staff Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SliceOfHeaven.Properties.Resources.staffred100;
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(587, 118);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 329);
            this.panel2.Size = new System.Drawing.Size(587, 58);
            // 
            // btn_Close
            // 
            this.btn_Close.ColorBackground_Pen = System.Drawing.Color.Maroon;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click_1);
            // 
            // btn_Save
            // 
            this.btn_Save.ColorBackground_Pen = System.Drawing.Color.Maroon;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click_1);
            // 
            // txtbox_name
            // 
            this.txtbox_name.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_name.Location = new System.Drawing.Point(44, 175);
            this.txtbox_name.MaxLength = 25;
            this.txtbox_name.Multiline = true;
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(231, 32);
            this.txtbox_name.TabIndex = 8;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(40, 151);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(59, 21);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name:";
            // 
            // txtbox_Phone
            // 
            this.txtbox_Phone.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Phone.Location = new System.Drawing.Point(331, 175);
            this.txtbox_Phone.MaxLength = 11;
            this.txtbox_Phone.Multiline = true;
            this.txtbox_Phone.Name = "txtbox_Phone";
            this.txtbox_Phone.Size = new System.Drawing.Size(231, 32);
            this.txtbox_Phone.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(327, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Role:";
            // 
            // cbox_Role
            // 
            this.cbox_Role.FormattingEnabled = true;
            this.cbox_Role.ItemHeight = 23;
            this.cbox_Role.Items.AddRange(new object[] {
            "Cashier",
            "Waiter",
            "Cleaning",
            "Manager",
            "Driver",
            "Other"});
            this.cbox_Role.Location = new System.Drawing.Point(44, 258);
            this.cbox_Role.Name = "cbox_Role";
            this.cbox_Role.Size = new System.Drawing.Size(228, 29);
            this.cbox_Role.TabIndex = 12;
            this.cbox_Role.UseSelectable = true;
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Address.Location = new System.Drawing.Point(331, 258);
            this.txtbox_Address.MaxLength = 30;
            this.txtbox_Address.Multiline = true;
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(231, 32);
            this.txtbox_Address.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(327, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Address";
            // 
            // form_StaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 387);
            this.Controls.Add(this.txtbox_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox_Role);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "form_StaffAdd";
            this.Text = "form_StaffAdd";
            this.Controls.SetChildIndex(this.lbl_name, 0);
            this.Controls.SetChildIndex(this.txtbox_name, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtbox_Phone, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbox_Role, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtbox_Address, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtbox_name;
        public System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.TextBox txtbox_Phone;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public ReaLTaiizor.Controls.PoisonComboBox cbox_Role;
        public System.Windows.Forms.TextBox txtbox_Address;
        public System.Windows.Forms.Label label4;
    }
}