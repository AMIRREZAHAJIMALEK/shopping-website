using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sign_up.log_in
{
    public partial class add_MOBILE : Form
    {
        public add_MOBILE()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Db mo = new Db();
            MOBILE momiles = new MOBILE();
            bool b = false;
            foreach (var item in mo.Mobiles)
            {
                if (item.model == textBox1.Text)
                {
                    MessageBox.Show("Your model has been added");
                    b = true;
                    break;
                }
            }
            if (b == false)
            {
                momiles.model = textBox1.Text;
                momiles.price = Convert.ToInt32(textBox2.Text);
                momiles.discription = textBox3.Text;
                momiles.company = textBox4.Text;
                mo.Mobiles.Add(momiles);
                mo.SaveChanges();
                MessageBox.Show("Your model added", "Success!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product_registration product_Registration = new Product_registration();
            this.Hide();
            product_Registration.ShowDialog();
        }
    }
}
