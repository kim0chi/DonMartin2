﻿using System;
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
    public partial class form_Main : Form
    {
        public string DisplayUser = "";
        public form_Main()
        {
            InitializeComponent();
            AddControls(new form_Home());

        }

        public void AddControls(Form f)
        {
            panel_Center.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panel_Center.Controls.Add(f);
            f.Show();

        }

        private void hopeRoundButton1_Click(object sender, EventArgs e)
        {

        }

        private void form_Main_Load(object sender, EventArgs e)
        {
            
        }

        private void metroControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_User_Click(object sender, EventArgs e)
        {

        }

        private void form_Main_Load_1(object sender, EventArgs e)
        {
            string displayUser = MainClass.USER;
            lbl_User.Text = $"{displayUser}!";
            DisplayUser = displayUser;
        }

        private void panel_Center_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            AddControls(new form_Home());
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private bool IsLoggedin()
        {
            if (DisplayUser == "")
            {

            }
            return true; 
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            AddControls(new form_CustomerAccount());
        }

        private void btn_share_Click(object sender, EventArgs e)
        {
            AddControls(new form_CustomerTakeOut());
        }

        private void btn_customize_Click(object sender, EventArgs e)
        {
            AddControls(new form_CustomerDelivery());
        }
    }
}
