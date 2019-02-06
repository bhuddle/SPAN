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
    // IPC
    public partial class IcpForm : Form
    {
        bool splno, hrsno;
        StartForm startf;
        public IcpForm(StartForm sf)
        {
            InitializeComponent();
            nochYes.Enabled = false;
            startf = sf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hrsYes.Checked | splYes.Checked)
            {
                ICPEligibleForm icpf = new ICPEligibleForm(startf);
                icpf.MdiParent = this.MdiParent;
                icpf.Dock = DockStyle.Fill;
                icpf.Show();
            }
            if (nochYes.Checked)
            {
                ICPNoChangeForm icpncf = new ICPNoChangeForm(startf);
                icpncf.MdiParent = this.MdiParent;
                icpncf.Dock = DockStyle.Fill;
                icpncf.Show();
            }
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

        private void nochYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nochNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
