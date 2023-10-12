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
    public partial class KEYBOARD_search : Form
    {
        public KEYBOARD_search()
        {
            InitializeComponent();
        }

        private void KEYBOARD_search_Load(object sender, EventArgs e)
        {

        }
        public Db db = new Db();
        private void button2_Click(object sender, EventArgs e)
        {
            store store = new store();
            this.Hide();
            store.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = db.Keyboards.ToList();
            }
            else
            {
                var ak = db.Keyboards.Where(i => i.price.ToString() == (textBox1.Text) || i.model == (textBox1.Text) || i.discription == (textBox1.Text) || i.company == (textBox1.Text) || i.color == (textBox1.Text));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ak.ToList();
            }
        }
    }
}
