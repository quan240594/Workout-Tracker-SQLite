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
        SQLiteCommand selectPerson = new SQLiteCommand("SELECT * from [Person]");
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
                    selectPerson.Connection = con;
                    con.Open();
                    SQLiteDataReader dr = selectPerson.ExecuteReader();
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
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
            finally { con.Close(); }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }
    }
}
