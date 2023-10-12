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
    public partial class LAPTOP_search : Form
    {
        public LAPTOP_search()
        {
            InitializeComponent();
        }
        Db dbl = new Db();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dbl.LAPTOPs.ToList();
            }
            else
            {
                var al = dbl.LAPTOPs.Where(i => i.inch.ToString() == (textBox1.Text) || i.model.Contains(textBox1.Text) || i.discription.Contains(textBox1.Text) || i.price.ToString() == (textBox1.Text));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = al.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            store store3 = new store();
            this.Hide();
            store3.ShowDialog();
        }
    }
}
