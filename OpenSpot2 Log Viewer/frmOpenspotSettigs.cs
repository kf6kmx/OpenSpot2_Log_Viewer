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
using System.Net.NetworkInformation;

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
            ConfigurationSettings.AppSettings.Set("OSPWD", this.txtPassword.Text);
            if (verify_IP(this.txt_IPAddress.Text) == true)
            {
                ConfigurationSettings.AppSettings.Set("OSIP", this.txt_IPAddress.Text);
                MessageBox.Show("Changes Saved");
                this.Close();
            }
            else
            {
                MessageBox.Show("No device at IP:" + Environment.NewLine + this.txt_IPAddress.Text + Environment.NewLine + "Changes not saved!");
            }
        }

        private bool verify_IP(String ip)
        {
            bool verified = false;
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(ip, 1000);
                if (reply != null)
                {
                    Console.WriteLine(
                        "Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : "
                        + reply.Address);
                    //Console.WriteLine(reply.ToString());
                    verified =  true;
                }
            }
            catch
            {
                Console.WriteLine("ERROR: You have Some TIMEOUT issue");
                verified = false;
            }

            return verified;
            Console.ReadKey();
        }
    
}
}
