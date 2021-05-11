using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.a = Convert.ToInt32(textBox1.Text);
            frm.b = Convert.ToInt32(textBox2.Text);
            frm.c = Convert.ToInt32(textBox3.Text);
            this.Hide();
            frm.Show();
           
        }
    }
}
