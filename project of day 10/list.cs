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
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
        }
        private void list_Load(object sender, EventArgs e)
        {
            textBox1.Text = boxText1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string boxText1 { get; set; }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
