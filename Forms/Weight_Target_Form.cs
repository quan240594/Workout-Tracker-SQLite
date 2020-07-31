using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workout_Tracker_SQLite.Data_Models;

namespace Workout_Tracker_SQLite.Forms
{
    public partial class Weight_Target_Form : Form
    {
        SQLiteConnection con = new SQLiteConnection(DataAccess.ConString("Default"));
        string rowID = "";

        public Weight_Target_Form()
        {
            InitializeComponent();
        }

        private void Weight_Target_Form_Load(object sender, EventArgs e)
        {
            fillCB();
            loadGrid();
        }

        private void fillCB()
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

        private void loadGrid()
        {
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("Select t.[ID], [Full_Name], [Year], [Target] from [Yearly_Weight_Target] t, [Person] p where p.[Person_ID] = t.[Person_ID] ORDER BY [YEAR] DESC, Full_Name ASC", con);
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            fillCB();
            loadGrid();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Weight_Target_Model t = new Weight_Target_Model();
            t.Person_ID = Int32.Parse(cb_Person.SelectedValue.ToString());
            t.Year = Int32.Parse(txt_Year.Text);
            t.Target = Convert.ToDouble(txt_Target.Text);

            DataAccess.SaveWeightTarget(t);

            fillCB();
            loadGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM [Yearly_Weight_Target] WHERE ID = " + rowID, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            loadGrid();
        }
    }
}
