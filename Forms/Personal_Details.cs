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
    
    public partial class Personal_Details : Form
    {
        SQLiteConnection con = new SQLiteConnection(DataAccess.ConString("Default"));
        SQLiteCommand cmd = new SQLiteCommand("SELECT * from [Person]");
        string rowID = "";
        public Personal_Details()
        {
            InitializeComponent();
        }

        private void Personal_Details_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            try
            {
                cmd.Connection = con;
                    con.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    con.Close();
                    dataGridView1.DataSource = dt;
        }
            catch (Exception E)
                {
                    con.Close();
                    MessageBox.Show(E.Message);
                }    
            finally { con.Close(); }
        }

        private void btn_SavePersonalData_Click(object sender, EventArgs e)
        {
            try
            {
                Person_Model person = new Person_Model();

                person.Full_Name = txt_Full_Name.Text;
                person.Start_Date = dateTimePicker1.Value;
                person.Active = 1;

                DataAccess.SavePersonalDetails(person);

                txt_Full_Name.Text = "";
                dateTimePicker1.Value = System.DateTime.Now;
                loadDataGrid();
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
            finally { con.Close(); }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM [Person] WHERE [Person_ID] = " + rowID, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            loadDataGrid();
        }
    }
}
