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
    public partial class add_KEYBOARD : Form
    {
        public add_KEYBOARD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product_registration product_Registration = new Product_registration();
            this.Hide();
            product_Registration.ShowDialog();
        }

        private void add_KEYBOARD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Db keyboard = new Db();
            KEYBOARD kEYBOARD = new KEYBOARD();
            bool b = false;
            foreach (var item in keyboard.TVs)
            {
                if (item.model == textBox1.Text)
                {
                    MessageBox.Show("Your model has been added", "Success!");
                    b = true;
                    break;
                }
            }
            if (b == false)
            {
                kEYBOARD.model = (textBox1.Text);
                kEYBOARD.price = Convert.ToInt32(textBox2.Text);
                kEYBOARD.discription = (textBox3.Text);
                kEYBOARD.company = (textBox4.Text);
                kEYBOARD.color = (textBox5.Text);
                keyboard.Keyboards.Add(kEYBOARD);
                keyboard.SaveChanges();
                MessageBox.Show("Your model added", "Success!");
            }
        }
    }
}
