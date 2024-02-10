using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Container c1 = new Container();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("null");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(textBox1.Text);
            double value2 = Convert.ToDouble(textBox2.Text);
            double sum = value1 + value2;
            textBox3.Text = Convert.ToString(sum);
            if (sum == 7)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
