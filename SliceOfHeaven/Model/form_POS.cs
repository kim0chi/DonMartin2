using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
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
            Button b = (Button)sender; ;
            foreach (var item in panel_Product.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddItems(string id, string name, string cat, string price, Image pImage)
        {
            var w = new ucProduct()
            { 
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pImage,
                id = Convert.ToInt32(id)
            };

            panel_Product.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach (DataGridViewRow item in dgv_CategoryView.Rows)
                {
                    // This will check if the Product already has quantity and update price
                    if (Convert.ToInt32(item.Cells["dgvid"].Value) == wdg.id)
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

                // This Line Adds New Product
                dgv_CategoryView.Rows.Add(new object[] { 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
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

                AddItems(item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
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
    }
}
