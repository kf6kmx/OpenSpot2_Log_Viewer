namespace OpenSpot2_Log_Viewer
{
    using System;
    using System.Windows.Forms;

    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            this.InitializeComponent();
            this.textBox1.Text = this.textBox1.Text + Environment.NewLine + Application.ProductVersion;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}