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

namespace Student_Registeration_System
{
    public partial class Container : Form
    {
       
        public Container()
        {
            InitializeComponent();
        }

        public void fixButtons(Button obj)
        {
            home_button.Enabled = true;
            std_profile_button.Enabled = true;
           
            DA_button.Enabled = true;
            splan_button.Enabled = true;

            obj.Enabled = false;
        }



        

        private void Container_Load(object sender, EventArgs e)
        {
            Login child = new Login();
            child.MdiParent = this;
            child.c = this;
            child.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            //__This is if u want to log out__//

            Form login = Application.OpenForms["Login"];
            if (login != null)
            { pictureBox2.Enabled = false;  return; }
            
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                //__Close all opened forms__//
                Form stdProf = Application.OpenForms["StudentProfile"];
                if (stdProf != null)
                    stdProf.Close();

                Form sched = Application.OpenForms["Schedule"];
                if (sched != null)
                    sched.Close();

                Form DA = Application.OpenForms["DropAdd"];
                if (DA != null)
                    DA.Close();

                Form h = Application.OpenForms["Home"];
                if (h != null)
                    h.Close();

                Form sP = Application.OpenForms["StudyPlan"];
                if (sP != null)
                    sP.Close();

                panel3.Visible = true;

                //__Open Login Form__//
                Login child = new Login();
                child.MdiParent = Form.ActiveForm;
                child.c = this;
                child.Show();
            }
           

        }

        private void home_button_Click(object sender, EventArgs e)
        {
           
            //__Close opened forms__//
            Form stdProf = Application.OpenForms["StudentProfile"];
             if (stdProf != null)
              stdProf.Close();

            Form DA = Application.OpenForms["DropAdd"];
            if (DA != null)
                DA.Close();

            Form sP = Application.OpenForms["StudyPlan"];
            if (sP != null)
                sP.Close();
            //_____________________//
            fixButtons(home_button);
        }

        private void std_profile_button_Click(object sender, EventArgs e)
        {
            StudentProfile child = new StudentProfile();
            child.MdiParent = Form.ActiveForm;
            child.Show();

            fixButtons(std_profile_button);
        }

       
        private void DA_button_Click(object sender, EventArgs e)
        {
            DropAdd child = new DropAdd();
            child.MdiParent = Form.ActiveForm;
            child.Show();

            fixButtons(DA_button);
        }

        private void splan_button_Click(object sender, EventArgs e)
        {
            StudyPlan child = new StudyPlan();
            child.MdiParent = Form.ActiveForm;
            child.Show();

            fixButtons(splan_button);
        }

        private void log_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Log.txt");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {}
    }
}
