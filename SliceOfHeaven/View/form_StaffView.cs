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
    public partial class form_StaffView : form_SampleView
    {
        public form_StaffView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "SELECT* FROM staff WHERE sName LIKE '%" + txtbox_Search.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvname);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvAddress);
            lb.Items.Add(dgvRole);

            MainClass.LoadData(qry, dgv_CategoryView, lb);
        }

        public override void btn_Add_Click(object sender, EventArgs e)
        {
            //form_CategoryAdd add = new form_CategoryAdd();
            //add.ShowDialog();
            MainClass.BlurBackground(new form_StaffAdd());
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

        private void form_StaffView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dgv_CategoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {


                string columnName = dgv_CategoryView.Columns[e.ColumnIndex].Name;

                if (columnName == "dgvdel")
                {
                    // Deletion action
                    // Show confirmation dialog for deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this row?",
                                                           "Confirm Delete",
                                                           MessageBoxButtons.OKCancel,
                                                           MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            // Perform the delete operation
                            int id = Convert.ToInt32(dgv_CategoryView.CurrentRow.Cells["dgvid"].Value);
                            string qry = "DELETE FROM staff WHERE staffID = @id";
                            Hashtable ht = new Hashtable();
                            ht.Add("@id", id);
                            int rowsAffected = MainClass.SQL(qry, ht);

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Deleted Successfully");
                                // Remove the deleted row from the DataGridView
                                dgv_CategoryView.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (columnName == "dgvedit")
                {
                    // Edit action
                    // Open the edit form
                    form_StaffAdd add = new form_StaffAdd();
                    add.id = Convert.ToInt32(dgv_CategoryView.CurrentRow.Cells["dgvid"].Value);
                    add.txtbox_name.Text = Convert.ToString(dgv_CategoryView.CurrentRow.Cells["dgvname"].Value);
                    add.txtbox_Phone.Text = Convert.ToString(dgv_CategoryView.CurrentRow.Cells["dgvPhone"].Value);
                    add.txtbox_Address.Text = Convert.ToString(dgv_CategoryView.CurrentRow.Cells["dgvAddress"].Value);
                    add.cbox_Role.Text = Convert.ToString(dgv_CategoryView.CurrentRow.Cells["dgvRole"].Value);
                    //add.ShowDialog();
                    MainClass.BlurBackground(add);

                    // Refresh the data in the DataGridView after editing
                    GetData();
                }
            }
        }



        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new form_StaffAdd());
            GetData();
        }

        private void txtbox_Search_TextChanged_2(object sender, EventArgs e)
        {
            GetData();
        }

        private void form_StaffView_Load_1(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
