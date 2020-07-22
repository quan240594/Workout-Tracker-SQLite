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

namespace Workout_Tracker_SQLite
{
    public partial class Workout_Details : Form
    {
        SQLiteConnection con = new SQLiteConnection(DataAccess.ConString("Default"));
        SQLiteCommand selectWorkout = new SQLiteCommand("SELECT * from [Exercise Details]");
        string rowID = "";
        public Workout_Details()
        {
            InitializeComponent();
        }
        #region Form Load
        private void loadDataGrid()
        {
            try
            {
                selectWorkout.Connection = con;
                con.Open();
                SQLiteDataReader dr = selectWorkout.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                dataGridView1.DataSource = dt;                
            }
            catch (Exception E)
            {
                con.Close();
                MessageBox.Show(E.Message);
            }
            finally { con.Close(); }
        }

        private void Workout_Details_Load(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
            loadDataGrid();
            fillCB();
        }
        #endregion

        #region Check Boxes

        private void chk_Active_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_Active.Checked == true) 
            { 
                chk_Active.Text = "Yes";
            }
            else 
            { 
                chk_Active.Text = "No";
            }
            saveEnable();
        }

        private void chk_Weight_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_Weight.Checked == true) 
            {
                chk_Weight.Text = "Yes"; 
            }
            else 
            { 
                chk_Weight.Text = "No"; 
            }
            saveEnable();
        }

        private void saveEnable()
        {
            if (chk_Weight.Text != "Weight" && chk_Active.Text != "Active")
            {
                btn_Save.Enabled = true;
            }
            else { btn_Save.Enabled = false; }
        }

        #endregion

        #region Tool Strip
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Workout_Model w = new Workout_Model();

                w.Exercise_Name = txt_Workout_name.Text;
                w.Muscle_Group = cb_Muscle_group.Text;
                w.Weight_Required = chk_Weight.Text;
                w.Active = chk_Active.Text;
                w.Day_1 = cb_Day1.Text;
                w.Day_2 = cb_Day2.Text;

                DataAccess.SaveWorkoutDetails(w);
            }
            catch (Exception E) 
            {
                con.Close();
                MessageBox.Show(E.Message); 
            }
            finally { con.Close(); }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        #endregion

        #region Fill Combo Boxes
        private void fillCB()
        {
            fillMuscleGroup();
            fillDay1();
            fillDay2();
            fillWeightType();
        }

        private void fillMuscleGroup()
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT DISTINCT [Muscle_Group] from [Exercise Details] ORDER BY [Muscle_Group]");
                cmd.Connection = con;
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                cb_Muscle_group.DataSource = dt;
                cb_Muscle_group.DisplayMember = "Muscle_Group";
                cb_Muscle_group.ValueMember = "Muscle_Group";
            }

        catch (Exception E)
            {
                con.Close();
                MessageBox.Show(E.Message);
            }
        finally { con.Close(); }
        }

        private void fillDay1()
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Week_Days] ORDER BY [Day_Number]");
                cmd.Connection = con;
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                cb_Day1.DataSource = dt;
                cb_Day1.DisplayMember = "Day_Text";
                cb_Day1.ValueMember = "Day_Number";
            }
            catch (Exception E)
            { 
                con.Close();
                MessageBox.Show(E.Message);
            }
            finally { con.Close(); }
        }

        private void fillDay2()
        {
            try
                {
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Week_Days] ORDER BY [Day_Number]");
                    cmd.Connection = con;
                    con.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    con.Close();
                    cb_Day2.DataSource = dt;
                    cb_Day2.DisplayMember = "Day_Text";
                    cb_Day2.ValueMember = "Day_Number";
                }
                catch (Exception E)
                {
                    con.Close();
                    MessageBox.Show(E.Message);
                }
                finally { con.Close(); }
        }

        private void fillWeightType()
        {
            try
                {
                    SQLiteCommand cmd = new SQLiteCommand("SELECT DISTINCT [Weight_Type] from [Exercise Details] ORDER BY [Muscle_Group]");
                    cmd.Connection = con;
                    con.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    con.Close();
                    cb_Weight_Type.DataSource = dt;
                    cb_Weight_Type.DisplayMember = "Weight_Type";
                    cb_Weight_Type.ValueMember = "Weight_Type";
                }
                catch (Exception E) 
                {
                    con.Close();
                    MessageBox.Show(E.Message);
                }
                finally { con.Close(); }
        }
        #endregion

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM [Exercise Details] WHERE [Exercise_ID] = " + rowID, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            loadDataGrid();
        }
    }
}
