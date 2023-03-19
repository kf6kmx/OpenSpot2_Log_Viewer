namespace OpenSpot2_Log_Viewer
{
    using System;
    using System.Windows.Forms;

    public partial class about : Form
    {
        public about()
        {
            this.InitializeComponent();
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