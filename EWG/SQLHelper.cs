using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Drawing;

namespace EWG
{
    public class SQLHelper
    {
        public static SQLiteConnection con = new SQLiteConnection(@"data source = Database\EWGDB.db");
        public static SQLiteCommand cmd;
        public static DataSet dsDyn = new DataSet();
        public static DataTable dtDyn = new DataTable();

        public static void ExeQuery(string query)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public static void dgView_Load(string query, DataGridView dgv)
        {
            dgv.Rows.Clear();
            SQLiteDataAdapter adp = new SQLiteDataAdapter();
            DataSet ds = new DataSet();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            adp.SelectCommand = cmd;
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[i].Cells[0].Value = i + 1;
                    for (int c = 1; c < dt.Columns.Count + 1; c++)
                    {
                        dgv.Rows[i].Cells[c].Value = dt.Rows[i][c - 1].ToString();
                    }
                }
            }
            else
            {
                return;
            }
            dgv.ClearSelection();
        }

        public static void InsertQuery(string query, string[] arr1, object[] arr2)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            for (int i = 0; i < arr1.Length; i++)
            {
                cmd.Parameters.AddWithValue(arr1[i], arr2[i]);
            }
            cmd.ExecuteNonQuery();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }



        public static void ComboFills(string query, ComboBox cbox2, string DiscolName, string ValColName)
        {
            try
            {
                DataTable dt = new DataTable();
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                SQLiteDataAdapter adap = new SQLiteDataAdapter();
                adap.SelectCommand = cmd;
                adap.Fill(dt);
                cbox2.DisplayMember = DiscolName;
                cbox2.ValueMember = ValColName;
                cbox2.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }

}
