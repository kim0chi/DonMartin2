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
    public partial class form_TableSelect : Form
    {
        public form_TableSelect()
        {
            InitializeComponent();
        }

        public string TableName;

        private void form_TableSelect_Load(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM tables";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Button b = new Button();
                b.Text = row["tname"].ToString();
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
            TableName = (sender as Button).Text.ToString();
            this.Close();
        }

        private void panel_Control_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
