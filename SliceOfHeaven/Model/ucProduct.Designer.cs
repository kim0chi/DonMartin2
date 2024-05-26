namespace SliceOfHeaven.Model
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pbox_ProductPic = new System.Windows.Forms.PictureBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ProductPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Price);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Controls.Add(this.pbox_ProductPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 173);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(28, 100);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(94, 40);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Product Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Name.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // pbox_ProductPic
            // 
            this.pbox_ProductPic.Image = global::SliceOfHeaven.Properties.Resources.MenuPic;
            this.pbox_ProductPic.Location = new System.Drawing.Point(18, 8);
            this.pbox_ProductPic.Name = "pbox_ProductPic";
            this.pbox_ProductPic.Size = new System.Drawing.Size(112, 91);
            this.pbox_ProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_ProductPic.TabIndex = 0;
            this.pbox_ProductPic.TabStop = false;
            this.pbox_ProductPic.Click += new System.EventHandler(this.pbox_ProductPic_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(37, 140);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(78, 24);
            this.lbl_Price.TabIndex = 2;
            this.lbl_Price.Text = "Product Price";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(150, 180);
            this.MinimumSize = new System.Drawing.Size(150, 150);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(150, 173);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ProductPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbox_ProductPic;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Price;
    }
}
