using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workout_Tracker_SQLite.Data_Models;

namespace Workout_Tracker_SQLite
{
    class DataAccess
    {
        IDbConnection cn = new SQLiteConnection(DataAccess.ConString("Default"));
        SQLiteConnection con = new SQLiteConnection(DataAccess.ConString("Default"));

        public DataAccess()
        {
            cn = new SQLiteConnection(ConString("Default"));
        }

        public static string ConString(string name = "Default")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public void conOpen()
        {
            if (cn.State != System.Data.ConnectionState.Open) { cn.Open(); }
        }

        public void conClose()
        {
            if (cn.State != System.Data.ConnectionState.Closed) { cn.Close(); }
        }


        //Save Data by mapping input vs an instance of this class, which is a data model. 
        //Input is behind the @sign and will be mapped with the UI in the form
        public static void SaveDailyProgress(Daily_Progress daily)
        {
            using (IDbConnection cn = new SQLiteConnection(DataAccess.ConString("Default")))
            {
                try
                {
                    cn.Execute("INSERT INTO [DAILY PROGRESS] (Date, Exercise_ID, Person_ID, Total_Sets, Total_Reps, Average_Reps, Average_Weight, " +
                        "S1_Reps, S2_Reps, S3_Reps, S4_Reps, S5_Reps, S6_Reps, S7_Reps, S8_Reps, " +
                        "S1_Weight, S2_Weight, S3_Weight, S4_Weight, S5_Weight, S6_Weight, S7_Weight, S8_Weight) " +
                        "VALUES (@Date, @Exercise_ID, @Person_ID, @Total_Sets, @Total_Reps, @Average_Reps, @Average_Weight, " +
                        "@S1_Reps, @S2_Reps, @S3_Reps, @S4_Reps, @S5_Reps, @S6_Reps, @S7_Reps, @S8_Reps, " +
                        "@S1_Weight, @S2_Weight, @S3_Weight, @S4_Weight, @S5_Weight, @S6_Weight, @S7_Weight, @S8_Weight)", daily);
                    MessageBox.Show("Data saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception E) { MessageBox.Show(E.Message); }
            }
        }


        public static void SavePersonalDetails( Person_Model person)
        {
            using (IDbConnection cn = new SQLiteConnection(DataAccess.ConString("Default")))
            {
                try
                {
                    cn.Execute("INSERT INTO [Person] (Full_Name, Start_Date, Active) VALUES (@Full_Name, @Start_Date, @Active)", person);
                    MessageBox.Show("Data saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception E) { MessageBox.Show(E.Message); }
            }
        }

        public static void SaveWorkoutDetails (Workout_Model workout)
        {
            using (IDbConnection cn = new SQLiteConnection(DataAccess.ConString("Default")))
            {
                try
                {
                    cn.Execute("INSERT INTO [Exercise Details] (Exercise_Name, Active, Muscle_Group, Weight_Required, Weight_Type, Day_1, Day_2) VALUES" +
                        "(@Exercise_Name, @Active, @Muscle_Group, @Weight_Required, @Weight_Type, @Day_1, @Day_2)", workout);
                    MessageBox.Show("Data saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception E) { MessageBox.Show(E.Message); }
            }
        }

        public static void SaveWeightProgress (Weight_Model daily_weight)
        {
            using (IDbConnection cn = new SQLiteConnection(DataAccess.ConString("Default")))
            {
                try
                {
                    cn.Execute("INSERT INTO [Weight_Tracking] (Date, Person_ID, Weight, Target_Weight, Weight_To_Target) VALUES" +
                        "(@Date, @Person_ID, @Weight, @Target_Weight, @Weight_To_Target)", daily_weight);
                    MessageBox.Show("Data saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception E) { MessageBox.Show(E.Message); }
            }
        }
        public static void SaveWeightTarget(Weight_Target_Model target)
        {
            using (IDbConnection cn = new SQLiteConnection(DataAccess.ConString("Default")))
            {
                try
                {
                    cn.Execute("INSERT INTO [Yearly_Weight_Target] (Person_ID, Year, Target) VALUES" +
                        "(@Person_ID, @Year, @Target)", target);
                    MessageBox.Show("Data saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception E) { MessageBox.Show(E.Message); }
            }
        }

    }
}
