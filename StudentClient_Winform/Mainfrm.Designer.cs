namespace StudentClient_Winform
{
    partial class Mainfrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStudent = new Button();
            panel1 = new Panel();
            btnClassroom = new Button();
            btnTeacher = new Button();
            btnCourse = new Button();
            btnEnrollment = new Button();
            mainpanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStudent
            // 
            btnStudent.BackColor = SystemColors.ButtonShadow;
            btnStudent.Dock = DockStyle.Top;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Location = new Point(0, 0);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(167, 54);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btnClassroom);
            panel1.Controls.Add(btnTeacher);
            panel1.Controls.Add(btnCourse);
            panel1.Controls.Add(btnEnrollment);
            panel1.Controls.Add(btnStudent);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 486);
            panel1.TabIndex = 1;
            // 
            // btnClassroom
            // 
            btnClassroom.BackColor = SystemColors.ButtonShadow;
            btnClassroom.Dock = DockStyle.Top;
            btnClassroom.FlatAppearance.BorderSize = 0;
            btnClassroom.FlatStyle = FlatStyle.Flat;
            btnClassroom.Location = new Point(0, 216);
            btnClassroom.Name = "btnClassroom";
            btnClassroom.Size = new Size(167, 54);
            btnClassroom.TabIndex = 3;
            btnClassroom.Text = "Classroom";
            btnClassroom.UseVisualStyleBackColor = false;
            btnClassroom.Click += btnClassroom_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.BackColor = SystemColors.ButtonShadow;
            btnTeacher.Dock = DockStyle.Top;
            btnTeacher.FlatAppearance.BorderSize = 0;
            btnTeacher.FlatStyle = FlatStyle.Flat;
            btnTeacher.Location = new Point(0, 162);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(167, 54);
            btnTeacher.TabIndex = 3;
            btnTeacher.Text = "Teacher";
            btnTeacher.UseVisualStyleBackColor = false;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnCourse
            // 
            btnCourse.BackColor = SystemColors.ButtonShadow;
            btnCourse.Dock = DockStyle.Top;
            btnCourse.FlatAppearance.BorderSize = 0;
            btnCourse.FlatStyle = FlatStyle.Flat;
            btnCourse.Location = new Point(0, 108);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(167, 54);
            btnCourse.TabIndex = 2;
            btnCourse.Text = "Course";
            btnCourse.UseVisualStyleBackColor = false;
            btnCourse.Click += btnCourse_Click;
            // 
            // btnEnrollment
            // 
            btnEnrollment.BackColor = SystemColors.ButtonShadow;
            btnEnrollment.Dock = DockStyle.Top;
            btnEnrollment.FlatAppearance.BorderSize = 0;
            btnEnrollment.FlatStyle = FlatStyle.Flat;
            btnEnrollment.Location = new Point(0, 54);
            btnEnrollment.Name = "btnEnrollment";
            btnEnrollment.Size = new Size(167, 54);
            btnEnrollment.TabIndex = 2;
            btnEnrollment.Text = "Enroll";
            btnEnrollment.UseVisualStyleBackColor = false;
            btnEnrollment.Click += btnEnrollment_Click;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(167, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(855, 486);
            mainpanel.TabIndex = 2;
            // 
            // Mainfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 486);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            Name = "Mainfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Managment System";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnStudent;
        private Panel panel1;
        private Button btnCourse;
        private Button btnEnrollment;
        private Panel mainpanel;
        private Button btnClassroom;
        private Button btnTeacher;
    }
}
