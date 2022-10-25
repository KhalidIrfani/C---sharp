using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeView1.Nodes.Add("GCUF");
            treeView1.Visible = false;
            treeView1.Nodes[0].Nodes.Add("Physical Sciences");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Information Technology");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Software Engineering");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Data Science");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Data Analytics");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Computer science");

            treeView1.Nodes[0].Nodes.Add("Life Sciences");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Bio chemistry");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Bio Informatics");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Botany");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Zology");
          
            
            
            
            
            
            ListBox myList = new ListBox();
            myList.Location = new Point(12, 12);
            myList.Size = new Size(245, 200);
            myList.Items.Add("item1");
            myList.Items.Add("item2");
            this.Controls.Add(myList);

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.FullPath.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
           // MessageBox.Show(treeView1.SelectedNode.FullPath.ToString);
        }
    }
}
