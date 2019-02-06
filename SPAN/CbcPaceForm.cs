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
    // CBC PACE
    public partial class CbcPaceForm : Form
    {
        public CbcPaceForm()
        {
            InitializeComponent();
            textBox1.Visible = false;
            elgNo.Checked = elgYes.Checked = false;
            nochNo.Checked = nochYes.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void elgYes_CheckedChanged(object sender, EventArgs e)
        {
            if (elgYes.Checked)
            {
                textBox1.Text = "SEND SPAN\r\n002N\r\netc.";
                nochNo.Checked = nochYes.Checked = false;
                textBox1.Show();
            }
        }

        private void elgNo_CheckedChanged(object sender, EventArgs e)
        {
            if (elgNo.Checked)
            {
                textBox1.Text = "REVIEW EWE OR OTHER PROGRAM ELIGIBILITY\r\netc.";
                nochNo.Checked = nochYes.Checked = false;
                textBox1.Show();
            }
        }

        private void nochYes_CheckedChanged(object sender, EventArgs e)
        {
            if (nochYes.Checked)
            {
                textBox1.Text = "NO SPAN";
                elgYes.Checked = elgNo.Checked = false;
                textBox1.Show();
            }
        }

        private void nochNo_CheckedChanged(object sender, EventArgs e)
        {
            if(nochNo.Checked)
            {
                elgYes.Checked = elgNo.Checked = false;
                textBox1.Visible = false;
            }
        }
    }
}
