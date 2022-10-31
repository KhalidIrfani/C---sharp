using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            foreach(object item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item.ToString());
                sb.Append(item.ToString()); 
                sb.Append(" ");
            };

            MessageBox.Show("Select the items first", sb.ToString());




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
