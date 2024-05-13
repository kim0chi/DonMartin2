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
    public partial class form_SampleAdd : Form
    {
        public form_SampleAdd()
        {
            InitializeComponent();
        }

        public virtual void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
