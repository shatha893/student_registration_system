using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Registeration_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public int ID;
        public StudentInfo std;
        StreamReader reader;
        private void Home_Load(object sender, EventArgs e)
        {
            //__To access the signed in student ID__//
            try
            {
                reader = new StreamReader("Log.txt");
                string r, temp=" ";
                while((r =reader.ReadLine())!= null)
                {
                    temp = r;
                }
                string[] line = temp.Split(',');
                ID = int.Parse(line[0]);
                reader.Close();

                std = new StudentInfo(ID);
                user_name_label.Text = std.Name;
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
            }
            catch(System.FormatException)
            {
                MessageBox.Show("An error with the parsing");
            }
        }

        private void user_name_label_Click(object sender, EventArgs e)
        {

        }
    }
}
