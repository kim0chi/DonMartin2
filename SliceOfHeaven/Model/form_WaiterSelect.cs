using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliceOfHeaven.Model
{
    public partial class form_WaiterSelect : Form
    {
        public form_WaiterSelect()
        {
            InitializeComponent();
        }

        public string waiterName;

        private void form_WaiterSelect_Load(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM staff where sRole LIKE 'Waiter'";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Button b = new Button();
                b.Text = row["sName"].ToString();
                b.Width = 150;
                b.Height = 150;
                b.BackColor = Color.FromArgb(241, 85, 126);
                b.FlatStyle = FlatStyle.Flat;
                b.ForeColor = Color.White;

                // Event for Click
                b.Click += new EventHandler(_Click);
                panel_Control.Controls.Add(b);

            }
        }

        private void _Click(object sender, EventArgs e)
        {
            waiterName = (sender as Button).Text.ToString();
            this.Close();
        }
    }
}
