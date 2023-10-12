using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace sign_up.log_in
{
    public partial class store : Form
    {
        public store()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            KEYBOARD_search kEYBOARD_Search = new KEYBOARD_search();
            this.Hide();
            kEYBOARD_Search.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TV_search tV_Search = new TV_search();
            this.Hide();
            tV_Search.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Product_registration product_Registration = new Product_registration();
            this.Hide();
            product_Registration.ShowDialog();
        }

        private void store_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MOBILE_search mOBILE_Search = new MOBILE_search();
            this.Hide();
            mOBILE_Search.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LAPTOP_search lAPTOP_Search = new LAPTOP_search();
            this.Hide();
            lAPTOP_Search.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MOUSE_search mOUSE_Search = new MOUSE_search();
            this.Hide();
            mOUSE_Search.ShowDialog();
        }
    }
}
