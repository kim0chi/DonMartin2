using System;
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
    public partial class QuantityInputForm : Form
    {
        public QuantityInputForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public int Quantity { get; private set; }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_OK_Click_1(object sender, EventArgs e)
        {
            // Validate and set the quantity
            if (int.TryParse(txt_Quantity.Text, out int quantity))
            {
                if (quantity > 0)
                {
                    Quantity = quantity;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity (greater than 0).", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value for quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
