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
    public partial class MOUSE_search : Form
    {
        public MOUSE_search()
        {
            InitializeComponent();
        }
        public Db dbmo = new Db();
        private void button2_Click(object sender, EventArgs e)
        {
            store store4 = new store();
            this.Hide();
            store4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dbmo.Mouses.ToList();
            }
            else
            {
                var amou = dbmo.Mouses.Where(i => i.price.ToString() == (textBox1.Text) || i.model.Contains(textBox1.Text) || i.discription.Contains(textBox1.Text) || i.accuracy.ToString() == (textBox1.Text) || i.company == (textBox1.Text));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = amou.ToList();
            }
        }
    }
}
