using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout_Tracker_SQLite.Data_Models
{
    public class Weight_Model
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int Person_ID { get; set; }
        public double Daily_Weight { get; set; }
        public double Target_Weight { get; set; }
        public double Weight_To_Target { get; set; }
    }
}
