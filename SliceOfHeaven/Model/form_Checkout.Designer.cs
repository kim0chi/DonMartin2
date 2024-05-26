namespace SliceOfHeaven.Model
{
    partial class form_Checkout
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
            this.txtbox_BillAmount = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtbox_Payment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_Change = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.Text = "Checkout";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SliceOfHeaven.Properties.Resources.icons8_bill_100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Size = new System.Drawing.Size(596, 118);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox2, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 332);
            this.panel2.Size = new System.Drawing.Size(596, 57);
            // 
            // btn_Close
            // 
            this.btn_Close.ColorBackground_Pen = System.Drawing.Color.Maroon;
            // 
            // btn_Save
            // 
            this.btn_Save.ColorBackground_Pen = System.Drawing.Color.Maroon;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txtbox_BillAmount
            // 
            this.txtbox_BillAmount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtbox_BillAmount.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_BillAmount.Location = new System.Drawing.Point(52, 181);
            this.txtbox_BillAmount.MaxLength = 10;
            this.txtbox_BillAmount.Multiline = true;
            this.txtbox_BillAmount.Name = "txtbox_BillAmount";
            this.txtbox_BillAmount.ReadOnly = true;
            this.txtbox_BillAmount.Size = new System.Drawing.Size(231, 32);
            this.txtbox_BillAmount.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(48, 157);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(100, 21);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Bill Amount:";
            // 
            // txtbox_Payment
            // 
            this.txtbox_Payment.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Payment.Location = new System.Drawing.Point(339, 181);
            this.txtbox_Payment.MaxLength = 10;
            this.txtbox_Payment.Multiline = true;
            this.txtbox_Payment.Name = "txtbox_Payment";
            this.txtbox_Payment.Size = new System.Drawing.Size(231, 32);
            this.txtbox_Payment.TabIndex = 8;
            this.txtbox_Payment.TextChanged += new System.EventHandler(this.txtbox_Payment_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(335, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Payment Received:";
            // 
            // txtbox_Change
            // 
            this.txtbox_Change.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbox_Change.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Change.Location = new System.Drawing.Point(52, 260);
            this.txtbox_Change.MaxLength = 10;
            this.txtbox_Change.Multiline = true;
            this.txtbox_Change.Name = "txtbox_Change";
            this.txtbox_Change.ReadOnly = true;
            this.txtbox_Change.Size = new System.Drawing.Size(231, 32);
            this.txtbox_Change.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Change:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::SliceOfHeaven.Properties.Resources.icons8_power_96;
            this.pictureBox2.Location = new System.Drawing.Point(516, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // form_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 389);
            this.Controls.Add(this.txtbox_Change);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_Payment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_BillAmount);
            this.Controls.Add(this.lbl_name);
            this.Name = "form_Checkout";
            this.Text = "form_Checkout";
            this.Load += new System.EventHandler(this.form_Checkout_Load);
            this.Controls.SetChildIndex(this.lbl_name, 0);
            this.Controls.SetChildIndex(this.txtbox_BillAmount, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtbox_Payment, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtbox_Change, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtbox_BillAmount;
        private System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.TextBox txtbox_Payment;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtbox_Change;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}