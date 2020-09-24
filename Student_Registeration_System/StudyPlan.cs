using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Student_Registeration_System
{
    public partial class StudyPlan : Form
    {
        public StudyPlan()
        {
            InitializeComponent();
        }

        
        StreamReader reader;
        int ID;
        StudentInfo std;
        private void StudyPlan_Load(object sender, EventArgs e)
        {
            //--First we connect to the DB--
           
            using (SQLiteConnection myConnection = new SQLiteConnection("Data Source = SRSDB.db; Version = 3;"))
            {
                myConnection.Open();
                //__To access the signed in student ID__//
                try
                {
                    reader = new StreamReader("Log.txt");
                    string r, temp = " ";
                    while ((r = reader.ReadLine()) != null)
                    {
                        temp = r;
                    }
                    string[] line = temp.Split(',');
                    ID = int.Parse(line[0]);
                    reader.Close();

                    std = new StudentInfo(ID);
                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("File Not Found");
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("An error with the parsing");
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Something is wrong!");
                }
                //-- Get the courses into the DataGrid -- Depending on the Student's Specialization --
                string sql;
                if (std.Degree == "Computer Science" || std.Degree == "Software Engineering" || std.Degree == "Computer Graphics and Animation")
                    sql = $"SELECT * FROM Courses WHERE Program = 'CS'";
                else
                    sql = $"SELECT * FROM Courses WHERE Program = 'Eng'";
                SQLiteCommand c = new SQLiteCommand(sql, myConnection);
                SQLiteDataReader r2 = c.ExecuteReader();
                while (r2.Read())
                {
                    dataGridView1.Rows.Add(r2["CourseID"], r2["CourseName"], r2["Prerequisite"]);
                }
            }
        }
    }
}
