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
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        public Db Db1 = new Db();
        private void log_in_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool b = false;
            foreach (var item in Db1.Sign_Ups)
            {
                if (item.Username == textBox1.Text)
                {
                    if (item.Password == textBox2.Text)
                    {
                        MessageBox.Show("you entered", "Success!");
                        b = true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Password is wrong");
                    }
                }
            }
            if (b)
            {
                store store = new store();
                this.Hide();
                store.ShowDialog();
            }
            else
            {
                MessageBox.Show("This user was not found");
            }
            //var result = from i in Db1.Sign_Ups where i.Username == textBox1.Text && i.Password == textBox2.Text select i;
            //if (result.Count() == 1)
            //{
            //    MessageBox.Show("You have successfully logged in!\n!با موفقیت وارد شدید");
            //    admin admin = new admin();
            //    admin.Show();
            //}
            //else
            //{
            //    MessageBox.Show("please Check the password or username\nلطفا پسورد یا نام کاربری را چک کنید");
            //}
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
    }
}
