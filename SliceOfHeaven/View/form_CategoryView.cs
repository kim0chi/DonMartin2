using SliceOfHeaven.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliceOfHeaven.View
{
    public partial class form_CategoryView : form_SampleView
    {
        form_CategoryAdd frm = new form_CategoryAdd();

        public form_CategoryView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "SELECT* FROM category WHERE catName LIKE '%"+txtbox_search.Text+"%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qry, dataGridView1, lb);
        }


        public override void txtbox_search_TextChanged(object sender, EventArgs e)
        {
            
        }

        public override void pbox_image_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            GetData();
        }

        private void form_CategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_save_Click_2(object sender, EventArgs e)
        {

        }

        private void pbox_image_Click_1(object sender, EventArgs e)
        {

        }
    }
}
