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
        public LandingForm()
        {
            InitializeComponent();
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {
           
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
    }
}
