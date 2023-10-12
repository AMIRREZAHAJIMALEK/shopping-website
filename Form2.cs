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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Db db1 = new Db();
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a=from i in db1.Sign_Ups where i.Username.Contains(textBox1.Text)||i.Password.Contains(textBox1.Text) select i;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = a.ToList();
        }
    }
}
