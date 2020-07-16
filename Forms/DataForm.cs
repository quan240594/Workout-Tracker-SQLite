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
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(DataAccess.ConString("Default"));
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("Select * from [Daily Progress] ORDER BY [Date]");
            cmd.Connection = con;
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                dataGridView_DailyProgress.DataSource = dt;
            }
        }
    }
}
