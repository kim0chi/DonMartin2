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

        public int DETAILID = 0;
        public int MainID = 0;
        public string OrderType = "";
        public int driverID = 0;
        public string custNamePOS = "";
        public string custPhonePOS = "";
        public string DriverPOS = "";

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

        private void AddItems(string id, String proID, string name, string cat, string price, Image pImage)
        {
            var w = new ucProduct
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
                AddItems("0", item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imageArray)));
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
            lbl_OrderType.Text = "";
        }

        private void btn_Delivery_Click(object sender, EventArgs e)
        {
            form_CustomerAdd add = new form_CustomerAdd();
            driverID = add.driverID;
            custNamePOS = add.custName;
            custPhonePOS = add.custPhone;
            DriverPOS = add.Driver;
            lbl_Table.Text = custNamePOS;
            lbl_Waiter.Text = custPhonePOS;
            lbl_Table.Visible = false;
            lbl_Waiter.Visible = false;
            OrderType = "Delivery";
            lbl_OrderType.Text = OrderType;
            add.orderType = OrderType;


            MainClass.BlurBackgroundPOS(this, add);
            if (OrderType == "Delivery")
            {
                driverID = add.driverID;
                custNamePOS = add.custName;
                custPhonePOS = add.custPhone;
                DriverPOS = add.Driver;
                lbl_DriverName.Visible = true;
                lbl_DriverName.Text = $"Customer Name: {custNamePOS}      Phone: {custPhonePOS}     Driver: {DriverPOS}";
            }
        }

        private void btn_TakeOut_Click(object sender, EventArgs e)
        {
            form_CustomerAdd add = new form_CustomerAdd();
            driverID = add.driverID;
            custNamePOS = add.custName;
            custPhonePOS = add.custPhone;
            DriverPOS = add.Driver;
            lbl_Table.Text = custNamePOS;
            lbl_Waiter.Text = custPhonePOS;
            lbl_Table.Visible = false;
            lbl_Waiter.Visible = false;
            OrderType = "Take Out";
            lbl_OrderType.Text = OrderType;
            add.orderType = OrderType;

            
            add.MainID = MainID;
            MainClass.BlurBackgroundPOS(this, add);

            if (OrderType == "Take Out")
            {
                driverID = add.driverID;
                lbl_DriverName.Visible = true;
                custNamePOS = add.custName;
                custPhonePOS = add.custPhone;
                DriverPOS = add.Driver;
                lbl_DriverName.Text = $"Customer Name: {custNamePOS}      Phone: {custPhonePOS}";
            }
        }

        private void btn_DineIn_Click(object sender, EventArgs e)
        {
            // Create form for table selection and waiter selection
            OrderType = "Dine In";
            lbl_OrderType.Text = OrderType;
            lbl_DriverName.Visible = false;
            form_TableSelect table = new form_TableSelect();
            MainClass.BlurBackgroundPOS(this, table);

            if (table.TableName != "")
            {
                lbl_Table.Text = table.TableName;
            }
            else
            {
                lbl_Table.Text = "";
            }

            form_WaiterSelect waiter = new form_WaiterSelect();
            MainClass.BlurBackgroundPOS(this, waiter);
            if (waiter.waiterName != "")
            {
                lbl_Waiter.Text = waiter.waiterName;
            }
            else
            {
                lbl_Waiter.Text = "";
            }
        }

        public string detailID;

        private void btn_Kitchen_Click(object sender, EventArgs e)
        {
            // Save the data in the database
            // Create table
            string qry1 = ""; // Main table
            string qry2 = ""; // Detail table

            detailID = "0";

            if (MainID == 0) // Insert
            {
                qry1 = @"INSERT INTO tableMain VALUES 
                        (@aDate, @aTime, @TableName, @WaiterName, @status, @orderType,
	                    @total, @received, @change, @driverID, @CustName, @CustPhone);
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
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@CustName", custNamePOS);
            cmd.Parameters.AddWithValue("@CustPhone", custPhonePOS);

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
                detailID = existingDetails[proID].ToString();
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
            MainID = 0;
            DETAILID = 0;
            dgv_CategoryView.Rows.Clear();
            lbl_Table.Text = "";
            lbl_Waiter.Text = "";
            lbl_Table.Visible = false;
            lbl_Waiter.Visible = false;
            lbl_Total.Text = "00";
            lbl_DriverName.Text = "";
        }

        private void lbl_Total_Click(object sender, EventArgs e)
        {

        }

        private void lbl_OrderType_Click(object sender, EventArgs e)
        {
            

        }

        public int id = 0;

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            form_BillList bill = new form_BillList();
            MainClass.BlurBackgroundPOS(this, bill);

            if (bill.DialogResult == DialogResult.OK && bill.MainID > 0)
            {
                id = bill.MainID;
                LoadEntries();
            }
        }

        private void LoadEntries()
        {
            string qry = @"SELECT * FROM tableMain m INNER JOIN tableDetails d ON m.MainID = d.MainID INNER JOIN products p ON p.pID = d.proID 
                            WHERE m.MainID = "+ id +"";

            SqlCommand cmd2 = new SqlCommand(qry, MainClass.con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            /*if (dt2.Rows[0]["orderType"].ToString() == "Take Out")
            {
                lbl_Waiter.Visible = false;
                lbl_Table.Visible = false;
            }
            else if (dt2.Rows[0]["orderType"].ToString() == "Delivery")
            {
                lbl_Waiter.Visible = false;
                lbl_Table.Visible = false;
            }
            else
            {
                lbl_Waiter.Visible = true;
                lbl_Table.Visible = true;
            }*/

            dgv_CategoryView.Rows.Clear();

            foreach (DataRow item in dt2.Rows)
            {
                lbl_Table.Text = item["TableName"].ToString();
                lbl_Waiter.Text = item["WaiterName"].ToString();

                string detailid = item["DetailID"].ToString();
                string proName = item["pName"].ToString();
                string proid = item["proID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();

                object[] obj = { 0, detailid, proid,proName, qty, price, amount };
                dgv_CategoryView.Rows.Add(obj);
            }
            GetTotal();
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            form_Checkout checkout = new form_Checkout();
            checkout.MainID = id;
            checkout.amt = Convert.ToDouble(lbl_Total.Text);
            MainClass.BlurBackgroundPOS(this, checkout);
            dgv_CategoryView.Rows.Clear();
            lbl_Table.Text = "";
            lbl_Waiter.Text = "";
            lbl_Table.Visible = false;
            lbl_Waiter.Visible = false;
            OrderType = "";
            lbl_OrderType.Text = OrderType;
        }

        private void btn_Hold_Click(object sender, EventArgs e)
        {
            // Save the data in the database
            // Create table
            string qry1 = ""; // Main table
            string qry2 = ""; // Detail table

            detailID = "0";

            if (MainID == 0) // Insert
            {
                qry1 = @"INSERT INTO tableMain VALUES 
                        (@aDate, @aTime, @TableName, @WaiterName, @status, @orderType,
	                    @total, @received, @change, @driverID, @CustName, @CustPhone);
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
            cmd.Parameters.AddWithValue("@status", "Hold");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lbl_Total.Text)); // Saving data for kitchen value and will update when payment is received
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", DriverPOS);
            cmd.Parameters.AddWithValue("@CustName", custNamePOS);
            cmd.Parameters.AddWithValue("@CustPhone", custPhonePOS);

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
                detailID = existingDetails[proID].ToString();
                DETAILID = existingDetails[proID];
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
            MainID = 0;
            DETAILID = 0;
            dgv_CategoryView.Rows.Clear();
            lbl_Table.Text = "";
            lbl_Waiter.Text = "";
            lbl_Table.Visible = false;
            lbl_Waiter.Visible = false;
            lbl_Total.Text = "00";
            lbl_DriverName.Text = "";

        }

        private void panel_Product_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Category_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
