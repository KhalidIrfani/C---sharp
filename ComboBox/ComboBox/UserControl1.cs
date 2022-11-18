using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class UserControl1: UserControl
    {
        public String SlectedText
        {
            get { return comboBox1.Text; }
        }

        public String SelectedValue
        {
            get   {
                return comboBox1.SelectedValue.ToString();

            }
        }
        public event EventHandler SelectedIdexChanged;


        public UserControl1()
        {
            InitializeComponent();
            this.Load += new EventHandler(UserControl1_Load);
            this.comboBox1.SelectedIndexChanged += new EventHandler (comboBox1_SelectedIndexChanged);
        }

         void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectedIdexChanged!=null)
                SelectedIdexChanged(sender, e);
        }
        void UserControl1_Load(object sender, EventArgs e)
        {
            BindComboBox();
        }
        private void BindComboBox()
        {
            DataTable dtState = new System.Data.DataTable();
            dtState.Columns.Add("txtPart");
            dtState.Columns.Add("ValuePart");
            dtState.Rows.Add("Delhi", "1");
            dtState.Rows.Add("Bihar", "2");
            dtState.Rows.Add("Punjab", "3");
            dtState.Rows.Add("UP", "4");
            comboBox1.DataSource = dtState;
            comboBox1.DisplayMember = "txtPart";
            comboBox1.ValueMember = "ValuePart";


        }

        private void UserControl1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
