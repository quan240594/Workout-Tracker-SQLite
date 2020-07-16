using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Workout_Tracker_SQLite
{
    public class Person_Model
    {
        public int ID { get; set; }
        public string Full_Name { get; set; }
        public DateTime Start_Date { get; set; }
        public int Active { get; set; }
        public int Workout_Days { get; set; }
    }
}
