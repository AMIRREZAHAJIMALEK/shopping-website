using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sign_up.log_in
{
    public partial class add_LAPTOP : Form
    {
        public add_LAPTOP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product_registration product_Registration = new Product_registration();
            this.Hide();
            product_Registration.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Db lt = new Db();
            LAPTOP lAPTOP = new LAPTOP();
            bool b = false;
            foreach (var item in lt.LAPTOPs)
            {
                if (item.model == textBox2.Text)
                {
                    MessageBox.Show("Your model has been added");
                    b = true;
                    break;
                }
            }
            if (b == false)
            {
                lAPTOP.inch = Convert.ToInt32(textBox1.Text);
                lAPTOP.model = textBox2.Text;
                lAPTOP.price = Convert.ToInt32(textBox3.Text);
                lAPTOP.discription = textBox4.Text;
                lAPTOP.company = textBox5.Text;
                lt.LAPTOPs.Add(lAPTOP);
                lt.SaveChanges();
                MessageBox.Show("Your model added", "Success!");
            }
        }
    }
}
