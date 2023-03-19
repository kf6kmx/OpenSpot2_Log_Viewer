using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OpenSpot2_Log_Viewer.openspot;
using static OpenSpot2_Log_Viewer.radioid;

namespace OpenSpot2_Log_Viewer
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void deviceIPAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpenspotSettigs frm = new frmOpenspotSettigs();
            frm.ShowDialog();
        }

        private void txtRadioIDCallsign_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRadioIDName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDMRLookup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lookup data for ID" + Environment.NewLine + this.txtDMRLookupID.Text);
        }
    }
}
