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
    public partial class form_StaffAdd : form_SampleAdd
    {
        public form_StaffAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbox_name.Text))
                {
                    MessageBox.Show("Please enter a staff name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtbox_Phone.Text))
                {
                    MessageBox.Show("Please enter a Staff Phone Nunber.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtbox_Address.Text))
                {
                    MessageBox.Show("Please enter a Staff Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string categoryName = txtbox_name.Text.Trim();

                if (MainClass.IsDuplicateStaff(categoryName))
                {
                    MessageBox.Show("Staff with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string qry = "";
                Hashtable ht = new Hashtable();

                if (id == 0)
                {
                    qry = "INSERT INTO staff VALUES (@Name, @phone, @address, @role)";
                    ht.Add("@Name", txtbox_name.Text);
                }
                else
                {
                    qry = "UPDATE staff SET sName = @Name, sPhone = @phone, sAddress = @address, sRole = @role WHERE staffID = @id";
                    ht.Add("@id", id);
                    ht.Add("@Name", txtbox_name.Text);
                }
                ht.Add("@phone", txtbox_Phone.Text);
                ht.Add("@address", txtbox_Address.Text);
                ht.Add("@role", cbox_Role.Text);


                int rowsAffected = MainClass.SQL(qry, ht);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Staff saved successfully.");
                    id = 0;
                    txtbox_name.Text = "";
                    txtbox_Phone.Text = "";
                    txtbox_Address.Text = "";
                    cbox_Role.SelectedIndex = -1;
                    txtbox_name.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to save Staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }

    
}
