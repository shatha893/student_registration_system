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
    
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }



        public Container c;
       

       
        public void login_button_Click_1(object sender, EventArgs e)
        {
            
            using (SQLiteConnection myConnection = new SQLiteConnection("Data Source = SRSDB.db; Version = 3;"))
            {
                myConnection.Open();
                //____See if the Id and Password the user entered are true or not____//
                string sql2 = $"SELECT stdID,stdName FROM Student WHERE stdID = {int.Parse(id_textBox.Text)} AND Password = '{password_textBox.Text}'";
                
                using (SQLiteCommand c = new SQLiteCommand(sql2, myConnection))
                {
                    SQLiteDataReader reader = c.ExecuteReader();

                    //--If the ID or Password are wrong--
                    if (reader.Read() == false)
                    {
                        MessageBox.Show("Please enter a valide ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            //--If everything is correct--
           
            //__Fill the text File Log.txt with the ID of the signed in student and the time and date__//
            DateTime loginDateTime = DateTime.Now;

            using (StreamWriter writer = File.AppendText("Log.txt"))
            {
                writer.WriteLine($"{id_textBox.Text},{loginDateTime}");
            }

            //__opening the Home page__//
            Home child = new Home();
            child.MdiParent = Form.ActiveForm;
            child.Show();
            ((Container)c).panel3.Visible = false;

            //__Close the Login Form__//
            Form f = Application.OpenForms["Login"];
            if (f != null)
                f.Close();
        }



        private void submit_button_Click(object sender, EventArgs e)
        {
            //___Check if all the fields are filled by the user__//
            string gender = null, fn = fn_textBox.Text, ln = ln_textBox.Text, phn = phone_textBox.Text;
            string dob = dateTimePicker.Value.ToString(), addr = addr_textBox.Text, email = email_textBox.Text;
            string passw = pass_textBox.Text;

            if (F.Checked)
                gender = "Female";
            else
                gender = "Male";

            if (fn == " " || ln == " " || phn == " " || addr == " " || email == " " || passw == " " || degree_comboBox.SelectedItem == null || gender == null)
            {
                MessageBox.Show($"Please enter all the fields!");
                return;
            }
            //____________________________________________________//

            //__ After you made sure that the user entered all the data required __ insert it into the DB__//
            //--Connect--
           

            using (SQLiteConnection myConnection = new SQLiteConnection("Data Source = SRSDB.db; Version = 3;"))
            {
                myConnection.Open();
                //--Insert--
                string sql = $"INSERT INTO Student( stdName, Specialization, Gender, PhoneNum, DoB, Email, Address, Password,Average) VALUES('{fn} {ln}','{degree_comboBox.SelectedItem.ToString()}','{gender}', { int.Parse(phn)}, '{dob}', '{email}', '{addr}', '{passw}',0)";

                //--Execute--
                using (SQLiteCommand c = new SQLiteCommand(sql, myConnection))
                    c.ExecuteNonQuery();

                //________Student Profile created successfully_________//
                MessageBox.Show($"Your application has been accepted\nYour ID is: {myConnection.LastInsertRowId}\nPlease go to the login page to sign into your account");
            }
            }



        private void phone_textBox_TextChanged(object sender, EventArgs e)
        {

            //____Phone Number validation___//
            string phone = phone_textBox.Text;
            if (phone.StartsWith("079") || phone.StartsWith("077") || phone.StartsWith("078"))
            {
                if (phone.Length == 10)
                {
                    phone_textBox.BackColor = Color.PaleGreen;
                    notValid.Visible = false;
                }
            }
            else
            {
                phone_textBox.BackColor = Color.MistyRose;
                notValid.Visible = true;
            }
            //________________________________//

           
        }

        private void Login_Load(object sender, EventArgs e)
        {}
        private void login_tabPage_Click(object sender, EventArgs e)
        {}
    }
}
