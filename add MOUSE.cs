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
    public partial class add_MOUSE : Form
    {
        public add_MOUSE()
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
            Db dbm = new Db();
            MOUSE mouse = new MOUSE();
            bool b = false;
            foreach (var item in dbm.Mouses)
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
                mouse.model = textBox1.Text;
                mouse.price = Convert.ToInt32(textBox2.Text);
                mouse.discription = textBox3.Text;
                mouse.company = textBox4.Text;
                mouse.accuracy = Convert.ToInt32(textBox5.Text);
                dbm.Mouses.Add(mouse);
                dbm.SaveChanges();
                MessageBox.Show("Your model added", "Success!");
            }
        }
    }
}
