using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        String num = "0";

        public Form1()
        {
            InitializeComponent();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = (Convert.ToInt64(textBox1.Text) + Convert.ToInt64(textBox2.Text)).ToString();
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = (Convert.ToInt64(textBox1.Text) - Convert.ToInt64(textBox2.Text)).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = (Convert.ToInt64(textBox1.Text) * Convert.ToInt64(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                num = "Invalid Args";
            }
            else
            {
                num = (Convert.ToInt64(textBox1.Text) / Convert.ToInt64(textBox2.Text)).ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = num;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }
    }
}
