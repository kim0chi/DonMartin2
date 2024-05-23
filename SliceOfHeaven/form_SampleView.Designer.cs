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
            this.btn_Add = new System.Windows.Forms.PictureBox();
            this.txtbox_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crownDockPanel1 = new ReaLTaiizor.Docking.Crown.CrownDockPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.Location = new System.Drawing.Point(59, 83);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(88, 76);
            this.btn_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Add.TabIndex = 0;
            this.btn_Add.TabStop = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txtbox_Search
            // 
            this.txtbox_Search.Font = new System.Drawing.Font("Yu Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Search.Location = new System.Drawing.Point(639, 116);
            this.txtbox_Search.Multiline = true;
            this.txtbox_Search.Name = "txtbox_Search";
            this.txtbox_Search.Size = new System.Drawing.Size(303, 43);
            this.txtbox_Search.TabIndex = 1;
            this.txtbox_Search.TextChanged += new System.EventHandler(this.txtbox_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(636, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "        Search";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(30, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Header Text";
            // 
            // crownDockPanel1
            // 
            this.crownDockPanel1.BackColor = System.Drawing.Color.Maroon;
            this.crownDockPanel1.ForeColor = System.Drawing.Color.Maroon;
            this.crownDockPanel1.Location = new System.Drawing.Point(59, 165);
            this.crownDockPanel1.Name = "crownDockPanel1";
            this.crownDockPanel1.Size = new System.Drawing.Size(887, 10);
            this.crownDockPanel1.TabIndex = 4;
            // 
            // form_SampleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 747);
            this.Controls.Add(this.crownDockPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_Search);
            this.Controls.Add(this.btn_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_SampleView";
            this.Text = "form_SampleView";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox btn_Add;
        public System.Windows.Forms.TextBox txtbox_Search;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public ReaLTaiizor.Docking.Crown.CrownDockPanel crownDockPanel1;
    }
}