using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliceOfHeaven.View
{
    public partial class form_KitchenView : Form
    {
        public form_KitchenView()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.SystemColors.Control;
        }

        private void form_KitchenView_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {
            panel_Orders.Controls.Clear();
            string qry1 = @"SELECT * FROM tableMain WHERE status = 'Pending'";
            SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt1);

            foreach (DataRow row in dt1.Rows)
            {
                FlowLayoutPanel mainPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Width = 320,
                    FlowDirection = FlowDirection.TopDown,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                FlowLayoutPanel headerPanel = new FlowLayoutPanel
                {
                    BackColor = Color.FromArgb(50, 55, 89),
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Width = 300,
                    FlowDirection = FlowDirection.TopDown,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                Label tableLabel = new Label
                {
                    Text = "Table: " + row["TableName"].ToString(),
                    ForeColor = Color.White,
                    Margin = new Padding(10, 10, 3, 0),
                    AutoSize = true
                };
                headerPanel.Controls.Add(tableLabel);

                Label waiterLabel = new Label
                {
                    Text = "Waiter Name: " + row["WaiterName"].ToString(),
                    ForeColor = Color.White,
                    Margin = new Padding(10, 5, 3, 0),
                    AutoSize = true
                };
                headerPanel.Controls.Add(waiterLabel);

                Label orderTimeLabel = new Label
                {
                    Text = "Order Time: " + row["aTime"].ToString(),
                    ForeColor = Color.White,
                    Margin = new Padding(10, 5, 3, 0),
                    AutoSize = true
                };
                headerPanel.Controls.Add(orderTimeLabel);

                Label orderTypeLabel = new Label
                {
                    Text = "Order Type: " + row["orderType"].ToString(),
                    ForeColor = Color.White,
                    Margin = new Padding(10, 5, 3, 0),
                    AutoSize = true
                };
                headerPanel.Controls.Add(orderTypeLabel);

                mainPanel.Controls.Add(headerPanel);

                int mainID = Convert.ToInt32(row["MainID"].ToString());

                string qry2 = @"SELECT p.pName, d.qty FROM tableDetails d
                                INNER JOIN products p ON p.pID = d.proID
                                WHERE d.MainID = @MainID";
                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@MainID", mainID);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);

                FlowLayoutPanel productPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Width = 300,
                    FlowDirection = FlowDirection.TopDown,
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(10)
                };

                foreach (DataRow productRow in dt2.Rows)
                {
                    Label productLabel = new Label
                    {
                        Text = productRow["pName"].ToString() + " x " + productRow["qty"].ToString(),
                        ForeColor = Color.Black,
                        Margin = new Padding(10, 5, 3, 0),
                        AutoSize = true
                    };
                    productPanel.Controls.Add(productLabel);
                }

                mainPanel.Controls.Add(productPanel);

                Button completeButton = new Button
                {
                    Text = "Complete",
                    BackColor = Color.FromArgb(241, 85, 126),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    Margin = new Padding(60, 5, 3, 10),
                    Tag = mainID // Assign the MainID as the Tag
                };
                completeButton.Click += b_click;
                mainPanel.Controls.Add(completeButton);

                panel_Orders.Controls.Add(mainPanel);
            }
        }

        private void b_click(object sender, EventArgs e)
        {
            int mainID = (int)((Button)sender).Tag;

            // Show confirmation dialog for completion
            var result = MessageBox.Show("Are you sure you want to mark this order as complete?",
                                         "Confirm Completion",
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                string qry = @"UPDATE tableMain SET status = 'Complete' WHERE MainID = @ID";
                Hashtable ht = new Hashtable
                {
                    { "@ID", mainID }
                };

                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Order marked as complete successfully.", "Order Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetOrders(); // Refresh the orders
                }
            }
        }
    }
}
