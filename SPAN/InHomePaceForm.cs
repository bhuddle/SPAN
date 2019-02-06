using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPAN
{
    // IN-HOME PACE
    public partial class InHomePaceForm : Form
    {
        StartForm startf;
        public InHomePaceForm(StartForm sf)
        {
            InitializeComponent();
            splNo.Checked = true;
            splYes.Checked = false;
            nochNo.Checked = true;
            nochYes.Checked = false;
            textBox1.Visible = false;
            startf = sf;
        }

        private void splYes_CheckedChanged(object sender, EventArgs e)
        {
            if (splYes.Checked)
            {
                textBox1.Visible = false;
                nochNo.Checked = true;
            }
            if (nochNo.Checked && splNo.Checked)
            {
                textBox1.Visible = false;
            }
        }

        private void nochYes_CheckedChanged(object sender, EventArgs e)
        {
            if(nochYes.Checked)
            {
                textBox1.Text = "";
                textBox1.Text += "NO SPAN\r\nSEND SERVICE PLAN AGREEMENT\r\netc.";
                textBox1.Show();
                splNo.Checked = true;
            }
            if (nochNo.Checked && splNo.Checked)
            {
                textBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IHPEligibleForm ihpe = new IHPEligibleForm(startf);
            ihpe.MdiParent = this.ParentForm;
            ihpe.Dock = DockStyle.Fill;
            ihpe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
