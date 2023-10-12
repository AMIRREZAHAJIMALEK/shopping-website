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
    public partial class Product_registration : Form
    {
        public Product_registration()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            add_TV add_TV = new add_TV();
            this.Hide();
            add_TV.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            store store = new store();
            this.Hide();
            store.ShowDialog();
        }

        private void Product_registration_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            add_KEYBOARD add_KEYBOARD = new add_KEYBOARD();
            this.Hide();
            add_KEYBOARD.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            add_MOBILE add_MOBILE = new add_MOBILE();
            this.Hide();
            add_MOBILE.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            add_LAPTOP add_LAPTOP = new add_LAPTOP();
            this.Hide();
            add_LAPTOP.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            add_MOUSE add_MOUSE = new add_MOUSE();
            this.Hide();
            add_MOUSE.ShowDialog();
        }
    }
}
