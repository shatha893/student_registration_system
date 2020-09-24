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
    public partial class DropAdd : Form
    {
        public DropAdd()
        {
            InitializeComponent();
        }

        StreamReader reader;
        StudentInfo std;
        int ID;
        int[] selectedIndecies = new int[1000];
        private void DropAdd_Load(object sender, EventArgs e)
        {
            //--First we connect to the DB--
            // myConnection = new SQLiteConnection("Data Source = SRSDB.db; Version = 3;");
            // myConnection.Open();

            using (SQLiteConnection myConnection = new SQLiteConnection("Data Source = SRSDB.db; Version = 3;"))
            { //__To access the signed in student ID__//
                myConnection.Open();
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
                string sections;
                if (std.Degree == "Computer Science" || std.Degree == "Software Engineering" || std.Degree == "Computer Graphics and Animation")
                    sections = "SELECT * FROM Sections WHERE CourseID IN (SELECT CourseID FROM Courses WHERE Program = 'CS' OR Program = 'All') ";
                else
                    sections = "SELECT * FROM Sections WHERE CourseID IN (SELECT CourseID FROM Courses WHERE Program = 'Eng' OR Program = 'All')";
                SQLiteCommand c = new SQLiteCommand(sections, myConnection);
                SQLiteDataReader readSections = c.ExecuteReader();


                string Instructors;
                
                SQLiteDataReader readInstructors;

                string coursesNames;
                
                SQLiteDataReader readCourses;

                while (readSections.Read())
                {
                    
                    Instructors = $"SELECT InstructorName FROM Instructors WHERE InstructorID = {readSections["InstructorID"]}";
                    using (SQLiteCommand c2 = new SQLiteCommand(Instructors, myConnection))
                        readInstructors = c2.ExecuteReader();

                    coursesNames = $"SELECT CourseName FROM Courses WHERE CourseID = {readSections["CourseID"]}";
                    using (SQLiteCommand c3 = new SQLiteCommand(coursesNames, myConnection))
                        readCourses = c3.ExecuteReader();

                    dataGridView1.Rows.Add(readSections["SecNum"], readSections["CourseID"], readCourses["CourseName"], readSections["Time"], readSections["Classroom"], readInstructors["InstructorName"], readSections["Day"], readSections["Capacity"]);

                }
            }
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

                if (e.ColumnIndex == 1)
                {
                    string secNum, courseNum, add, check, drop;
                    bool m;

                using (SQLiteConnection myConnection = new SQLiteConnection("Data Source = SRSDB.db; Version = 3;"))
                {
                    myConnection.Open();
                    //--- Take values in the row with the clicked cell ---
                    secNum = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    courseNum = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                    //--- Check if the course if already submited ---
                    check = $"SELECT * FROM RegisteredSections WHERE stdID = {ID} AND CourseID = {courseNum}";
                    using (SQLiteCommand c4 = new SQLiteCommand(check, myConnection))
                    {
                        SQLiteDataReader checkRead = c4.ExecuteReader();
                        m = checkRead.Read();
                    }
                }

                    //SQLiteConnection myConnection2 = new SQLiteConnection("Data Source = SRSDB.db; Version = 3;");
                    //myConnection2.Open();
                    if (m == false)
                    {
                        using (SQLiteConnection myConnection = new SQLiteConnection("Data Source = SRSDB.db; Version = 3;"))
                        {
                            myConnection.Open();
                            //--- If it wasn't submitted add it ---//
                            add = $"INSERT INTO RegisteredSections (SecNum, stdID, CourseID) VALUES ({secNum},{ID},{courseNum})";
                            
                        using (SQLiteCommand c5 = new SQLiteCommand(add, myConnection))
                        {
                            c5.ExecuteNonQuery();
                            MessageBox.Show("Course Added Successfully");
                        }
                            return;
                        }

                    }
                    using (SQLiteConnection myConnection = new SQLiteConnection("Data Source = SRSDB.db; Version = 3;"))
                    {
                        myConnection.Open();
                        //--- If it was submitted delete it ---//
                        drop = $"DELETE FROM RegisteredSections WHERE stdID = {ID} AND CourseID = {courseNum}";
                       
                     using (SQLiteCommand c6 = new SQLiteCommand(drop, myConnection))
                     {
                        c6.ExecuteNonQuery();
                        MessageBox.Show("Courses Droped Successfully");
                     }
                    }
                }
            
        } 
        

    }
}
