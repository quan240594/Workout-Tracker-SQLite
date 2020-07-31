using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout_Tracker_SQLite.Data_Models
{
    public class Weight_Target_Model
    {
        public int ID { get; set; }
        public int Person_ID { get; set; }
        public int Year { get; set; }
        public double Target { get; set; }
    }
}
