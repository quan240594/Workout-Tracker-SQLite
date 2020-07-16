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
    public partial class Schedule : Form
    {
        string wd = "";
        SQLiteConnection con = new SQLiteConnection(DataAccess.ConString("Default"));
        public Schedule()
        {
            InitializeComponent();
        }

        private void todayWorkout()
        {
            wd = dateTimePicker1.Value.DayOfWeek.ToString();
            using (con)
            {
                SQLiteCommand cmd = new SQLiteCommand("Select [Exercise_Name] FROM [Exercise Details] where [Day_1] LIKE '" + wd + "' OR [Day_2] LIKE '" + wd + "' ORDER BY [Exercise_Name]");
                cmd.Connection = con;
                con.Open();
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    con.Close();
                    listBox_Workout.DataSource = dt;
                    listBox_Workout.DisplayMember = "Exercise_Name";
                    listBox_Workout.ValueMember = "Exercise_Name";
                }
            }
        }

        private void btn_todayWorkout_Click(object sender, EventArgs e)
        {
            todayWorkout();
        }
    }
}
