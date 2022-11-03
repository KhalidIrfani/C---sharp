using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            dataSet1.WriteXml(string.Format("{0}/data.xml", Application.StartupPath));
            ResourceWriter ren = new ResourceWriter(Application.StartupPath + "/resource.en-US.resources");
            ResourceWriter rde = new ResourceWriter(Application.StartupPath + "/resource.de-DE.resources");
            foreach (DataSet1.LanguageRow row in dataSet1.Language.Rows)
            {
                ren.AddResource(row.ID, row.English);
                rde.AddResource(row.ID, row.German);
            }
            ren.Generate();
            ren.Close();
            rde.Generate();
            rde.Close();

            MessageBox.Show("Successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataSet1.ReadXml(string.Format("{0}/data.xml", Application.StartupPath));
            CultureInfo ci = new CultureInfo("de-DE");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
            ResourceManager rm = ResourceManager.CreateFileBasedResourceManager("resource", Application.StartupPath, null);
            if (rm.GetString("001") != null)

                label1.Text = rm.GetString("001");
        }
    }
}
