namespace Student_Registeration_System
{
    partial class StudyPlan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prerequisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.CourseNumber,
            this.Course_Name,
            this.Prerequisite});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(51, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1310, 864);
            this.dataGridView1.TabIndex = 0;
            // 
            // CourseNumber
            // 
            this.CourseNumber.HeaderText = "Course Number";
            this.CourseNumber.MinimumWidth = 8;
            this.CourseNumber.Name = "CourseNumber";
            // 
            // Course_Name
            // 
            this.Course_Name.HeaderText = "Course Name";
            this.Course_Name.MinimumWidth = 8;
            this.Course_Name.Name = "Course_Name";
            // 
            // Prerequisite
            // 
            this.Prerequisite.HeaderText = "Prerequisite";
            this.Prerequisite.MinimumWidth = 8;
            this.Prerequisite.Name = "Prerequisite";
            // 
            // StudyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1823, 909);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudyPlan";
            this.Text = "StudyPlan";
            this.Load += new System.EventHandler(this.StudyPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prerequisite;
    }
}