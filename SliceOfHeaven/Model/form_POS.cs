using ReaLTaiizor.Extension;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.Directives;
using System.Windows.Forms;

namespace SliceOfHeaven.Model
{
    public partial class form_POS : Form
    {
        public form_POS()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        public string OrderType = "";

        private void form_POS_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Perform any cleanup if necessary
        }

        private void dgv_CategoryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content clicks if needed
        }

        public static Form PreviousForm { get; set; }
        public string PName { get; private set; }
        public string PPrice { get; private set; }
        public string PCategory { get; private set; }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (PreviousForm != null)
                {
                    PreviousForm.Show();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_POS_Load(object sender, EventArgs e)
        {
            dgv_CategoryView.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();
            panel_Product.Controls.Clear();
            LoadProducts();
        }

        private void AddCategory()
        {
            string qry = "SELECT * FROM category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            panel_Category.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Button b = new Button
                    {
                        BackColor = Color.FromArgb(50, 55, 89),
                        Size = new Size(134, 45),
                        FlatStyle = FlatStyle.Flat,
                        ForeColor = Color.White,
                        Text = row["catName"].ToString()
                    };

                    // Event for Click
                    b.Click += new EventHandler(_Click);

                    panel_Category.Controls.Add(b);
                }
            }
        }

        private void _Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Text == "All Categories")
            {
                txtbox_Search.Text = "1";
                txtbox_Search.Text = "";
                return;
            }

            foreach (var item in panel_Product.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Handle button click if needed
        }

        private void AddItems(string id, int proID, string name, string cat, string price, Image pImage)
        {
            var w = new ucProduct
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pImage,
                id = proID
            };

            panel_Product.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach (DataGridViewRow item in dgv_CategoryView.Rows)
                {
                    // This will check if the product already has quantity and update price
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        // Update the quantity and amount
                        int newQty = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvQty"].Value = newQty.ToString();
                        item.Cells["dgvAmount"].Value = newQty * double.Parse(item.Cells["dgvPrice"].Value.ToString());

                        // Update the total amount
                        GetTotal();

                        return;
                    }
                }

                // This line adds new product first for serial number and from ID
                dgv_CategoryView.Rows.Add(new object[] { 0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };
        }

        // Getting product from database
        private void LoadProducts()
        {
            string qry = "SELECT * FROM products INNER JOIN category ON catID = CategoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                byte[] imageArray = (byte[])item["pImage"];
                AddItems("0", (int)item["pID"], item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imageArray)));
            }
        }

        private void txtbox_Search_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in panel_Product.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtbox_Search.Text.Trim().ToLower());
            }
        }

        private void dgv_CategoryView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // For serial number

            int count = 0;

            foreach (DataGridViewRow row in dgv_CategoryView.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void GetTotal()
        {
            double tot = 0;
            lbl_Total.Text = "";

            if (dgv_CategoryView.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dgv_CategoryView.Rows)
                {
                    tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
                }
            }

            lbl_Total.Text = tot.ToString("N2");
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            lbl_Table.Text = "";
            lbl_Waiter.Text = "";
            lbl_Table.Visible = false;
            lbl_Waiter.Visible = false;
            dgv_CategoryView.Rows.Clear();
            MainID = 0;
            lbl_Total.Text = "00";
        }

        private void btn_Delivery_Click(object sender, EventArgs e)
        {
            lbl_Table.Text = "";
            lbl_Waiter.Text = "";
            lbl_Table.Visible = false;
            lbl_Waiter.Visible = false;
            OrderType = "Delivery";
        }

        private void btn_TakeOut_Click(object sender, EventArgs e)
        {
            lbl_Table.Text = "";
            lbl_Waiter.Text = "";
            lbl_Table.Visible = false;
            lbl_Waiter.Visible = false;
            OrderType = "Take Out";
        }

        private void btn_DineIn_Click(object sender, EventArgs e)
        {
            // Create form for table selection and waiter selection
            OrderType = "Dine In";
            form_TableSelect table = new form_TableSelect();
            MainClass.BlurBackground(table);

            if (table.TableName != "")
            {
                lbl_Table.Text = table.TableName;
            }
            else
            {
                lbl_Table.Text = "";
            }

            form_WaiterSelect waiter = new form_WaiterSelect();
            MainClass.BlurBackground(waiter);
            if (waiter.waiterName != "")
            {
                lbl_Waiter.Text = waiter.waiterName;
            }
            else
            {
                lbl_Waiter.Text = "";
            }
        }

        private void btn_Kitchen_Click(object sender, EventArgs e)
        {
            // Save the data in the database
            // Create table
            string qry1 = ""; // Main table
            string qry2 = ""; // Detail table

            int detailID = 0;

            if (MainID == 0) // Insert
            {
                qry1 = @"INSERT INTO tableMain VALUES 
                        (@aDate, @aTime, @TableName, @WaiterName, @status, @orderType,
	                    @total, @received, @change);
                        SELECT SCOPE_IDENTITY()";
                // Get recent add ID value
            }
            else // Update
            {
                qry1 = @"UPDATE tableMain SET status = @status, total = @total, received = @received, change = @change  
                        WHERE MainID = @ID";
            }

            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lbl_Table.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lbl_Waiter.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lbl_Total.Text)); // Saving data for kitchen value and will update when payment is received
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            if (MainClass.con.State == ConnectionState.Closed)
            {
                MainClass.con.Open();
            }
            if (MainID == 0)
            {
                MainID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                cmd.ExecuteNonQuery();
            }
            if (MainClass.con.State == ConnectionState.Open)
            {
                MainClass.con.Close();
            }

            // Create a dictionary to store the existing DetailIDs for the current MainID
            Dictionary<int, int> existingDetails = new Dictionary<int, int>();

            // Check if there are any existing details for the current MainID
            string checkQuery = "SELECT DetailID, proID FROM tableDetails WHERE MainID = @MainID";
            SqlCommand checkCmd = new SqlCommand(checkQuery, MainClass.con);
            checkCmd.Parameters.AddWithValue("@MainID", MainID);

            if (MainClass.con.State == ConnectionState.Closed)
                MainClass.con.Open();

            SqlDataReader reader = checkCmd.ExecuteReader();

            while (reader.Read())
            {
                int localDetailID = reader.GetInt32(0);
                int proID = reader.GetInt32(1);
                existingDetails[proID] = localDetailID;
            }

            reader.Close();

            if (MainClass.con.State == ConnectionState.Open)
                MainClass.con.Close();

            foreach (DataGridViewRow row in dgv_CategoryView.Rows)
            {
                int proID = Convert.ToInt32(row.Cells["dgvproID"].Value);
                int localDetailID;

                if (existingDetails.TryGetValue(proID, out localDetailID)) // If the product exists, update
                {
                    qry2 = @"UPDATE tableDetails SET qty = @qty, price = @price, amount = @amount 
                WHERE DetailID = @ID";
                }
                else // If the product doesn't exist, insert
                {
                    qry2 = @"INSERT INTO tableDetails VALUES (@MainID, @proID, @qty, @price, @amount)";
                    localDetailID = 0; // Set localDetailID to 0 for new rows
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", localDetailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", proID);
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteNonQuery();

                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }
            }
            MessageBox.Show("Successfully Saved");
        }
    }
}
