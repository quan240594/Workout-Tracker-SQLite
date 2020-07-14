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
        public IDbConnection con;
        public DataAccess()
        {
            con = new SQLiteConnection(ConString("Default"));
        }

        public static string ConString(string name = "Default")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public void conOpen()
        {
            if (con.State != System.Data.ConnectionState.Open) { con.Open(); }
        }

        public void conClose()
        {
            if (con.State != System.Data.ConnectionState.Closed) { con.Close(); }
        }
    }
}
