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
    public partial class LandingForm : Form
    {
        SQLiteConnection con = new SQLiteConnection(DataAccess.ConString("Default"));
        IDbConnection cn = new SQLiteConnection(DataAccess.ConString("Default"));
        public LandingForm()
        {
            InitializeComponent();            
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {         
            fillCB();
        }

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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataForm df = new DataForm();
            df.Show();
        }
        #endregion

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
                    cb_Person_Name.ValueMember = "Person ID";
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
                    cb_Workout_Name.ValueMember = "Exercise ID";
                }
            }
        }

        #region Connection State Test
        private void conStateCheck()
        {
            if (con.State == System.Data.ConnectionState.Open) 
            { 
                txt_Constate.Text = "Open";
            }
            else 
            { 
                txt_Constate.Text = "Closed";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conStateCheck();
        }

        private void btn_PID_Click(object sender, EventArgs e)
        {
            txt_PID.Text = cb_Person_Name.SelectedValue.ToString();
        }
        #endregion

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Daily_Progress d = new Daily_Progress();
            //Map the values to the data model of Daily Progress
            d.Average_Reps = Convert.ToDouble(txt_Avg_Reps.Text);
            d.Average_Weight = Convert.ToDouble(txt_Avg_Weight.Text);
            d.Date = dateTimePicker1.Value;
            d.Exercise_ID = Int32.Parse(cb_Workout_Name.SelectedValue.ToString());
            d.Person_ID = Int32.Parse(cb_Person_Name.SelectedValue.ToString());

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
        }
    }
}
