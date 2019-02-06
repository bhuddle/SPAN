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
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            //base.OnLoad(e);
            //this.Location = Owner.Location;
            //this.Size = Owner.Size;
            StartForm sf = new StartForm();
            sf.MdiParent = this;
            sf.Dock = DockStyle.Fill;
            sf.Show();
        }
    }
}
