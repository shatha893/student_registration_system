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
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
        }

        StreamReader reader;
        StudentInfo std;
        int ID;
        private void StudentProfile_Load(object sender, EventArgs e)
        {
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

                //____Fill the student's data____//
                name.Text = std.Name;
                gender.Text = std.Gender;
                phoneNumber.Text = std.PhoneNum.ToString();
                nationality.Text = std.Nationality.ToString();
                avg.Text = std.Average.ToString();
                std_num.Text = std.StudentID.ToString();
                specialization.Text = std.Degree;
                DoB.Text = std.DoB;
                address.Text = std.Addr;
                email.Text = std.Email;
                //________________________________//

            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("An error with the parsing");
            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("Something is wrong!");
            }
        }
    }
}
