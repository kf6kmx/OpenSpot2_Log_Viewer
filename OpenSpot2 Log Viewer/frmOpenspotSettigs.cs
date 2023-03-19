using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace OpenSpot2_Log_Viewer
{
    public partial class frmOpenspotSettigs : Form
    {
        public frmOpenspotSettigs()
        {
            InitializeComponent();
            this.txt_IPAddress.Text = ConfigurationSettings.AppSettings.Get("OSIP");
            this.txtPassword.Text = ConfigurationSettings.AppSettings.Get("OSPWD");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConfigurationSettings.AppSettings.Set("OSIP", this.txt_IPAddress.Text);
            ConfigurationSettings.AppSettings.Set("OSPWD", this.txtPassword.Text);

            MessageBox.Show("Changes Saved");
            this.Close();
        }
    }
}
