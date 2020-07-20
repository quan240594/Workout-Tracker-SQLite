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
using System.Windows.Forms.DataVisualization.Charting;

namespace Workout_Tracker_SQLite
{
    public partial class Visualization : Form
    {
        #region Variables   
        SQLiteConnection con = new SQLiteConnection(DataAccess.ConString("Default"));
        IDbConnection cn = new SQLiteConnection(DataAccess.ConString("Default"));
        string eID = "";
        string pID = "";
        string baseQuery = "SELECT [Date], [Total_Sets], [Total_Reps], [Average_Reps], [Average_Weight] FROM [Daily Progress]";
        string eFilter = "  WHERE [Exercise_ID] = ";
        string pFilter = " AND [Person_ID] = ";
        string dateOrder = " ORDER BY [Date]";

        #endregion
        public Visualization()
        {
            InitializeComponent();
        }

        private void Visualization_Load(object sender, EventArgs e)
        {
            fillCB();
        }


        private void fillCB()
        {
            fillCB_Person();
            fillCB_Workout();
        }

        private void fillCB_Person()
        {
            using (cn)
            {
                SQLiteCommand cmd = new SQLiteCommand("Select * from [Person] ORDER BY [Full_Name]");
                cmd.Connection = con;
                con.Open();
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    con.Close();
                    cb_Person_Name.DataSource = dt;
                    cb_Person_Name.DisplayMember = "Full_Name";
                    cb_Person_Name.ValueMember = "Person_ID";
                }
            }
        }

        private void fillCB_Workout()
        {
            using (cn)
            {
                SQLiteCommand cmd = new SQLiteCommand("Select * from [Exercise Details] ORDER BY [Exercise_Name]");
                cmd.Connection = con;
                con.Open();
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    con.Close();
                    cb_Workout_Name.DataSource = dt;
                    cb_Workout_Name.DisplayMember = "Exercise_Name";
                    cb_Workout_Name.ValueMember = "Exercise_ID";
                }
            }
        }

        #region Load Chart
        private void loadChart()
        {
                pID = cb_Person_Name.SelectedValue.ToString();
                eID = cb_Workout_Name.SelectedValue.ToString();
                chart1.Titles.Clear();
                chart1.Series.Clear();

                SQLiteCommand cmd = new SQLiteCommand(baseQuery + eFilter + eID + pFilter + pID + dateOrder, con);
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(dr);

                chart1.DataSource = dt;
                chart1.DataBind();
                con.Close();

                chart1.Titles.Add(cb_Workout_Name.SelectedText.ToString());
                chart1.Titles.Add(cb_Person_Name.SelectedText.ToString());
                                
                chart1.Series.Add("Total Sets");
                chart1.Series["Total Sets"].XValueMember = "Date";
                chart1.Series["Total Sets"].YValueMembers = "Total_Sets";
                chart1.Series["Total Sets"].ChartType = SeriesChartType.Column;
                chart1.Series["Total Sets"]["PixelPointWidth"] = "20";
                chart1.Series["Total Sets"].IsValueShownAsLabel = true;
                chart1.Series["Total Sets"].LabelBorderWidth = 3;
                chart1.Series["Total Sets"].SmartLabelStyle.Enabled = true;

                chart1.Series.Add("Average Reps");
                chart1.Series["Average Reps"].XValueMember = "Date";
                chart1.Series["Average Reps"].YValueMembers = "Average_Reps";
                chart1.Series["Average Reps"].ChartType = SeriesChartType.Spline;
                chart1.Series["Average Reps"].BorderWidth = 5;
                chart1.Series["Average Reps"].IsValueShownAsLabel = true;
                chart1.Series["Average Reps"].LabelBorderWidth = 3;
                chart1.Series["Average Reps"].MarkerStyle = MarkerStyle.Cross;
                chart1.Series["Average Reps"].MarkerSize = 15;
                chart1.Series["Average Reps"].SmartLabelStyle.Enabled = true;

                chart1.Series.Add("Average Weight");
                chart1.Series["Average Weight"].XValueMember = "Date";
                chart1.Series["Average Weight"].YValueMembers = "Average_Weight";
                chart1.Series["Average Weight"].ChartType = SeriesChartType.Spline;
                chart1.Series["Average Weight"].BorderWidth = 5;
                chart1.Series["Average Weight"].IsValueShownAsLabel = true;
                chart1.Series["Average Weight"].LabelBorderWidth = 3;
                chart1.Series["Average Weight"].MarkerStyle = MarkerStyle.Star10;
                chart1.Series["Average Weight"].MarkerSize = 15;
                chart1.Series["Average Weight"].SmartLabelStyle.Enabled = true;

                chart1.Series.Add("Total Reps");
                chart1.Series["Total Reps"].XValueMember = "Date";
                chart1.Series["Total Reps"].YValueMembers = "Total_Reps";
                chart1.Series["Total Reps"].ChartType = SeriesChartType.Spline;
                chart1.Series["Total Reps"].BorderWidth = 5;
                chart1.Series["Total Reps"].IsValueShownAsLabel = true;
                chart1.Series["Total Reps"].LabelBorderWidth = 3;
                chart1.Series["Total Reps"].MarkerStyle = MarkerStyle.Diamond;
                chart1.Series["Total Reps"].SmartLabelStyle.Enabled = true;

                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "d-MMM";
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;

                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
        }

#endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillCB();
            chart1.Titles.Clear();
            chart1.Series.Clear();
        }

        private void btn_LoadChart_Click(object sender, EventArgs e)
        {
            cb_Workout_Name.Focus();
            //chk_Avg_Reps.Checked = true;
            //chk_Avg_Weight.Checked = true;
            //chk_Total_Reps.Checked = true;
            //chk_Total_Sets.Checked = true;
            loadChart();
        }

        private void cb_Person_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pID = cb_Person_Name.SelectedValue.ToString();
            SQLiteCommand cmd = new SQLiteCommand("Select * from [Person] WHERE [Person_ID] = " + pID, con);
            con.Open();
            SQLiteDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            con.Close();

            cb_Total_Days.DataSource = dt;
            cb_Total_Days.DisplayMember = "Workout_Days";
        }

        private void chk_Total_Sets_CheckStateChanged(object sender, EventArgs e)
        {
            Series ts = chart1.Series["Total Sets"];
            ts.Enabled = chk_Total_Sets.Checked;
        }
    }
}
