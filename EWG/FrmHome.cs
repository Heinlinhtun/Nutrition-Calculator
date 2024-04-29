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
            Load_UC();
        }

        private void BtnIngred_Click(object sender, EventArgs e)
        {
            UCIngredients uCRecp = new UCIngredients();
            uCRecp.Dock = DockStyle.Fill;
            PnlContainer.Controls.Clear();
            PnlContainer.Controls.Add(uCRecp);
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            Load_UC();
        }

        private void Load_UC()
        {
            UCRecp uCRecp = new UCRecp();
            uCRecp.Dock = DockStyle.Fill;
            PnlContainer.Controls.Clear();
            PnlContainer.Controls.Add(uCRecp);
        }
    }
}
