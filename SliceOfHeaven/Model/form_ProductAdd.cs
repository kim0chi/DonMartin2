using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SliceOfHeaven.Model
{
    public partial class form_ProductAdd : form_SampleAdd
    {
        public form_ProductAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int CID = 0;

        string filePath;
        byte[] imageByteArray;
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|* .png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                pbox_Browse.Image = new Bitmap(filePath);
            }
        }

        private void form_ProductAdd_Load(object sender, EventArgs e)
        {
            // For CB Fill
            string qry = "Select catID 'id', catName 'name' FROM category";

            MainClass.CBFIll(qry, cbox_Category);

            if (CID > 0)
            {
                cbox_Category.SelectedValue = CID;
            }

            if (id > 0)
            {
                ForUpdateLoadData();
            }
        }



        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbox_name.Text))
                {
                    MessageBox.Show("Please enter a Product Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtbox_Price.Text))
                {
                    MessageBox.Show("Please enter a Price Value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(cbox_Category.Text))
                {
                    MessageBox.Show("Please enter a Category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string categoryName = txtbox_name.Text.Trim();

                if (MainClass.IsDuplicateProduct(categoryName))
                {
                    MessageBox.Show("Product with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string qry = "";
                Hashtable ht = new Hashtable();

                if (id == 0)
                {
                    qry = "INSERT INTO products VALUES (@Name, @price, @cat, @img)";
                    ht.Add("@Name", txtbox_name.Text);
                }
                else
                {
                    qry = "UPDATE products SET pName = @Name, pPrice = @price, CategoryID = @cat, pImage = @img WHERE pID = @id";
                    ht.Add("@id", id);
                    ht.Add("@Name", txtbox_name.Text);
                }
                // For Image
                Image temp = new Bitmap(pbox_Browse.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                ht.Add("@price", txtbox_Price.Text);
                ht.Add("@cat", Convert.ToInt32(cbox_Category.SelectedValue));
                ht.Add("@img", imageByteArray);

               
                int rowsAffected = MainClass.SQL(qry, ht);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Staff saved successfully.");
                    id = 0;
                    CID = 0;
                    txtbox_name.Text = "";
                    txtbox_Price.Text = "";
                    cbox_Category.SelectedIndex = 0;
                    cbox_Category.SelectedIndex = -1;
                    pbox_Browse.Image = SliceOfHeaven.Properties.Resources.icons8_bag_96;
                    txtbox_name.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to save Product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForUpdateLoadData()
        {
            try
            {
                // Open the connection
                MainClass.con.Open();

                string qry = @"SELECT * FROM products where pID = @id";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand cmd = new SqlCommand(qry, MainClass.con))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@id", id);

                    // Create a SqlDataAdapter to fill the DataTable
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        // Create a DataTable to hold the results
                        DataTable dt = new DataTable();

                        // Fill the DataTable with the results from the query
                        da.Fill(dt);

                        // Check if any rows were returned
                        if (dt.Rows.Count > 0)
                        {
                            // Populate the controls with data from the DataTable
                            txtbox_name.Text = dt.Rows[0]["pName"].ToString();
                            txtbox_Price.Text = dt.Rows[0]["pPrice"].ToString();

                            byte[] imageArray = (byte[])dt.Rows[0]["pImage"];
                            pbox_Browse.Image = Image.FromStream(new MemoryStream(imageArray));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Make sure to close the connection
                if (MainClass.con.State == ConnectionState.Open)
                {
                    MainClass.con.Close();
                }
            }
        }


        private void btn_Save_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbox_name.Text))
                {
                    MessageBox.Show("Please enter a Product Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtbox_Price.Text))
                {
                    MessageBox.Show("Please enter a Price Value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(cbox_Category.Text))
                {
                    MessageBox.Show("Please enter a Category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string categoryName = txtbox_name.Text.Trim();

                if (MainClass.IsDuplicateStaff(categoryName))
                {
                    MessageBox.Show("Product with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string qry = "";
                Hashtable ht = new Hashtable();

                if (id == 0)
                {
                    qry = "INSERT INTO products VALUES (@Name, @price, @cat, @img)";
                    ht.Add("@Name", txtbox_name.Text);
                }
                else
                {
                    qry = "UPDATE products SET pName = @Name, pPrice = @price, CategoryID = @cat, pImage = @img WHERE pID = @id";
                    ht.Add("@id", id);
                    ht.Add("@Name", txtbox_name.Text);
                }
                // For Image
                Image temp = new Bitmap(pbox_Browse.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                ht.Add("@price", txtbox_Price.Text);
                ht.Add("@cat", Convert.ToInt32(cbox_Category.SelectedValue));
                ht.Add("@img", imageByteArray);


                int rowsAffected = MainClass.SQL(qry, ht);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Staff saved successfully.");
                    id = 0;
                    CID = 0;
                    txtbox_name.Text = "";
                    txtbox_Price.Text = "";
                    cbox_Category.SelectedIndex = -1;
                    pbox_Browse.Image = SliceOfHeaven.Properties.Resources.icons8_bag_96;
                    txtbox_name.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to save Product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
