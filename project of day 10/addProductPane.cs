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
    public partial class addProductPane : Form
    {
        public List<string> productList = new List<string>();
        public addProductPane()
        {
            InitializeComponent();
            checklist();
        }

        public string returnValues()
        {
            string txtBox = textBox1.Text;
            return txtBox;
        }

        public void checklist()
        {
            list List = new list();
            string text = returnValues();
            List.Show();
            productList.Add(text);
        }

        private void addProductPane_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonAbrirForm2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list form2 = new list();
            form2.Show();
            form2.boxText1 = textBox1.Text;
        }
    }
}
