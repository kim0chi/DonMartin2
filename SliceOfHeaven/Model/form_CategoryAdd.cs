using System;
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

        public override void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}
