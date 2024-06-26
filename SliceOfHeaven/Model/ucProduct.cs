﻿using System;
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
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;
        public int id { get; set; }

        public string PPrice
        {
            get { return lbl_Price.Text; }
            set { lbl_Price.Text = $"{value}"; }
        }

        public string PCategory { get; set; }

        public string PName 
        { 
            get { return lbl_Name.Text; }
            set { lbl_Name.Text = value;}
        }

        public Image PImage
        {
            get { return pbox_ProductPic.Image; }
            set {  pbox_ProductPic.Image = value;}
        }

        private void pbox_ProductPic_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);

            /*// Open the QuantityInputForm
            QuantityInputForm quantityInputForm = new QuantityInputForm();
            if (quantityInputForm.ShowDialog() == DialogResult.OK)
            {
                // Raise the QuantityChanged event with the new quantity
                QuantityChanged?.Invoke(quantityInputForm.Quantity);
            }*/
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }
    }
}
