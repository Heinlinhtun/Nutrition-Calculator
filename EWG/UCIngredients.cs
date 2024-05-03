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
        int editmode = 0; //0 to add , 1 to edit;
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
            TxtCholes.Text = "";
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
            TxtPrice.Text = "";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtName.Text != "" && ComboCat.Text != "Select Categories")
                {
                    if (editmode == 0)
                    {
                        string query = "INSERT INTO TblIngredients (name,catid,calories, carbohydrates,sugar, fat, saturated_Fat, protein,cholesterol,sodium, potassium, fiber, price) Values (@name,@catid, @calories, @carbohydrates,@sugar,@fat,@satfat,@protein,@cholesterol, @sodium, @potassium, @fiber,@price)";
                        string[] varArr = { "@name", "@catid", "@calories", "@carbohydrates", "@sugar", "@fat", "@satfat", "@protein", "@cholesterol", "@sodium", "@potassium", "@fiber", "@price" };
                        object[] datArr = { TxtName.Text, ComboCat.SelectedValue, TxtCalories.Text, TxtCarbohyd.Text, TxtSugar.Text, TxtFat.Text, TxtSatFat.Text, TxtProtein.Text, TxtCholes.Text, TxtSodium.Text, TxtPotass.Text, TxtFibre.Text, TxtPrice.Text };
                        SQLHelper.InsertAndUpdateQuery(query, varArr, datArr);
                    }
                    else
                    {
                        string query = "UPDATE TblIngredients SET name = @name, catid= @catid, calories= @calories, carbohydrates = @carbohydrates, sugar = @sugar, fat=@fat, saturated_Fat = @satfat, protein = @protein, cholesterol =@cholesterol, sodium=@sodium, potassium = @potassium, fiber =@fiber, price =@price WHERE name = '" + DGIngredients.CurrentRow.Cells[1].Value.ToString() + "' ";
                        string[] varArr = { "@name", "@catid", "@calories", "@carbohydrates", "@sugar", "@fat", "@satfat", "@protein", "@cholesterol", "@sodium", "@potassium", "@fiber", "@price" };
                        object[] datArr = { TxtName.Text, ComboCat.SelectedValue, TxtCalories.Text, TxtCarbohyd.Text, TxtSugar.Text, TxtFat.Text, TxtSatFat.Text, TxtProtein.Text, TxtCholes.Text, TxtSodium.Text, TxtPotass.Text, TxtFibre.Text, TxtPrice.Text };
                        SQLHelper.InsertAndUpdateQuery(query, varArr, datArr);
                    }
                    editmode = 0;
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
            string loadDG;
            if (TxtSearch.Text != "")
            {
                loadDG = "SELECT TblIngredients.name, TblCategories.name as CatName, TblIngredients.calories, TblIngredients.carbohydrates, TblIngredients.sugar, TblIngredients.fat, TblIngredients.saturated_Fat, TblIngredients.protein, TblIngredients.cholesterol, TblIngredients.sodium, TblIngredients.potassium,TblIngredients.fiber,TblIngredients.price From TblIngredients INNER JOIN TblCategories ON TblIngredients.catid= TblCategories.id WHERE TblIngredients.name LIKE '%" + TxtSearch.Text + "%' ";
            }
            else
            {
                loadDG = "SELECT TblIngredients.name, TblCategories.name as CatName, TblIngredients.calories, TblIngredients.carbohydrates, TblIngredients.sugar, TblIngredients.fat, TblIngredients.saturated_Fat, TblIngredients.protein, TblIngredients.cholesterol, TblIngredients.sodium, TblIngredients.potassium,TblIngredients.fiber,TblIngredients.price From TblIngredients INNER JOIN TblCategories ON TblIngredients.catid= TblCategories.id ";
            }

            SQLHelper.dgView_Load(loadDG, DGIngredients);

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Load_dg();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGIngredients.SelectedRows.Count != 0)
            {
                var result = MessageBox.Show("Do you want to delete this item?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    string query = "DELETE FROM TblIngredients WHERE name = '" + DGIngredients.CurrentRow.Cells[1].Value.ToString() + "'";
                    SQLHelper.ExeQuery(query);
                    Load_dg();
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editmode = 1;
            TxtName.Text = DGIngredients.CurrentRow.Cells[1].Value.ToString();
            ComboCat.Text = DGIngredients.CurrentRow.Cells[2].Value.ToString();
            TxtCalories.Text = DGIngredients.CurrentRow.Cells[3].Value.ToString();
            TxtCarbohyd.Text = DGIngredients.CurrentRow.Cells[4].Value.ToString();
            TxtSugar.Text = DGIngredients.CurrentRow.Cells[5].Value.ToString();
            TxtFat.Text = DGIngredients.CurrentRow.Cells[6].Value.ToString();
            TxtSatFat.Text = DGIngredients.CurrentRow.Cells[7].Value.ToString();
            TxtProtein.Text = DGIngredients.CurrentRow.Cells[8].Value.ToString();
            TxtCholes.Text = DGIngredients.CurrentRow.Cells[9].Value.ToString();
            TxtSodium.Text = DGIngredients.CurrentRow.Cells[10].Value.ToString();
            TxtPotass.Text = DGIngredients.CurrentRow.Cells[11].Value.ToString();
            TxtFibre.Text = DGIngredients.CurrentRow.Cells[12].Value.ToString();
            TxtPrice.Text = DGIngredients.CurrentRow.Cells[13].Value.ToString();
        }
    }
}
