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
    public partial class form_BillList : form_SampleAdd
    {
        public form_BillList()
        {
            InitializeComponent();
        }

        public int MainID = 0;

        private void form_BillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string qry = @"SELECT MainID, TableName, WaiterName, orderType, status, total FROM tableMain WHERE status = 'Pending' OR status = 'Complete' OR status = 'Hold' OR status = 'Paid'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvTable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);

            MainClass.LoadData(qry, dgv_CategoryView, lb);
        }

        private void dgv_CategoryView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // For serial number

            int count = 0;

            foreach (DataGridViewRow row in dgv_CategoryView.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void dgv_CategoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgv_CategoryView.CurrentCell.OwningColumn.Name == "dgvedit")
                {
                    MainID = Convert.ToInt32(dgv_CategoryView.CurrentRow.Cells["dgvid"].Value);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {

        }
    }
}
