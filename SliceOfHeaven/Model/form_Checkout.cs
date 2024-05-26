using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliceOfHeaven.Model
{
    public partial class form_Checkout : form_SampleAdd
    {
        public form_Checkout()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public double amt;
        public int MainID = 0;
        private void txtbox_Payment_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double receipt = 0;
            double change = 0;

            double.TryParse(txtbox_BillAmount.Text, out amt);
            double.TryParse(txtbox_Payment.Text, out receipt);
            
            change = Math.Abs(amt - receipt);

            if (amt > receipt)
            {
                txtbox_Change.Text = $"Payment short for ₱{change.ToString()}";
                btn_Save.Enabled = false;
            }
            else
            {
                txtbox_Change.Text = change.ToString();
                btn_Save.Enabled = true;
            }
            
        }

        public override void btn_Save_Click(object sender, EventArgs e)
        {
            string qry = @"UPDATE tableMain SET total = @total, received = @rec, change = @change, status = 'Paid'
                            WHERE MainID = @id";

            Hashtable ht = new Hashtable();
            ht.Add("@id", MainID);
            ht.Add("@total", txtbox_BillAmount.Text);
            ht.Add("@rec", txtbox_Payment.Text);
            ht.Add("@change", txtbox_Change.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Successfully Saved", "Checkout Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void form_Checkout_Load(object sender, EventArgs e)
        {
            txtbox_BillAmount.Text = amt.ToString();
        }
    }
}
