namespace SliceOfHeaven.View
{
    partial class form_StaffView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_CategoryView = new System.Windows.Forms.DataGridView();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvdel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // txtbox_Search
            // 
            this.txtbox_Search.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Search.TextChanged += new System.EventHandler(this.txtbox_Search_TextChanged_2);
            // 
            // dgv_CategoryView
            // 
            this.dgv_CategoryView.AllowUserToAddRows = false;
            this.dgv_CategoryView.AllowUserToDeleteRows = false;
            this.dgv_CategoryView.AllowUserToResizeColumns = false;
            this.dgv_CategoryView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            this.dgv_CategoryView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_CategoryView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CategoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CategoryView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_CategoryView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_CategoryView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_CategoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_CategoryView.ColumnHeadersHeight = 40;
            this.dgv_CategoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_CategoryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvSno,
            this.dgvname,
            this.dgvPhone,
            this.dgvAddress,
            this.dgvRole,
            this.dgvedit,
            this.dgvdel});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CategoryView.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_CategoryView.EnableHeadersVisualStyles = false;
            this.dgv_CategoryView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_CategoryView.Location = new System.Drawing.Point(59, 192);
            this.dgv_CategoryView.Name = "dgv_CategoryView";
            this.dgv_CategoryView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CategoryView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_CategoryView.Size = new System.Drawing.Size(883, 427);
            this.dgv_CategoryView.TabIndex = 6;
            this.dgv_CategoryView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CategoryView_CellClick);
            // 
            // dgvid
            // 
            this.dgvid.FillWeight = 20F;
            this.dgvid.HeaderText = "ID";
            this.dgvid.MinimumWidth = 20;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvSno
            // 
            this.dgvSno.FillWeight = 50F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 50;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            // 
            // dgvname
            // 
            this.dgvname.FillWeight = 70F;
            this.dgvname.HeaderText = "Name";
            this.dgvname.MinimumWidth = 70;
            this.dgvname.Name = "dgvname";
            this.dgvname.ReadOnly = true;
            // 
            // dgvPhone
            // 
            this.dgvPhone.FillWeight = 50F;
            this.dgvPhone.HeaderText = "Phone";
            this.dgvPhone.MinimumWidth = 50;
            this.dgvPhone.Name = "dgvPhone";
            this.dgvPhone.ReadOnly = true;
            // 
            // dgvAddress
            // 
            this.dgvAddress.HeaderText = "Address";
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            // 
            // dgvRole
            // 
            this.dgvRole.FillWeight = 50F;
            this.dgvRole.HeaderText = "Role";
            this.dgvRole.MinimumWidth = 50;
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.ReadOnly = true;
            // 
            // dgvedit
            // 
            this.dgvedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvedit.FillWeight = 50F;
            this.dgvedit.HeaderText = "";
            this.dgvedit.Image = global::SliceOfHeaven.Properties.Resources.icons8_write_48;
            this.dgvedit.MinimumWidth = 50;
            this.dgvedit.Name = "dgvedit";
            this.dgvedit.ReadOnly = true;
            this.dgvedit.Width = 50;
            // 
            // dgvdel
            // 
            this.dgvdel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvdel.FillWeight = 50F;
            this.dgvdel.HeaderText = "";
            this.dgvdel.Image = global::SliceOfHeaven.Properties.Resources.icons8_trash_64;
            this.dgvdel.MinimumWidth = 50;
            this.dgvdel.Name = "dgvdel";
            this.dgvdel.ReadOnly = true;
            this.dgvdel.Width = 50;
            // 
            // form_StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 747);
            this.Controls.Add(this.dgv_CategoryView);
            this.Name = "form_StaffView";
            this.Text = "form_StaffView";
            this.Load += new System.EventHandler(this.form_StaffView_Load_1);
            this.Controls.SetChildIndex(this.btn_Add, 0);
            this.Controls.SetChildIndex(this.txtbox_Search, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.crownDockPanel1, 0);
            this.Controls.SetChildIndex(this.dgv_CategoryView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CategoryView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRole;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgvdel;
    }
}