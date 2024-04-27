using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EWG
{
    public partial class UCRecp : UserControl
    {
        public UCRecp()
        {
            InitializeComponent();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmAddCategory addCategory = new FrmAddCategory(this);
            addCategory.ShowDialog();
        }

        private void UCRecp_Load(object sender, EventArgs e)
        {
            comboLoad();
        }

        public void comboLoad()
        {
            string query = "SELECT name from TblCategories";
            SQLHelper.ComboFills(query, ComboCat, "name", "name");
            ComboCat.Text = "Categories";
        }
    }
}
