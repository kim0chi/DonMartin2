namespace SliceOfHeaven.View
{
    partial class form_KitchenView
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
            this.panel_Orders = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel_Orders
            // 
            this.panel_Orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Orders.Location = new System.Drawing.Point(0, 0);
            this.panel_Orders.Name = "panel_Orders";
            this.panel_Orders.Size = new System.Drawing.Size(1272, 919);
            this.panel_Orders.TabIndex = 0;
            // 
            // form_KitchenView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1272, 919);
            this.Controls.Add(this.panel_Orders);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_KitchenView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_KitchenView";
            this.Load += new System.EventHandler(this.form_KitchenView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel_Orders;
    }
}