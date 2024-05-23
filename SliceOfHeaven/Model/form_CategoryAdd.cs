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

        public int id = 0;

        public override void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void form_SampleAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
