using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      

           
       
           
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public int a, b, c;
        private void Form2_Load(object sender, EventArgs e)
        {
         
            comboBox1.Items.Add(a.ToString());
            comboBox1.Items.Add(b.ToString());
            comboBox1.Items.Add(c.ToString());
        }
    }
}
