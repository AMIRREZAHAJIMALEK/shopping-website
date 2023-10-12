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
using System.Data.Entity;

namespace sign_up.log_in
{
    public partial class TV_search : Form
    {
        public TV_search()
        {
            InitializeComponent();
        }

        private void TV_search_Load(object sender, EventArgs e)
        {

        }
        public Db DB = new Db();

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DB.TVs.ToList();
            }
            else
            {
                var at = DB.TVs.Where(i => i.inch.ToString() == (textBox1.Text) || i.model.Contains(textBox1.Text) || i.discription.Contains(textBox1.Text) || i.price.ToString() == (textBox1.Text));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = at.ToList();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            store store = new store();
            this.Hide();
            store.ShowDialog();
        }
    }
}
