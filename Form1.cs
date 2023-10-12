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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sign_up.log_in
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            log_in log_In = new log_in();
            this.Hide();
            log_In.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Db Db1 = new Db();
            Sign_up Sign_up = new Sign_up();
            bool b = false;
            foreach (var item in Db1.Sign_Ups)
            {
                if (item.Username == textBox1.Text)
                {
                    MessageBox.Show("Duplicate, please choose another name");
                    b = true;
                    break;
                }
            }
            if (b == false)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    Sign_up.Username = textBox1.Text;
                    Sign_up.Password = textBox2.Text;
                    Db1.Sign_Ups.Add(Sign_up);
                    Db1.SaveChanges();
                    MessageBox.Show("Your account created", "Success!");
                    store store = new store();
                    this.Hide();
                    store.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password is wrong");
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                pictureBox3.BackgroundImage = sign_up.log_in.Properties.Resources.photo_2023_10_07_23_35_35;
                textBox2.UseSystemPasswordChar = false;
            }
            else if (textBox2.UseSystemPasswordChar == false)
            {
                pictureBox3.BackgroundImage = sign_up.log_in.Properties.Resources.photo_2023_10_07_23_35_31;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (textBox3.UseSystemPasswordChar == true)
            {
                pictureBox4.BackgroundImage = sign_up.log_in.Properties.Resources.photo_2023_10_07_23_35_35;
                textBox3.UseSystemPasswordChar = false;
            }
            else if (textBox3.UseSystemPasswordChar == false)
            {
                pictureBox4.BackgroundImage = sign_up.log_in.Properties.Resources.photo_2023_10_07_23_35_31;
                textBox3.UseSystemPasswordChar = true;
            }
        }
    }
}
