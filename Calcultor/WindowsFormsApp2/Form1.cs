using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string operation;
        double firstoperand;
        double secondoperand;
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // textBox1.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //textBox1.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
        //    textBox1.Text += btn2.Text;
        }

      private void btn3_Click(object sender, EventArgs e)
       {
         //   textBox1.Text += btn3.Text;
       }

       private void btn4_Click(object sender, EventArgs e)
        {
        //    textBox1.Text += btn4.Text;
        }

       private void btn5_Click(object sender, EventArgs e)
       {
       //     textBox1.Text += btn5.Text;
       }

      private void btn6_Click(object sender, EventArgs e)
       {
        //    textBox1.Text += btn6.Text;
             }

        private void btn7_Click(object sender, EventArgs e)
        {
            //    textBox1.Text += btn7.Text;
        }

      private void btn8_Click(object sender, EventArgs e)
       {
         //   textBox1.Text += btn8.Text;
        }

       private void btn9_Click(object sender, EventArgs e)
        {
           // textBox1.Text += btn9.Text;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
          //  operation = "+";
           // firstoperand=Convert.ToDouble(textBox1.Text);
            //textBox1.Text = "";

        }

        private void btnsub_Click(object sender, EventArgs e)
        {
           // operation = "-";
            //firstoperand = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = "";

        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            //operation = "*";
             //firstoperand = Convert.ToDouble(textBox1.Text);
           // textBox1.Text = "";

        }

        private void btndiv_Click(object sender, EventArgs e)
        {
           // operation = "/";
           // firstoperand = Convert.ToDouble(textBox1.Text);
           // textBox1.Text = "";

        }

        private void btneql_Click(object sender, EventArgs e)
        {
            {
                secondoperand = Convert.ToDouble(textBox1.Text);
                if (operation == "+")
                {
                    textBox1.Text = (firstoperand + secondoperand).ToString();

                }
                else if (operation == "-")
                {
                    textBox1.Text = (firstoperand - secondoperand).ToString();
                }
                else if (operation == "*")
                {
                    textBox1.Text = (firstoperand * secondoperand).ToString();
                }
                else if (operation == "/")
                {
                    textBox1.Text = (firstoperand / secondoperand).ToString();
                }
                else
                {

                }
            }


        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Are you sure", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            firstoperand = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }
    }
}
   