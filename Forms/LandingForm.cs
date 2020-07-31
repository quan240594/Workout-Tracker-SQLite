using Dapper;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workout_Tracker_SQLite.Forms;

namespace Workout_Tracker_SQLite
{
    public partial class LandingForm : Form
    {
        #region Variable Declaration
        SQLiteConnection con = new SQLiteConnection(DataAccess.ConString("Default"));
        IDbConnection cn = new SQLiteConnection(DataAccess.ConString("Default"));
        string wd = "";
        SQLiteCommand selectExcersie =new SQLiteCommand( "SELCT * from [Exercise Details]");
        int ttl_Sets = 0;
        int ttl_Reps = 0;
        double avg_Reps = 0;
        double avg_Weight = 0;
        double ttl_weight = 0;
        int streak = 0;
        #endregion

        #region Load Form
        public LandingForm()
        {
            InitializeComponent();            
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {         
            fillCB();
            reset();
        }

        private void fillCB()
        {
            fillCB_Person();
            fillCB_Workout();
        }

        private void fillCB_Person()
        {
            using (cn)
            {
                SQLiteCommand cmd = new SQLiteCommand("Select * from [Person] ORDER BY [Full_Name]");
                cmd.Connection = con;
                con.Open();
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    con.Close();
                    cb_Person_Name.DataSource = dt;
                    cb_Person_Name.DisplayMember = "Full_Name";
                    cb_Person_Name.ValueMember = "Person_ID";
                }
            }
        }

        private void fillCB_Workout()
        {
            using (cn)
            {
                SQLiteCommand cmd = new SQLiteCommand("Select * from [Exercise Details] ORDER BY [Exercise_Name]");
                cmd.Connection = con;
                con.Open();
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    con.Close();
                    cb_Workout_Name.DataSource = dt;
                    cb_Workout_Name.DisplayMember = "Exercise_Name";
                    cb_Workout_Name.ValueMember = "Exercise_ID";
                }
            }
        }

        private void filter_CB_Workout()
        {
            wd = dateTimePicker1.Value.DayOfWeek.ToString();
            cb_Person_Name.Enabled = true;
            using (cn)
            {
                SQLiteCommand cmd = new SQLiteCommand("Select * from[Exercise Details] where[Day_1] like '" + wd + "' or[Day_2] like '" + wd + "' Order by[Exercise_Name]", con);
                cmd.Connection = con;
                con.Open();
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    con.Close();
                    cb_Workout_Name.DataSource = dt;
                    cb_Workout_Name.DisplayMember = "Exercise_Name";
                    cb_Workout_Name.ValueMember = "Exercise_ID";
                }
            }
        }


        #endregion

        #region Tool Strip Buttons' functions

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                streak = Int32.Parse(txt_Total_Days.Text) + 1;
                SQLiteCommand cmd = new SQLiteCommand("UPDATE [Person] SET [Workout_Days] = " + streak.ToString() + " WHERE [Person_ID] = " + cb_Person_Name.SelectedValue.ToString(), con);

                Daily_Progress d = new Daily_Progress();
                //Map the values to the data model of Daily Progress

                d.Date = dateTimePicker1.Value.Date;
                d.Exercise_ID = Int32.Parse(cb_Workout_Name.SelectedValue.ToString());
                d.Person_ID = Int32.Parse(cb_Person_Name.SelectedValue.ToString());

                d.Total_Sets = Int32.Parse(txt_Total_Sets.Text);
                d.Total_Reps = Int32.Parse(txt_Total_Reps.Text);
                d.Average_Reps = Convert.ToDouble(txt_Avg_Reps.Text);
                d.Average_Weight = Convert.ToDouble(txt_Avg_Weight.Text);

                d.S1_Reps = Int32.Parse(txt_S1_Reps.Text);
                d.S2_Reps = Int32.Parse(txt_S2_Reps.Text);
                d.S3_Reps = Int32.Parse(txt_S3_Reps.Text);
                d.S4_Reps = Int32.Parse(txt_S4_Reps.Text);
                d.S5_Reps = Int32.Parse(txt_S5_Reps.Text);
                d.S6_Reps = Int32.Parse(txt_S6_Reps.Text);
                d.S7_Reps = Int32.Parse(txt_S7_Reps.Text);
                d.S8_Reps = Int32.Parse(txt_S8_Reps.Text);

                d.S1_Weight = Convert.ToDouble(txt_S1_Weight.Text);
                d.S2_Weight = Convert.ToDouble(txt_S2_Weight.Text);
                d.S3_Weight = Convert.ToDouble(txt_S3_Weight.Text);
                d.S4_Weight = Convert.ToDouble(txt_S4_Weight.Text);
                d.S5_Weight = Convert.ToDouble(txt_S5_Weight.Text);
                d.S6_Weight = Convert.ToDouble(txt_S6_Weight.Text);
                d.S7_Weight = Convert.ToDouble(txt_S7_Weight.Text);
                d.S8_Weight = Convert.ToDouble(txt_S8_Weight.Text);

                con.Open();
                cmd.ExecuteNonQuery();

                DataAccess.SaveDailyProgress(d);

                con.Close();

                reset();
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
            reset();
        }


        private void reset()
        {
            dateTimePicker1.Value = System.DateTime.Now;

            chk_All_Workouts.Checked = false;

            txt_S1_Reps.Text = "0";
            txt_S2_Reps.Text = "0";
            txt_S3_Reps.Text = "0";
            txt_S4_Reps.Text = "0";
            txt_S5_Reps.Text = "0";
            txt_S6_Reps.Text = "0";
            txt_S7_Reps.Text = "0";
            txt_S8_Reps.Text = "0";

            txt_S1_Weight.Text = "0";
            txt_S2_Weight.Text = "0";
            txt_S3_Weight.Text = "0";
            txt_S4_Weight.Text = "0";
            txt_S5_Weight.Text = "0";
            txt_S6_Weight.Text = "0";
            txt_S7_Weight.Text = "0";
            txt_S8_Weight.Text = "0";

            cb_Person_Name.Enabled = false;
            cb_Workout_Name.Enabled = false;

            txt_S1_Reps.Enabled = false;
            txt_S2_Reps.Enabled = false;
            txt_S3_Reps.Enabled = false;
            txt_S4_Reps.Enabled = false;
            txt_S5_Reps.Enabled = false;
            txt_S6_Reps.Enabled = false;
            txt_S7_Reps.Enabled = false;
            txt_S8_Reps.Enabled = false;

            txt_S1_Weight.Enabled = false;
            txt_S2_Weight.Enabled = false;
            txt_S3_Weight.Enabled = false;
            txt_S4_Weight.Enabled = false;
            txt_S5_Weight.Enabled = false;
            txt_S6_Weight.Enabled = false;
            txt_S7_Weight.Enabled = false;
            txt_S8_Weight.Enabled = false;
        }

        #endregion

        #region Boxes Event Hanlders
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            filter_CB_Workout();
        }

        private void cb_Person_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cb_Workout_Name.Enabled = true;
            txt_Total_Days.Text = cb_Person_Name.SelectedValue.ToString();
            calcTotalWorkoutDays();
        }

        private void chk_All_Workouts_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_All_Workouts.Checked == true) { fillCB_Workout(); }
            else if (chk_All_Workouts.Checked == false) { filter_CB_Workout(); }
        }

        private void cb_Workout_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_S1_Reps.Enabled = true;

            txt_S1_Weight.Enabled = true;
        }

        private void txt_S1_Reps_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S1_Reps.Text) > 0)
                {
                    txt_S2_Reps.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S2_Reps.Enabled = false;
                    txt_S1_Reps.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S1_Reps.Text = "0";
                txt_S1_Reps.SelectAll();
            }
        }

        private void txt_S2_Reps_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S2_Reps.Text) > 0)
                {
                    txt_S3_Reps.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S3_Reps.Enabled = false;
                    txt_S2_Reps.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S2_Reps.Text = "0";
                txt_S2_Reps.SelectAll();
            }
        }
        
        private void txt_S3_Reps_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S3_Reps.Text) > 0)
                {
                    txt_S4_Reps.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S4_Reps.Enabled = false;
                    txt_S3_Reps.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S3_Reps.Text = "0";
                txt_S3_Reps.SelectAll();
            }
        }

        private void txt_S4_Reps_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S4_Reps.Text) > 0)
                {
                    txt_S5_Reps.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S5_Reps.Enabled = false;
                    txt_S4_Reps.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S4_Reps.Text = "0";
                txt_S4_Reps.SelectAll();
            }
        }

        private void txt_S5_Reps_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S5_Reps.Text) > 0)
                {
                    txt_S6_Reps.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S6_Reps.Enabled = false;
                    txt_S5_Reps.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S5_Reps.Text = "0";
                txt_S5_Reps.SelectAll();
            }
        }

        private void txt_S6_Reps_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S6_Reps.Text) > 0)
                {
                    txt_S7_Reps.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S7_Reps.Enabled = false;
                    txt_S6_Reps.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S6_Reps.Text = "0";
                txt_S6_Reps.SelectAll();
            }
        }

        private void txt_S7_Reps_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S7_Reps.Text) > 0)
                {
                    txt_S8_Reps.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S8_Reps.Enabled = false;
                    txt_S7_Reps.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S7_Reps.Text = "0";
                txt_S7_Reps.SelectAll();
            }
        }

        private void txt_S8_Reps_TextChanged(object sender, EventArgs e)
        {
            try 
            { 
                if (Convert.ToDouble(txt_S8_Reps.Text) > 0 )
                    {
                        AutoCalculate();
                    }
                else { txt_S8_Reps.Text = "0"; }
            }
            catch (Exception) 
            { 
                txt_S8_Reps.Text = "0";
                txt_S8_Reps.SelectAll();
            }
        }

        private void txt_S1_Weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S1_Weight.Text) > 0)
                {
                    txt_S2_Weight.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S2_Weight.Enabled = false;
                    txt_S1_Weight.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S1_Weight.Text = "0";
                txt_S1_Weight.SelectAll();
            }
        }

        private void txt_S2_Weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S2_Weight.Text) > 0)
                {
                    txt_S3_Weight.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S3_Weight.Enabled = false;
                    txt_S2_Weight.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S2_Weight.Text = "0";
                txt_S2_Weight.SelectAll();
            }
        }

        private void txt_S3_Weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S3_Weight.Text) > 0)
                {
                    txt_S4_Weight.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S4_Weight.Enabled = false;
                    txt_S3_Weight.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S3_Weight.Text = "0";
                txt_S3_Weight.SelectAll();
            }
        }

        private void txt_S4_Weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S4_Weight.Text) > 0)
                {
                    txt_S5_Weight.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S5_Weight.Enabled = false;
                    txt_S4_Weight.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S4_Weight.Text = "0";
                txt_S4_Weight.SelectAll();
            }
        }

        private void txt_S5_Weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S5_Weight.Text) > 0)
                {
                    txt_S6_Weight.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S6_Weight.Enabled = false;
                    txt_S5_Weight.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S5_Weight.Text = "0";
                txt_S5_Weight.SelectAll();
            }
        }

        private void txt_S6_Weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S6_Weight.Text) > 0)
                {
                    txt_S7_Weight.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S7_Weight.Enabled = false;
                    txt_S6_Weight.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S6_Weight.Text = "0";
                txt_S6_Weight.SelectAll();
            }
        }

        private void txt_S7_Weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S7_Weight.Text) > 0)
                {
                    txt_S8_Weight.Enabled = true;
                    AutoCalculate();
                }
                else
                {
                    txt_S8_Weight.Enabled = false;
                    txt_S7_Weight.Text = "0";
                }
            }
            catch (Exception) 
            { 
                txt_S7_Weight.Text = "0";
                txt_S7_Weight.SelectAll();
            }
        }       

        private void txt_S8_Weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_S8_Weight.Text) > 0)
                {
                    AutoCalculate();
                }
                else { txt_S8_Weight.Text = "0"; }
            }
            catch (Exception) 
            { 
                txt_S8_Weight.Text = "0";
                txt_S8_Weight.SelectAll();
            }
        }
        private void txt_S1_Reps_Click(object sender, EventArgs e)
        {
            txt_S1_Reps.SelectAll();
        }

        private void txt_S2_Reps_Click(object sender, EventArgs e)
        {
            txt_S2_Reps.SelectAll();
        }

        private void txt_S3_Reps_Click(object sender, EventArgs e)
        {
            txt_S3_Reps.SelectAll();
        }

        private void txt_S4_Reps_Click(object sender, EventArgs e)
        {
            txt_S4_Reps.SelectAll();
        }

        private void txt_S5_Reps_Click(object sender, EventArgs e)
        {
            txt_S5_Reps.SelectAll();
        }

        private void txt_S6_Reps_Click(object sender, EventArgs e)
        {
            txt_S6_Reps.SelectAll();
        }

        private void txt_S7_Reps_Click(object sender, EventArgs e)
        {
            txt_S7_Reps.SelectAll();
        }

        private void txt_S8_Reps_Click(object sender, EventArgs e)
        {
            txt_S8_Reps.SelectAll();
        }

        private void txt_S1_Weight_Click(object sender, EventArgs e)
        {
            txt_S1_Weight.SelectAll();
        }

        private void txt_S2_Weight_Click(object sender, EventArgs e)
        {
            txt_S2_Weight.SelectAll();
        }

        private void txt_S3_Weight_Click(object sender, EventArgs e)
        {
            txt_S3_Weight.SelectAll();
        }

        private void txt_S4_Weight_Click(object sender, EventArgs e)
        {
            txt_S4_Weight.SelectAll();
        }

        private void txt_S5_Weight_Click(object sender, EventArgs e)
        {
            txt_S5_Weight.SelectAll();
        }

        private void txt_S6_Weight_Click(object sender, EventArgs e)
        {
            txt_S6_Weight.SelectAll();
        }

        private void txt_S7_Weight_Click(object sender, EventArgs e)
        {
            txt_S7_Weight.SelectAll();
        }

        private void txt_S8_Weight_Click(object sender, EventArgs e)
        {
            txt_S8_Weight.SelectAll();
        }
        #endregion

        #region Open Other Forms

        private void btn_Schedule_Click(object sender, EventArgs e)
        {
            Schedule s = new Schedule();
            s.Show();
        }

        private void btn_Person_Click(object sender, EventArgs e)
        {
            Personal_Details pd = new Personal_Details();
            pd.Show();
        }

        private void btn_Visualize_Click(object sender, EventArgs e)
        {
            Visualization v = new Visualization();
            v.Show();
        }

        private void btn_Workout_Details_Click(object sender, EventArgs e)
        {
            Workout_Details wd = new Workout_Details();
            wd.Show();
        }

        private void btn_ViewData_Click(object sender, EventArgs e)
        {
            DataForm df = new DataForm();
            df.Show();
        }

        private void btn_WeightTrack_Click(object sender, EventArgs e)
        {
            WeightTrackForm wtf = new WeightTrackForm();
            wtf.Show();
        }

        private void btn_Target_Click(object sender, EventArgs e)
        {
            Weight_Target_Form t = new Weight_Target_Form();
            t.Show();
        }

        #endregion

        #region Copy Data
        private void btn_Reps_Clone_1to2_Click(object sender, EventArgs e)
        {
            txt_S2_Reps.Text = txt_S1_Reps.Text;
        }

        private void btn_Reps_Clone_2to3_Click(object sender, EventArgs e)
        {
            txt_S3_Reps.Text = txt_S2_Reps.Text;
        }

        private void btn_Reps_Clone_3to4_Click(object sender, EventArgs e)
        {
            txt_S4_Reps.Text = txt_S3_Reps.Text;
        }

        private void btn_Reps_Clone_4to5_Click(object sender, EventArgs e)
        {
            txt_S5_Reps.Text = txt_S4_Reps.Text;
        }

        private void btn_Reps_Clone_5to6_Click(object sender, EventArgs e)
        {
            txt_S6_Reps.Text = txt_S5_Reps.Text;
        }

        private void btn_Reps_Clone_6to7_Click(object sender, EventArgs e)
        {
            txt_S7_Reps.Text = txt_S6_Reps.Text;
        }

        private void btn_Reps_Clone_7to8_Click(object sender, EventArgs e)
        {
            txt_S8_Reps.Text = txt_S7_Reps.Text;
        }

        private void btn_Weight_Clone_1to2_Click(object sender, EventArgs e)
        {
            txt_S2_Weight.Text = txt_S1_Weight.Text;
        }

        private void btn_Weight_Clone_2to3_Click(object sender, EventArgs e)
        {
            txt_S3_Weight.Text = txt_S2_Weight.Text;
        }

        private void btn_Weight_Clone_3to4_Click(object sender, EventArgs e)
        {
            txt_S4_Weight.Text = txt_S3_Weight.Text;
        }

        private void btn_Weight_Clone_4to5_Click(object sender, EventArgs e)
        {
            txt_S5_Weight.Text = txt_S4_Weight.Text;
        }

        private void btn_Weight_Clone_5to6_Click(object sender, EventArgs e)
        {
            txt_S6_Weight.Text = txt_S5_Weight.Text;
        }

        private void btn_Weight_Clone_6to7_Click(object sender, EventArgs e)
        {
            txt_S7_Weight.Text = txt_S6_Weight.Text;
        }

        private void btn_Weight_Clone_7to8_Click(object sender, EventArgs e)
        {
            txt_S8_Weight.Text = txt_S7_Weight.Text;
        }
        #endregion

        #region Background Calculations
        private void AutoCalculate()
        {
            try
            {
                //Total sets
                if (Convert.ToDouble(txt_S8_Reps.Text) > 0) { ttl_Sets = 8; }
                else if (Convert.ToDouble(txt_S7_Reps.Text) > 0) { ttl_Sets = 7; }
                else if (Convert.ToDouble(txt_S6_Reps.Text) > 0) { ttl_Sets = 6; }
                else if (Convert.ToDouble(txt_S5_Reps.Text) > 0) { ttl_Sets = 5; }
                else if (Convert.ToDouble(txt_S4_Reps.Text) > 0) { ttl_Sets = 4; }
                else if (Convert.ToDouble(txt_S3_Reps.Text) > 0) { ttl_Sets = 3; }
                else if (Convert.ToDouble(txt_S2_Reps.Text) > 0) { ttl_Sets = 2; }
                else if (Convert.ToDouble(txt_S1_Reps.Text) > 0) { ttl_Sets = 1; }

                txt_Total_Sets.Text = ttl_Sets.ToString();

                //Total reps
                ttl_Reps =  Convert.ToInt32(txt_S8_Reps.Text) + Convert.ToInt32(txt_S7_Reps.Text) +
                            Convert.ToInt32(txt_S6_Reps.Text) + Convert.ToInt32(txt_S5_Reps.Text) +
                            Convert.ToInt32(txt_S4_Reps.Text) + Convert.ToInt32(txt_S3_Reps.Text) +
                            Convert.ToInt32(txt_S2_Reps.Text) + Convert.ToInt32(txt_S1_Reps.Text);

                txt_Total_Reps.Text = ttl_Reps.ToString();

                //Average reps per set
                avg_Reps = ttl_Reps / ttl_Sets;
                txt_Avg_Reps.Text = avg_Reps.ToString();

                //Average weight per set
                ttl_weight = Convert.ToDouble(txt_S8_Weight.Text) + Convert.ToDouble(txt_S7_Weight.Text) +
                            Convert.ToDouble(txt_S6_Weight.Text) + Convert.ToDouble(txt_S5_Weight.Text) +
                            Convert.ToDouble(txt_S4_Weight.Text) + Convert.ToDouble(txt_S3_Weight.Text) +
                            Convert.ToDouble(txt_S2_Weight.Text) + Convert.ToDouble(txt_S1_Weight.Text);
                avg_Weight = ttl_weight / ttl_Sets;
                txt_Avg_Weight.Text = avg_Weight.ToString();
            }
            catch (Exception)
            {              
            }
        }

        private void calcTotalWorkoutDays()
        {
            using (cn)
            {
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand("select count(*) from [Daily Progress] where [Person_ID] = " + cb_Person_Name.SelectedValue.ToString());
                    cmd.Connection = con;
                    DataTable dt = new DataTable();
                    con.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    txt_Total_Days.Text = dt.Rows[0][0].ToString();
                    streak = Int32.Parse(txt_Total_Days.Text);
                }
                catch (Exception E)
                {
                    con.Close();
                    MessageBox.Show(E.Message);
                }
                finally { con.Close(); }
            }
        }

        #endregion

       
    }
}
