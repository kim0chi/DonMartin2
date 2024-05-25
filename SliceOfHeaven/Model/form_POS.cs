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
        public string OrderType;

        private void form_POS_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void dgv_CategoryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    Button b = new Button();
                    b.BackColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(134, 45);
                    b.FlatStyle = FlatStyle.Flat;
                    b.ForeColor = Color.White;
                    b.Text = row["catName"].ToString();

                    // Event For Click
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

        }

        private void AddItems(string id, String proID, string name, string cat, string price, Image pImage)
        {
            var w = new ucProduct()
            { 
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pImage,
                id = Convert.ToInt32(proID)
            };

            panel_Product.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach (DataGridViewRow item in dgv_CategoryView.Rows)
                {
                    // This will check if the Product already has quantity and update price
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

                // This Line Adds New Product First for Serial Number and from ID
                dgv_CategoryView.Rows.Add(new object[] { 0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };
        }

        // Getting Product From DataBase
        private void LoadProducts()
        {
            string qry = "SELECT * FROM products INNER JOIN category ON catID = CategoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pImage"];
                byte[] imagebytearray = imagearray;

                AddItems("0",item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
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
            // For Serial Number

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
            //Create Form For Table Selection and Waiter Selection
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
            // Save the Data in Database
            // Create Table
            string qry1 = "";
            string qry2 = "";

            int detailID = 0;
            
            if (MainID == 0) // Insert
            {
                qry1 = @"INSERT INTO tableMain VALUES 
                        (@aDate, @aTime, @TableName, @WaiterName, @status, @orderType,
	                    @total, @received, @change);
                        SELECT SCOPE_IDENTITY()";
                // Get Recent Add ID Value
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
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(0)); // Saving Data For Kitchen Value and will Update When Payment is Received
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

            foreach (DataGridViewRow row in dgv_CategoryView.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0) // INSERT
                {
                    qry2 = @"INSERT INTO tableDetails VALUES (@MainID, @proID, @qty, @price, @amount)";
                }
                else // UPDATE
                {
                    qry2 = @"UPDATE tableDetails SET proID = @proID, qty = @qty, price = @price, amount = @amount 
                    WHERE DetailID = @ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed)
                {
                    MainClass.con.Open();
                }
                if (MainID == 0)
                {
                    MainID = Convert.ToInt32(cmd2.ExecuteScalar());
                }
                else
                {
                    cmd2.ExecuteNonQuery();
                }
                if (MainClass.con.State == ConnectionState.Open)
                {
                    MainClass.con.Close();
                }

                MessageBox.Show("Saved Successfully");
                MainID = 0;
                detailID = 0;
                lbl_Table.Text = "";
                lbl_Waiter.Text = "";
                lbl_Table.Visible = false;
                lbl_Waiter.Visible = false;
                lbl_Total.Text = "00";
            }

        }
    }
}
