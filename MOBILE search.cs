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
    public partial class MOBILE_search : Form
    {
        public MOBILE_search()
        {
            InitializeComponent();
        }
        public Db dB = new Db();
        private void MOBILE_search_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            store store2 = new store();
            this.Hide();
            store2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dB.Mobiles.ToList();
            }
            else
            {
                var am =dB.Mobiles.Where(i => i.price.ToString() == (textBox1.Text) || i.model.Contains(textBox1.Text) || i.discription.Contains(textBox1.Text) || i.company.Contains(textBox1.Text));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = am.ToList();
            }
        }
    }
}
