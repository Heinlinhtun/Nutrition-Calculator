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
    public partial class FrmAddCategory : Form
    {
        private UCRecp _receipt;
        public FrmAddCategory(UCRecp receipt)
        {
            InitializeComponent();
            _receipt = receipt;
        }

        private void FrmAddCategory_Load(object sender, EventArgs e)
        {
            this.ComboCatType.SelectedIndex = 0;
            Load_DG();
            BtnDel.Enabled = false;
        }

        private void BtnSaveCat_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCatName.Text != "")
                {
                    string query = "INSERT INTO TblCategories (name,Type ) Values (@name, @type)";
                    string[] varArr = { "@name", "@type" };
                    object[] datArr = { TxtCatName.Text, ComboCatType.SelectedIndex };
                    SQLHelper.InsertAndUpdateQuery(query, varArr, datArr);
                    _receipt.comboLoad();
                    Load_DG();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Duplicated Category names or other errors!");
            }
        }

        private void Load_DG()
        {
            TxtCatName.Text = "";
            string loadDG = "SELECT name, Type From TblCategories WHERE Type = '" + ComboCatType.SelectedIndex + "' ";
            SQLHelper.dgView_Load(loadDG, DGCategories);
            foreach (DataGridViewRow row in DGCategories.Rows)
            {
                if (ComboCatType.SelectedIndex == 0)
                {
                    row.Cells[2].Value = "Receipt Category";
                }
                else if (ComboCatType.SelectedIndex == 1)
                {
                    row.Cells[2].Value = "Ingredients Category";
                }
            }

        }

        private void DGCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCatName.Text = DGCategories.CurrentRow.Cells[1].Value.ToString();
            ComboCatType.Text = DGCategories.CurrentRow.Cells[2].Value.ToString();
            BtnDel.Enabled = true;
        }

        private void ComboCatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_DG();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (TxtCatName.Text != "")
            {
                var result = MessageBox.Show("Do you want to delete this item?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE from TblCategories Where name = '" + TxtCatName.Text + "'";
                    SQLHelper.ExeQuery(query);
                    TxtCatName.Text = "";
                    Load_DG();
                }
            }
            else
            {
                MessageBox.Show("Select an Item!");
            }

        }
    }
}
