using SliceOfHeaven.Model;
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

namespace SliceOfHeaven.View
{
    public partial class form_TableView : form_SampleView
    {
        form_TableAdd add = new form_TableAdd();
        Hashtable ht = new Hashtable();

        public form_TableView()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = "SELECT* FROM tables WHERE tname LIKE '%" + txtbox_Search.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvname);

            MainClass.LoadData(qry, dgv_CategoryView, lb);
        }
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            //add.ShowDialog();

            MainClass.BlurBackground(new form_TableAdd());
            GetData();
        }

        public override void txtbox_Search_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void txtbox_Search_TextChanged_1(object sender, EventArgs e)
        {
            GetData();
        }

        private void form_TableView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dgv_CategoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgv_CategoryView.CurrentCell.OwningColumn.Name == "dgvdel")
                {
                    // Show confirmation dialog for deletion
                    var result = MessageBox.Show("Are you sure you want to delete this row?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.OKCancel,
                                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        // Perform the delete operation
                        int id = Convert.ToInt32(dgv_CategoryView.CurrentRow.Cells["dgvid"].Value);
                        string qry = "DELETE FROM tables WHERE tid = " + id;
                        
                        MainClass.SQL(qry, ht);

                        MessageBox.Show("Deleted Successfully");

                        // Remove the deleted row from the DataGridView
                        dgv_CategoryView.Rows.RemoveAt(dgv_CategoryView.CurrentRow.Index);
                    }
                }
                else if (dgv_CategoryView.CurrentCell.OwningColumn.Name == "dgvedit")
                {
                    // Open the edit form
                    form_TableAdd add = new form_TableAdd();
                    add.id = Convert.ToInt32(dgv_CategoryView.CurrentRow.Cells["dgvid"].Value);
                    add.txtbox_name.Text = Convert.ToString(dgv_CategoryView.CurrentRow.Cells["dgvname"].Value);
                    //add.ShowDialog();
                    MainClass.BlurBackground(new form_TableAdd());

                    // Refresh the data in the DataGridView after editing
                    GetData();
                }
            }
        }

        private void dgv_CategoryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void form_TableView_Load_1(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
