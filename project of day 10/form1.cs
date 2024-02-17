using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            addProductPane paneForProduct = new addProductPane();
            paneForProduct.Show();
            Form1 inForm = new Form1();
            inForm.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
