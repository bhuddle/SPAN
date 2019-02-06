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
    // In Home Form
    public partial class InHomeForm : Form
    {
        bool splno;
        bool hrsno;
        StartForm startf;
        public InHomeForm(StartForm sf)
        {
            InitializeComponent();
            nochYes.Enabled = false;
            startf = sf;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splYes_CheckedChanged(object sender, EventArgs e)
        {
            splno = splNo.Checked;
            if (splno && hrsno)
            {
                nochYes.Enabled = true;
            }
            else
            {
                nochYes.Enabled = false;
                nochYes.Checked = false;
            }
        }

        private void nochYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hrsYes_CheckedChanged(object sender, EventArgs e)
        {
            hrsno = hrsNo.Checked;
            if (splno && hrsno)
            {
                nochYes.Enabled = true;
            }
            else
            {
                nochYes.Enabled = false;
                nochYes.Checked = false;
            }
        }

        private void splNo_CheckedChanged(object sender, EventArgs e)
        {
            splno = splNo.Checked;
            if (splno && hrsno)
            {
                nochYes.Enabled = true;
            }
            else
            {
                nochYes.Enabled = false;
                nochYes.Checked = false;
            }
        }

        private void hrsNo_CheckedChanged(object sender, EventArgs e)
        {
            hrsno = hrsNo.Checked;
            if (splno && hrsno)
            {
                nochYes.Enabled = true;
            }
            else
            {
                nochYes.Enabled = false;
                nochYes.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hrsYes.Checked | splYes.Checked)
            {
                IHEligibleForm ihef = new IHEligibleForm(startf);
                ihef.MdiParent = this.MdiParent;
                ihef.Dock = DockStyle.Fill;
                ihef.Show();
            }
            if (nochYes.Checked)
            {
                NoChangeForm nchfm = new NoChangeForm(startf);
                nchfm.MdiParent = this.MdiParent;
                nchfm.Dock = DockStyle.Fill;
                nchfm.Show();
            }
            
        }
    }
}
