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
        DataTable dt = new DataTable();
        private void FrmAddIngredients_Load(object sender, EventArgs e)
        {
            TxtRecpName.Text = GlobalVariables.RecpName;
            Combo_Load();
            dt.Columns.Add("Name", typeof(String));
            dt.Columns.Add("Ratio", typeof(double));
            dt.Columns.Add("Cost", typeof(Int32));
        }

        private void Combo_Load()
        {
            string loadingre = "SELECT id,name from TblIngredients";
            SQLHelper.ComboFills(loadingre, ComboIngre, "name", "id");
            ComboIngre.Text = "Select Ingredients";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ComboIngre.Text != "Select Ingredients" && TxtProp.Text != "")
            {
                try
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = ComboIngre.SelectedValue;
                    dr[1] = TxtProp.Text;
                    dt.Rows.Add(dr);
                    Button button = new Button();
                    button.Text = ComboIngre.Text;
                    button.Height = 50;
                    button.AutoSize = true;
                    PnlIngre.Controls.Add(button);
                    button.Click += DynamicButton_Click;
                    TxtProp.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void DynamicButton_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Dispose();

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CalculateNutri();
        }

        private void CalculateNutri()
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string getPrice = "select price from TblIngredients WHERE id = '" + dt.Rows[i][0] + "' ";

                double pricepergram = Convert.ToDouble(SQLHelper.getData(getPrice)) / 100;
                //MessageBox.Show((Convert.ToDouble(dt.Rows[i][1]) * pricepergram).ToString());
                dt.Rows[i][2] = Convert.ToDouble(dt.Rows[i][1]) * pricepergram;
            }
            DataRow dr = dt.NewRow();
            dr[0] = "Total";
            int sumObject;
            sumObject = Convert.ToInt32(dt.Compute("Sum(Cost)", ""));
            dr[2] = sumObject;
            dt.Rows.Add(dr);
        }
    }
}
