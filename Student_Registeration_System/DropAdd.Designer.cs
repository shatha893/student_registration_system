namespace Student_Registeration_System
{
    partial class DropAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.SecNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Next Semester\'s Available Courses";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SecNum,
            this.CourseNumber,
            this.CourseName,
            this.Time,
            this.Classroom,
            this.Instructor,
            this.Day,
            this.Capacity});
            this.dataGridView1.Location = new System.Drawing.Point(28, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1392, 485);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "*Please Click the number of the course you want to Drop/Add";
            // 
            // SecNum
            // 
            this.SecNum.HeaderText = "Section Number";
            this.SecNum.MinimumWidth = 8;
            this.SecNum.Name = "SecNum";
            this.SecNum.ReadOnly = true;
            // 
            // CourseNumber
            // 
            this.CourseNumber.HeaderText = "Course Number";
            this.CourseNumber.MinimumWidth = 8;
            this.CourseNumber.Name = "CourseNumber";
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 8;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 8;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Classroom
            // 
            this.Classroom.HeaderText = "Classroom";
            this.Classroom.MinimumWidth = 8;
            this.Classroom.Name = "Classroom";
            this.Classroom.ReadOnly = true;
            // 
            // Instructor
            // 
            this.Instructor.HeaderText = "Instructor";
            this.Instructor.MinimumWidth = 8;
            this.Instructor.Name = "Instructor";
            this.Instructor.ReadOnly = true;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.MinimumWidth = 8;
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 8;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            // 
            // DropAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1644, 1106);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DropAdd";
            this.Text = "DropAdd";
            this.Load += new System.EventHandler(this.DropAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
    }
}