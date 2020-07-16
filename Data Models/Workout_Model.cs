using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout_Tracker_SQLite
{
    public class Workout_Model
    {
        public int Exercise_ID { get; set; }
        public string Exercise_Name { get; set; }
        public string Active { get; set; }
        public string Muscle_Group { get; set; }
        public string Weight_Required { get; set; }
        public string Weight_Type { get; set; }

        //Days that the workouts take place on
        public string Day_1 { get; set; }
        public string Day_2 { get; set; }
    }
}
