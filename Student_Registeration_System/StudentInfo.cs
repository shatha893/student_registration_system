using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace Student_Registeration_System
{
   
   public class StudentInfo
    {
        
        public string Gender { get; set; }
        public string Name { get; set; }
        public int PhoneNum { get; set; }
        public string DoB { get; set; }
        public string Addr { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nationality { get; set; }
        public float Average { get; set; }

        public string Degree { get; set; }
        public int StudentID { get; set; }
        public StudentInfo(int ID)
        {
            //--Connect to the DB--
           
            using (SQLiteConnection myConnection = new SQLiteConnection("Data Source = SRSDB.db; Version = 3;"))
            {
                myConnection.Open();
                //__Retrieve the information of the student with the id "ID"__//
                string sql = $"SELECT * FROM Student WHERE stdID = {ID}";
               
                using (SQLiteCommand c = new SQLiteCommand(sql, myConnection))
                {
                    SQLiteDataReader r = c.ExecuteReader();

                    //--Set all the student info properties from the DB--

                    StudentID = ID;
                    Name = r["stdName"].ToString();
                    Gender = r["Gender"].ToString();
                    PhoneNum = int.Parse(r["PhoneNum"].ToString());
                    DoB = r["DoB"].ToString();
                    Email = r["Email"].ToString();
                    Addr = r["Address"].ToString();
                    Password = r["Password"].ToString();
                    Nationality = r["Nationality"].ToString();
                    Average = float.Parse(r["Average"].ToString());
                    Degree = r["Specialization"].ToString();
                }
            }
        }
    }
}
