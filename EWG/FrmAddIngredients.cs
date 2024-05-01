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
    public partial class FrmAddIngredients : Form
    {

        public FrmAddIngredients()
        {
            InitializeComponent();
        }


        private void FrmAddIngredients_Load(object sender, EventArgs e)
        {
            TxtRecpName.Text = GlobalVariables.RecpName;
            Combo_Load();
        }

        private void Combo_Load()
        {
            string loadingre = "SELECT name from TblIngredients";
            SQLHelper.ComboFills(loadingre, ComboIngre, "name", "name");
            ComboIngre.Text = "Select Ingredients";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(String));
            dt.Columns.Add("ratio", typeof(double));
            DataRow dr = dt.NewRow();
            dr[0] = ComboIngre.Text;
            dr[1] = TxtProp.Text;
            Button button = new Button();
            button.Text = dr[0].ToString();
            button.Height = 50;
            button.AutoSize = true;
            PnlIngre.Controls.Add(button);
            button.Click += DynamicButton_Click;
            TxtProp.Text = "";
        }

        private void DynamicButton_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Dispose();

        }
    }
}
