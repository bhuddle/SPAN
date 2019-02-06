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
    public partial class NoChangeForm : Form
    {
        StartForm startf;
        public NoChangeForm(StartForm sf)
        {
            InitializeComponent();
            sentNo.Checked = false;
            sentYes.Checked = false;
            textBox1.Visible = false;
            startf = sf;
        }

        private void sentYes_CheckedChanged(object sender, EventArgs e)
        {
            if (sentYes.Checked)
            {
                textBox1.Text = "";
                string val = "No SPAN\r\nNo 002N\r\netc.";
                textBox1.Text += val;
                textBox1.Show();
            }
        }

        private void sentNo_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            string val = "Send SPAN\r\nSend 002N\r\netc.";
            textBox1.Text += val;
            textBox1.Show();
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
