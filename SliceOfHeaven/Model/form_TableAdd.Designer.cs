namespace SliceOfHeaven.Model
{
    partial class form_TableAdd
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.Text = "Table Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SliceOfHeaven.Properties.Resources.download;
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(346, 118);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 231);
            this.panel2.Size = new System.Drawing.Size(346, 58);
            // 
            // btn_Close
            // 
            this.btn_Close.ColorBackground_Pen = System.Drawing.Color.Maroon;
            // 
            // btn_Save
            // 
            this.btn_Save.ColorBackground_Pen = System.Drawing.Color.Maroon;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click_2);
            // 
            // txtbox_name
            // 
            this.txtbox_name.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_name.Location = new System.Drawing.Point(52, 152);
            this.txtbox_name.Multiline = true;
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(231, 32);
            this.txtbox_name.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(48, 128);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(59, 21);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name:";
            // 
            // form_TableAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 289);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "form_TableAdd";
            this.Text = "form_TableAdd";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lbl_name, 0);
            this.Controls.SetChildIndex(this.txtbox_name, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label lbl_name;
    }
}