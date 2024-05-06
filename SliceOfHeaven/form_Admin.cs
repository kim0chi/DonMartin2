using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliceOfHeaven
{
    public partial class form_Admin : Form
    {
        public form_Admin()
        {
            InitializeComponent();
        }

        private void form_Admin_Load(object sender, EventArgs e)
        {
            lbl_User.Text = MainClass.ADMIN;
        }

        public void AddControls(Form f)
        {
            panel_Center.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panel_Center.Controls.Add(f);
            f.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            AddControls(new form_Home());
        }

        private void lbl_User_Click(object sender, EventArgs e)
        {

        }
    }
}
