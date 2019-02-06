using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SPAN
{
    public partial class ICPEligibleForm : Form
    {
        StartForm startf;
        public ICPEligibleForm(StartForm sf)
        {
            InitializeComponent();
            splYes.Checked = false;
            splNo.Checked = false;
            textBox1.Hide();
            startf = sf;
        }

        private void splYes_CheckedChanged(object sender, EventArgs e)
        {
            if (splYes.Checked == true)
            {
                textBox1.Text = "";
                string val = "Send SPAN\r\n002N\r\netc.\r\nADD NEW FORMS";
                textBox1.Text += val;
                textBox1.Show();
            }
            
        }

        private void splNo_CheckedChanged(object sender, EventArgs e)
        {
            if (splNo.Checked == true)
            {
                textBox1.Text = "";
                string val2 = "Send SPAN\r\n002N\r\nEvaluate EWE, SPPC, OPI, etc.\r\nADD NEW FORMS";
                textBox1.Text += val2;
                textBox1.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            startf.Focus();
            List<Form> lf = new List<Form>();
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name != "StartForm")
                {
                    lf.Add(fm);
                }
            }
            foreach (Form f in lf)
            {
                f.Close();
            }
        }
    }
}
