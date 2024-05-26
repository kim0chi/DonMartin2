using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace SliceOfHeaven.Model
{
    public partial class form_CustomerAdd : Form
    {
        public form_CustomerAdd()
        {
            InitializeComponent();
        }

        public string orderType = "";
        public int driverID = 0;
        public int MainID = 0;

        public string custName { get; set; }
        public string custPhone { get; set; }
        public string Driver { get; set; }

        private void form_CustomerAdd_Load(object sender, EventArgs e)
        {
            

            if (orderType == "Take Out")
            {
                lbl_Driver.Visible = false;
                cbox_Driver.Visible = false;
            }
            else
            {
                lbl_Driver.Visible = true;
                cbox_Driver.Visible = true;
            }

            string qry = "SELECT staffID 'id', sName 'name' FROM staff where sRole LIKE 'Driver'";
            MainClass.CBFIll(qry, cbox_Driver);

            if (MainID > 0)
            {
                cbox_Driver.SelectedValue = driverID;
            }

            if (IsAnyTextBoxEmpty())
            {
                MessageBox.Show("All fields must be filled out", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtbox_Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ;
            this.Close();
        }

        private void cbox_Driver_SelectedIndexChanged(object sender, EventArgs e)
        {
            driverID = Convert.ToInt32(cbox_Driver.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.custName = txtbox_Name.Text;
            this.custPhone = txtbox_Phone.Text;
            this.Driver = cbox_Driver.Text;
            MessageBox.Show("Customer Information Saved!","Customer Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsAnyTextBoxEmpty()
        {
            var textBoxes = this.Controls.OfType<TextBox>();

            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
