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


        public override void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int id = 0;

        public override void btn_save_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "INSERT INTO category VALUES(@Name)";
            }
            else
            {
                qry = "UPDATE category SET catname = @Name WHERE catID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtbox_Name.Text);
            
            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfully.");
                id = 0;
                txtbox_Name.Focus();
            }


        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
