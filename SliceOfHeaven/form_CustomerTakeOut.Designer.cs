namespace SliceOfHeaven
{
    partial class form_CustomerTakeOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_CustomerTakeOut));
            this.btn_Kitchen = new ReaLTaiizor.Controls.CyberButton();
            this.dgv_CategoryView = new System.Windows.Forms.DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvproID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.panel_Category = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Product = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Kitchen
            // 
            this.btn_Kitchen.Alpha = 20;
            this.btn_Kitchen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Kitchen.BackColor = System.Drawing.Color.Transparent;
            this.btn_Kitchen.Background = true;
            this.btn_Kitchen.Background_WidthPen = 4F;
            this.btn_Kitchen.BackgroundPen = true;
            this.btn_Kitchen.ColorBackground = System.Drawing.Color.SandyBrown;
            this.btn_Kitchen.ColorBackground_1 = System.Drawing.Color.Transparent;
            this.btn_Kitchen.ColorBackground_2 = System.Drawing.Color.Maroon;
            this.btn_Kitchen.ColorBackground_Pen = System.Drawing.Color.Maroon;
            this.btn_Kitchen.ColorLighting = System.Drawing.Color.LightCoral;
            this.btn_Kitchen.ColorPen_1 = System.Drawing.Color.Maroon;
            this.btn_Kitchen.ColorPen_2 = System.Drawing.Color.Maroon;
            this.btn_Kitchen.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btn_Kitchen.Effect_1 = true;
            this.btn_Kitchen.Effect_1_ColorBackground = System.Drawing.Color.LightCoral;
            this.btn_Kitchen.Effect_1_Transparency = 25;
            this.btn_Kitchen.Effect_2 = true;
            this.btn_Kitchen.Effect_2_ColorBackground = System.Drawing.Color.Maroon;
            this.btn_Kitchen.Effect_2_Transparency = 20;
            this.btn_Kitchen.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Kitchen.ForeColor = System.Drawing.Color.White;
            this.btn_Kitchen.Lighting = false;
            this.btn_Kitchen.LinearGradient_Background = false;
            this.btn_Kitchen.LinearGradientPen = false;
            this.btn_Kitchen.Location = new System.Drawing.Point(822, 8);
            this.btn_Kitchen.Name = "btn_Kitchen";
            this.btn_Kitchen.PenWidth = 15;
            this.btn_Kitchen.Rounding = true;
            this.btn_Kitchen.RoundingInt = 70;
            this.btn_Kitchen.Size = new System.Drawing.Size(171, 47);
            this.btn_Kitchen.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_Kitchen.TabIndex = 33;
            this.btn_Kitchen.Tag = "Cyber";
            this.btn_Kitchen.TextButton = "Confirm Order!";
            this.btn_Kitchen.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_Kitchen.Timer_Effect_1 = 5;
            this.btn_Kitchen.Timer_RGB = 300;
            this.btn_Kitchen.Click += new System.EventHandler(this.btn_Kitchen_Click_1);
            // 
            // dgv_CategoryView
            // 
            this.dgv_CategoryView.AllowUserToAddRows = false;
            this.dgv_CategoryView.AllowUserToDeleteRows = false;
            this.dgv_CategoryView.AllowUserToResizeColumns = false;
            this.dgv_CategoryView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            this.dgv_CategoryView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CategoryView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv_CategoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CategoryView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_CategoryView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_CategoryView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_CategoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CategoryView.ColumnHeadersHeight = 40;
            this.dgv_CategoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_CategoryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvproID,
            this.dgvname,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CategoryView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_CategoryView.EnableHeadersVisualStyles = false;
            this.dgv_CategoryView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_CategoryView.Location = new System.Drawing.Point(560, 64);
            this.dgv_CategoryView.Name = "dgv_CategoryView";
            this.dgv_CategoryView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CategoryView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_CategoryView.Size = new System.Drawing.Size(433, 542);
            this.dgv_CategoryView.TabIndex = 30;
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 40F;
            this.dgvSno.HeaderText = "S#";
            this.dgvSno.MinimumWidth = 40;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 40;
            // 
            // dgvid
            // 
            this.dgvid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvid.FillWeight = 5F;
            this.dgvid.HeaderText = "id";
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            this.dgvid.Width = 5;
            // 
            // dgvproID
            // 
            this.dgvproID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvproID.FillWeight = 50F;
            this.dgvproID.HeaderText = "ProductID";
            this.dgvproID.MinimumWidth = 50;
            this.dgvproID.Name = "dgvproID";
            this.dgvproID.ReadOnly = true;
            this.dgvproID.Visible = false;
            this.dgvproID.Width = 50;
            // 
            // dgvname
            // 
            this.dgvname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvname.FillWeight = 120F;
            this.dgvname.HeaderText = "Name";
            this.dgvname.MinimumWidth = 120;
            this.dgvname.Name = "dgvname";
            this.dgvname.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 50F;
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.MinimumWidth = 50;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 50;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.FillWeight = 50F;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 50;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 70;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.FillWeight = 50F;
            this.dgvAmount.HeaderText = "Amount(₱)";
            this.dgvAmount.MinimumWidth = 50;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Total.Location = new System.Drawing.Point(669, 18);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(50, 25);
            this.lbl_Total.TabIndex = 32;
            this.lbl_Total.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(555, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Total (₱):";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(12, 8);
            this.txt_Name.MaxLength = 20;
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(147, 35);
            this.txt_Name.TabIndex = 29;
            this.txt_Name.Text = "Name:";
            // 
            // panel_Category
            // 
            this.panel_Category.Location = new System.Drawing.Point(13, 63);
            this.panel_Category.Name = "panel_Category";
            this.panel_Category.Size = new System.Drawing.Size(146, 543);
            this.panel_Category.TabIndex = 27;
            // 
            // panel_Product
            // 
            this.panel_Product.Location = new System.Drawing.Point(165, 63);
            this.panel_Product.Name = "panel_Product";
            this.panel_Product.Size = new System.Drawing.Size(389, 542);
            this.panel_Product.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(318, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Pick Up";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(165, 8);
            this.textBox1.MaxLength = 20;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 35);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "Phone:";
            // 
            // form_CustomerTakeOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 618);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Kitchen);
            this.Controls.Add(this.dgv_CategoryView);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.panel_Category);
            this.Controls.Add(this.panel_Product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_CustomerTakeOut";
            this.Text = "form_CustomerTakeOut";
            this.Load += new System.EventHandler(this.form_CustomerTakeOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton btn_Kitchen;
        private System.Windows.Forms.DataGridView dgv_CategoryView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvproID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.FlowLayoutPanel panel_Category;
        private System.Windows.Forms.FlowLayoutPanel panel_Product;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
    }
}