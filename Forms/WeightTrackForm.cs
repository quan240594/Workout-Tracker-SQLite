﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workout_Tracker_SQLite.Data_Models;

namespace Workout_Tracker_SQLite.Forms
{
    public partial class WeightTrackForm : Form
    {
        #region Variable
        SQLiteConnection con = new SQLiteConnection(DataAccess.ConString("Default"));
        double dWeight;
        double target;
        double distance;
        string pid = "";
        string cYear = "";

        #endregion

        public WeightTrackForm()
        {
            InitializeComponent();
        }

        private void btn_SaveData_Click(object sender, EventArgs e)
        {
            Weight_Model w = new Weight_Model();
            w.Date = dateTimePicker1.Value.Date;
            w.Daily_Weight = Convert.ToDouble(txt_Weight.Text);
            w.Person_ID = Int32.Parse(cb_Person.SelectedValue.ToString());
            w.Target_Weight = Convert.ToDouble(cb_Target.Text);
            w.Weight_To_Target = Convert.ToDouble(txt_Distance.Text);

            DataAccess.SaveWeightProgress(w);
        }

        private void reset()
        {
            dateTimePicker1.Enabled = false;
            txt_Weight.ReadOnly = true;
            txt_Distance.ReadOnly = true;
            cb_Target.Enabled  = false;
            fillGrid();
            fillCB();
        }

        private void WeightTrackForm_Load(object sender, EventArgs e)
        {
            reset();            
        }

        private void fillGrid()
        {
            SQLiteCommand cmd = new SQLiteCommand("Select Full_Name, w.Person_ID, Date, Weight, Target, Weight_To_Target FROM [Person] p, [Weight_Tracking] w, [Yearly_Weight_Target] t " +
                "WHERE (w.Person_ID = p.Person_ID AND w.Person_ID = t.Person_ID) ORDER BY [DATE] DESC", con);
            DataTable dt = new DataTable();
            con.Open();
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                dt.Load(dr);
                con.Close();
                dataGridView1.DataSource = dt;
            }            
        }

        private void fillCB()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [PERSON] ORDER BY Full_Name", con);
            DataTable dt = new DataTable();
            con.Open();
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                dt.Load(dr);
                con.Close();
                cb_Person.DataSource = dt;
                cb_Person.DisplayMember = "Full_Name";
                cb_Person.ValueMember = "Person_ID";
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
        }

        private void cb_Person_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dateTimePicker1.Enabled == true)
            { txt_Weight.ReadOnly = false; }
            pid = cb_Person.SelectedValue.ToString();
            try
            {
                cYear = dateTimePicker1.Value.Year.ToString();
            }
            catch (Exception)
            {
                cYear = DateTime.Now.Year.ToString();
            }

            SQLiteCommand cmd = new SQLiteCommand("SELECT [TARGET] FROM [Yearly_Weight_Target] where [Person_ID] = " + pid + " AND [Year] = " + cYear + " ORDER BY [YEAR] DESC LIMIT 1", con);
            DataTable dt = new DataTable();
            con.Open();
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                dt.Load(dr);
                con.Close();
                cb_Target.DataSource = dt;
                cb_Target.DisplayMember = "Target";
                cb_Target.ValueMember = "Target";
            }
        }

        private void txt_Weight_Click(object sender, EventArgs e)
        {
            txt_Weight.SelectAll();
        }

        private void AutoCalculate()
        {
            distance = Math.Abs(target - dWeight);
            txt_Distance.Text = distance.ToString("0.00");
        }

        private void txt_Weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                target = Convert.ToDouble(cb_Target.Text);
                dWeight = Convert.ToDouble(txt_Weight.Text);
                AutoCalculate();
            }
            catch (Exception)
            { txt_Weight.Text = "0"; }
        }
    }
}
