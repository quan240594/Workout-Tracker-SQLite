using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workout_Tracker_SQLite
{
    public partial class DataForm : Form
    {
        #region Variables

        SQLiteConnection con = new SQLiteConnection(DataAccess.ConString("Default"));

        int pID = 0;
        int eID = 0;
        string gridQuery = "Select [ID], [Date], [Exercise_Name], [Full_Name], [Total_Sets], [Total_Reps], [Average_Reps], [Average_Weight], " +
                "[S1_Reps], [S2_Reps], [S3_Reps], [S4_Reps], [S5_Reps], [S6_Reps], [S7_Reps], [S8_Reps], " +
                "[S1_Weight], [S2_Weight], [S3_Weight], [S4_Weight], [S5_weight], [S6_Weight], [S7_Weight], [S8_Weight] " +
                "FROM [Daily Progress] dp, [Exercise Details] ed, [Person] p where ([dp].[Exercise_ID] = [ed].[Exercise_ID] AND [p].[Person_ID] = [dp].[Person_ID] "; 
        
        string gQuery_Person_Filter = "AND [p].[Person_ID] = ";
        string gQuery_Exercise_Filter = "AND [ed].[Exercise_ID] = ";

        string orderQuery = ") ORDER BY [Date] DESC";

        string rowID = "";
        #endregion
        public DataForm()
        {
            InitializeComponent();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            gridLoad();
            fillCB();
        }

        private void gridLoad()
        {            
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(gridQuery + orderQuery, con);
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                dataGridView_DailyProgress.DataSource = dt;
            }
        }

        private void fillCB()
        {
            fillCB_Person();
            fillcb_Exercise();
        }
        private void fillCB_Person()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * from [Person] ORDER BY [Full_Name]", con);
            con.Open();
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                cb_Person.DataSource = dt;
                cb_Person.DisplayMember = "Full_Name";
                cb_Person.ValueMember = "Person_ID";
            }            
        }

        private void fillcb_Exercise()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * from [Exercise Details] ORDER BY [Exercise_Name]", con);
            con.Open();
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                cb_Exercise.DataSource = dt;
                cb_Exercise.DisplayMember = "Exercise_Name";
                cb_Exercise.ValueMember = "Exercise_ID";
            }            
        }

        private void btn_Filter_Person_Click(object sender, EventArgs e)
        {
            pID = Int32.Parse(cb_Person.SelectedValue.ToString());
            SQLiteCommand cmd = new SQLiteCommand(gridQuery + gQuery_Person_Filter + pID + orderQuery, con);
            con.Open();
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                dataGridView_DailyProgress.DataSource = dt;
            }
        }

        private void btn_Filter_Exercise_Click(object sender, EventArgs e)
        {
            eID = Int32.Parse(cb_Exercise.SelectedValue.ToString());
            SQLiteCommand cmd = new SQLiteCommand(gridQuery + gQuery_Exercise_Filter + eID + orderQuery, con);
            con.Open();
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                dataGridView_DailyProgress.DataSource = dt;
            }
        }


        public void btn_ClearFilters_Click(object sender, EventArgs e)
        {
            gridLoad();
            fillCB();
        }

        private void btn_FilterAll_Click(object sender, EventArgs e)
        {
            pID = Int32.Parse(cb_Person.SelectedValue.ToString());
            eID = Int32.Parse(cb_Exercise.SelectedValue.ToString());
            SQLiteCommand cmd = new SQLiteCommand(gridQuery + gQuery_Person_Filter + pID + " " +gQuery_Exercise_Filter + eID + orderQuery, con);
            con.Open();
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                dataGridView_DailyProgress.DataSource = dt;
            }
        }

        private void dataGridView_DailyProgress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowID = dataGridView_DailyProgress.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM [DAILY PROGRESS] WHERE ID = " + rowID, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            gridLoad();
        }
    }
}
