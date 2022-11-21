using ComboBox;
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

namespace Combo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mycombo1.SelectedIdexChanged += new EventHandler(mycombo1_SelectedIdexChanged);
           

        }
        void mycombo1_SelectedIdexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(mycombo1.SlectedText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            MessageBox.Show(mycombo1.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mycombo1.SlectedText);
        }
    }
}
