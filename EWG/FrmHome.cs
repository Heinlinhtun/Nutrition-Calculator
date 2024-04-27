namespace EWG
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            UCRecp uCRecp = new UCRecp();
            uCRecp.Dock = DockStyle.Fill;
            PnlContainer.Controls.Clear();
            PnlContainer.Controls.Add(uCRecp);
        }

        private void BtnIngred_Click(object sender, EventArgs e)
        {

        }
    }
}
