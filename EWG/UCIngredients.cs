using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EWG
{
    public partial class UCIngredients : UserControl
    {
        public UCIngredients()
        {
            InitializeComponent();
        }

        public void LoadCombo()
        {
            string query = "SELECT id ,name  from TblCategories WHERE Type = 1";
            SQLHelper.ComboFills(query, ComboCat, "name", "id");
            ComboCat.Text = "Select Categories";
        }

        private void UCIngredients_Load(object sender, EventArgs e)
        {
            LoadCombo();
            Load_dg();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClrTxt();
        }

        private void TxtBox_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void ClrTxt()
        {
            TxtName.Text = "";
            TxtCalories.Text = "";
            TxtCarbohyd.Text = "";
            TxtFat.Text = "";
            TxtFibre.Text = "";
            TxtPotass.Text = "";
            TxtProtein.Text = "";
            TxtSatFat.Text = "";
            TxtSodium.Text = "";
            TxtSugar.Text = "";
            ComboCat.Text = "Select Categories";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtName.Text != "")
                {
                    string query = "INSERT INTO TblIngredients (name,catid,calories, carbohydrates,sugar, fat, saturated_Fat, protein,cholesterol,sodium, potassium, fiber, price) Values (@name,@catid, @calories, @carbohydrates,@sugar,@fat,@satfat,@protein,@cholesterol, @sodium, @potassium, @fiber,@price)";
                    string[] varArr = { "@name", "@catid", "@calories", "@carbohydrates", "@sugar", "@fat", "@satfat", "@protein","@cholesterol", "@sodium", "@potassium", "@fiber", "@price" };
                    object[] datArr = { TxtName.Text, ComboCat.SelectedValue, TxtCalories.Text, TxtCarbohyd.Text, TxtSugar.Text, TxtFat.Text, TxtSatFat.Text, TxtProtein.Text,TxtCholes.Text, TxtSodium.Text, TxtPotass.Text, TxtFibre.Text, TxtPrice.Text };
                    SQLHelper.InsertQuery(query, varArr, datArr);
                    ClrTxt();
                    Load_dg();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Load_dg()
        {
            string loadDG = "SELECT TblIngredients.name, TblCategories.name as CatName, TblIngredients.calories, TblIngredients.carbohydrates, TblIngredients.sugar, TblIngredients.fat, TblIngredients.saturated_Fat, TblIngredients.protein, TblIngredients.cholesterol, TblIngredients.sodium, TblIngredients.potassium,TblIngredients.fiber,TblIngredients.price From TblIngredients INNER JOIN TblCategories ON TblIngredients.catid= TblCategories.id ";
            SQLHelper.dgView_Load(loadDG, DGIngredients);

        }
    }
}
