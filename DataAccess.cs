using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout_Tracker_SQLite
{
    class DataAccess
    {
        IDbConnection cn = new SQLiteConnection(DataAccess.ConString("Default"));
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

        public static void SaveData(Daily_Progress daily)
        {
            using (IDbConnection cn = new SQLiteConnection(DataAccess.ConString("Default")))
            {
                cn.Execute("INSERT INTO [DAILY PROGRESS] (Date, Exercise_ID, Person ID, Total_Sets, Total_Reps, Average_Reps, Average_Weight, " +
                    "S1_Reps, S2_Reps, S3_Reps, S4_Reps, S5_Reps, S6_Reps, S7_Reps, S8_Reps, " +
                    "S1_Weight, S2_Weight, S3_Weight, S4_Weight, S5_Weight, S6_Weight, S7_Weight, S8_Weight)" +
                    "VALUES (@Date, @Exercise_ID,@Person_ID,@Total_Sets,@Total_Reps,@Average_Reps,@Average_Weight," +
                    "@S1_Reps,@S2_Reps,@S3_Reps,@S4_Reps,@S5_Reps,@S6_Reps,@S7_Reps,@S8_Reps," +
                    "@S1_Weight,@S2_Weight,@S3_Weight,@S4_Weight,@S5_Weight,@S6_Weight,@S7_Weight,@S8_Weight)", daily);
            }
        }
    }
}
