using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout_Tracker_SQLite
{
    public class Daily_Progress
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int Exercise_ID { get; set; }
        public int Person_ID { get; set; }
        public int Total_Sets { get; set; }
        public int Total_Reps { get; set; }
        public double Average_Reps { get; set; }
        public double Average_Weight { get; set; }
        public int S1_Reps { get; set; }
        public int S2_Reps { get; set; }
        public int S3_Reps { get; set; }
        public int S4_Reps { get; set; }
        public int S5_Reps { get; set; }
        public int S6_Reps { get; set; }
        public int S7_Reps { get; set; }
        public int S8_Reps { get; set; }
        public double S1_Weight { get; set; }
        public double S2_Weight { get; set; }
        public double S3_Weight { get; set; }
        public double S4_Weight { get; set; }
        public double S5_Weight { get; set; }
        public double S6_Weight { get; set; }
        public double S7_Weight { get; set; }
        public double S8_Weight { get; set; }

    }
}
