using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliceOfHeaven.Model
{
    public partial class form_CategoryAdd : form_SampleAdd
    {
        public form_CategoryAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void form_SampleAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbox_name.Text))
                {
                    MessageBox.Show("Please enter a category name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string categoryName = txtbox_name.Text.Trim();

                if (MainClass.IsDuplicateCategoryName(categoryName))
                {
                    MessageBox.Show("Category with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string qry = "";
                Hashtable ht = new Hashtable();

                if (id == 0)
                {
                    qry = "INSERT INTO category VALUES (@Name)";
                }
                else
                {
                    qry = "UPDATE category SET catName = @Name WHERE catID = @id";
                    ht.Add("@id", id);
                }

                ht.Add("@Name", categoryName);

                int rowsAffected = MainClass.SQL(qry, ht);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Category saved successfully.");
                    id = 0;
                    txtbox_name.Text = "";
                    txtbox_name.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to save category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
