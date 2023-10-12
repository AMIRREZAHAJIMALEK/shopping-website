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
    public partial class add_TV : Form
    {
        public add_TV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Db tv = new Db();
            TV tvs = new TV();
            bool b = false;
            foreach (var item in tv.TVs)
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
                tvs.inch = Convert.ToInt32(textBox1.Text);
                tvs.model = textBox2.Text;
                tvs.price = Convert.ToInt32(textBox3.Text);
                tvs.discription = textBox4.Text;
                tvs.company = textBox5.Text;
                tv.TVs.Add(tvs);
                tv.SaveChanges();
                MessageBox.Show("Your model added", "Success!");
            }
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            Product_registration product_Registration = new Product_registration();
            this.Hide();
            product_Registration.ShowDialog();
        }

        private void add_TV_Load(object sender, EventArgs e)
        {

        }
    }
}
