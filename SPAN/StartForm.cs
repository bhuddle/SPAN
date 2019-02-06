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
    //Start Form
    public partial class StartForm : Form
    {
        string selection;
        public StartForm()
        {
            InitializeComponent();
        }

        private void programComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection = programComboBox.SelectedItem.ToString();
            Debug.WriteLine("program selected: "+selection);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*foreach (Form fm in Application.OpenForms)
            {
                Debug.WriteLine("Open Form: " + fm.Name);
            }*/
            if (selection == "IN-HOME")
            {
                InHomeForm ihf = new InHomeForm(this);
                ihf.MdiParent = this.ParentForm;
                ihf.Dock = DockStyle.Fill;
                ihf.Show();
            }
            if (selection == "IN-HOME PACE")
            {
                InHomePaceForm ihpf = new InHomePaceForm(this);
                ihpf.MdiParent = this.ParentForm;
                ihpf.Dock = DockStyle.Fill;
                ihpf.Show();
            }
            if (selection == "CBC PACE")
            {
                CbcPaceForm cbcp = new CbcPaceForm();
                cbcp.MdiParent = this.ParentForm;
                cbcp.Dock = DockStyle.Fill;
                cbcp.Show();
            }
            if (selection == "ICP")
            {
                IcpForm icp = new IcpForm(this);
                icp.MdiParent = this.ParentForm;
                icp.Dock = DockStyle.Fill;
                icp.Show();
            }
            if (selection == "NFC")
            {
                NfcForm nfc = new NfcForm();
                nfc.MdiParent = this.ParentForm;
                nfc.Dock = DockStyle.Fill;
                nfc.Show();
            }
            if (selection == "CBC")
            {
                CbcForm cbc = new CbcForm();
                cbc.MdiParent = this.ParentForm;
                cbc.Dock = DockStyle.Fill;
                cbc.Show();
            }
        }
    }
}
