using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace new_form
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            UserControl1.SelectedIdexChanged += new EventHandler(myCombobox_SelectedIdexChanged);
        }

        void myCombobox_SelectedIdexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(UserControl1.SlectedText);
        }

        private void btnDropdownSelectedvalue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserControl1.Selectedvalue.ToString());
        }

        private void btnDropDownSelectedText_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserControl1.SlectedText);
        }
    }
}
