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
    public partial class FrmCalculated : Form
    {
        private FrmAddIngredients _addIngredients;
        public FrmCalculated(FrmAddIngredients addIngredients)
        {
            InitializeComponent();
            _addIngredients = addIngredients;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCalculated_Load(object sender, EventArgs e)
        {
            DGBind();
            this.Text = "Nutrition Facts: " + GlobalVariables.csvName + "";
        }
        private void DGBind()
        {
            DGCalculated.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (_addIngredients.dt.Rows.Count != 0)
            {
                for (int i = 0; i < _addIngredients.dt.Rows.Count; i++)
                {
                    DGCalculated.Rows.Add();
                    DGCalculated.Rows[i].Cells[0].Value = i + 1;
                    for (int c = 1; c < _addIngredients.dt.Columns.Count + 1; c++)
                    {
                        DGCalculated.Rows[i].Cells[c].Value = _addIngredients.dt.Rows[i][c - 1].ToString();
                    }
                }
            }
        }

        public void ExportDataGridViewToCSV()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = GlobalVariables.csvName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                {
                    // Write the header
                    for (int i = 0; i < DGCalculated.Columns.Count; i++)
                    {
                        sw.Write(DGCalculated.Columns[i].HeaderText);
                        if (i < DGCalculated.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();

                    // Write the data
                    for (int i = 0; i < DGCalculated.Rows.Count; i++)
                    {
                        for (int j = 0; j < DGCalculated.Columns.Count; j++)
                        {
                            string value = DGCalculated.Rows[i].Cells[j].Value.ToString();
                            // Check if the value contains a comma and place it in quotes if it does
                            if (value.Contains(","))
                                sw.Write("\"" + value + "\"");
                            else
                                sw.Write(value);

                            if (j < DGCalculated.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportDataGridViewToCSV();
        }
    }
}
