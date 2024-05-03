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
        public DataTable dt = new DataTable();
        private void FrmAddIngredients_Load(object sender, EventArgs e)
        {
            TxtRecpName.Text = GlobalVariables.RecpName;
            Combo_Load();
            dt.Columns.Add("Name", typeof(String));
            dt.Columns.Add("Ratio", typeof(double));
            dt.Columns.Add("Calories", typeof(double));
            dt.Columns.Add("Carbohydrates", typeof(double));
            dt.Columns.Add("Sugar", typeof(double));
            dt.Columns.Add("Fat", typeof(double));
            dt.Columns.Add("Saturated_Fat", typeof(double));
            dt.Columns.Add("Protein", typeof(double));
            dt.Columns.Add("Cholesterol", typeof(double));
            dt.Columns.Add("Sodium", typeof(double));
            dt.Columns.Add("Potassium", typeof(double));
            dt.Columns.Add("Fiber", typeof(double));
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
                    dr[0] = ComboIngre.Text;
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
            ComboIngre.Focus();

        }

        private void DynamicButton_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = dt.Rows[i];
                if (dr["Name"] == btn.Text)
                    dr.Delete();
            }
            dt.AcceptChanges();
            btn.Dispose();


        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CalculateNutri();
            FrmCalculated frmCalculated = new FrmCalculated(this);
            this.Close();
            frmCalculated.ShowDialog();

        }

        private void CalculateNutri()
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string getPrice = "select calories, carbohydrates, sugar, fat, saturated_Fat, protein, Cholesterol, sodium,potassium, fiber, price from TblIngredients WHERE name = '" + dt.Rows[i][0] + "' ";
                double calpargram = Convert.ToDouble(SQLHelper.getData(getPrice, 0)) / 100;
                double carpargram = Convert.ToDouble(SQLHelper.getData(getPrice, 1)) / 100;
                double sugarpargram = Convert.ToDouble(SQLHelper.getData(getPrice, 2)) / 100;
                double fatpargram = Convert.ToDouble(SQLHelper.getData(getPrice, 3)) / 100;
                double satfatpargram = Convert.ToDouble(SQLHelper.getData(getPrice, 4)) / 100;
                double proteinpargram = Convert.ToDouble(SQLHelper.getData(getPrice, 5)) / 100;
                double chopargram = Convert.ToDouble(SQLHelper.getData(getPrice, 6)) / 100;
                double sodiumpargram = Convert.ToDouble(SQLHelper.getData(getPrice, 7)) / 100;
                double potassiumpargram = Convert.ToDouble(SQLHelper.getData(getPrice, 8)) / 100;
                double fiberpargram = Convert.ToDouble(SQLHelper.getData(getPrice, 9)) / 100;
                double pricepergram = Convert.ToDouble(SQLHelper.getData(getPrice, 10)) / 100;
                //MessageBox.Show((Convert.ToDouble(dt.Rows[i][1]) * pricepergram).ToString());
                dt.Rows[i][2] = TruncateDouble(Convert.ToDouble(dt.Rows[i][1]) * calpargram, 2);
                dt.Rows[i][3] = TruncateDouble(Convert.ToDouble(dt.Rows[i][1]) * carpargram, 2);
                dt.Rows[i][4] = TruncateDouble(Convert.ToDouble(dt.Rows[i][1]) * sugarpargram, 2);
                dt.Rows[i][5] = TruncateDouble(Convert.ToDouble(dt.Rows[i][1]) * fatpargram, 2);
                dt.Rows[i][6] = TruncateDouble(Convert.ToDouble(dt.Rows[i][1]) * satfatpargram, 2);
                dt.Rows[i][7] = TruncateDouble(Convert.ToDouble(dt.Rows[i][1]) * proteinpargram, 2);
                dt.Rows[i][8] = TruncateDouble(Convert.ToDouble(dt.Rows[i][1]) * chopargram, 2);
                dt.Rows[i][9] = TruncateDouble(Convert.ToDouble(dt.Rows[i][1]) * sodiumpargram, 2);
                dt.Rows[i][10] = TruncateDouble(Convert.ToDouble(dt.Rows[i][1]) * potassiumpargram, 2);
                dt.Rows[i][11] = TruncateDouble(Convert.ToDouble(dt.Rows[i][1]) * fiberpargram, 2);
                dt.Rows[i][12] = TruncateDouble(Convert.ToDouble(dt.Rows[i][1]) * pricepergram, 2);
            }
            DataRow dr = dt.NewRow();
            dr[0] = "Total";
            dr[2] = Convert.ToInt32(dt.Compute("Sum(Calories)", ""));
            dr[3] = Convert.ToInt32(dt.Compute("Sum(Carbohydrates)", ""));
            dr[4] = Convert.ToInt32(dt.Compute("Sum(Sugar)", ""));
            dr[5] = Convert.ToInt32(dt.Compute("Sum(Fat)", ""));
            dr[6] = Convert.ToInt32(dt.Compute("Sum(Saturated_Fat)", ""));
            dr[7] = Convert.ToInt32(dt.Compute("Sum(Protein)", ""));
            dr[8] = Convert.ToInt32(dt.Compute("Sum(Cholesterol)", ""));
            dr[9] = Convert.ToInt32(dt.Compute("Sum(Sodium)", ""));
            dr[10] = Convert.ToInt32(dt.Compute("Sum(Potassium)", ""));
            dr[11] = Convert.ToInt32(dt.Compute("Sum(Fiber)", ""));
            dr[12] = Convert.ToInt32(dt.Compute("Sum(Cost)", ""));
            dt.Rows.Add(dr);
            GlobalVariables.csvName = TxtRecpName.Text;
        }
        public double TruncateDouble(double value, int precision)
        {
            double multiplier = Math.Pow(10, precision);
            double result = Math.Truncate(multiplier * value) / multiplier;
            return result;
        }
    }
}
