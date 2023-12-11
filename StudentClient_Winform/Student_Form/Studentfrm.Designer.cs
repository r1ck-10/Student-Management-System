namespace StudentClient_Winform.Student_Form
{
    partial class Studentfrm
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
            dgvStudentData = new DataGridView();
            btnAddStudent = new Button();
            btnGetstudent = new Button();
            btnUpdateStudent = new Button();
            btnDeleteStudent = new Button();
            txtID = new TextBox();
            label1 = new Label();
            btnSeach_byID = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudentData).BeginInit();
            SuspendLayout();
            // 
            // dgvStudentData
            // 
            dgvStudentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentData.Location = new Point(12, 12);
            dgvStudentData.Name = "dgvStudentData";
            dgvStudentData.RowHeadersWidth = 51;
            dgvStudentData.Size = new Size(831, 379);
            dgvStudentData.TabIndex = 0;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(16, 416);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(103, 29);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnGetstudent
            // 
            btnGetstudent.Location = new Point(125, 415);
            btnGetstudent.Name = "btnGetstudent";
            btnGetstudent.Size = new Size(117, 29);
            btnGetstudent.TabIndex = 1;
            btnGetstudent.Text = "Show Students";
            btnGetstudent.UseVisualStyleBackColor = true;
            btnGetstudent.Click += btnGetstudent_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Location = new Point(248, 415);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(123, 29);
            btnUpdateStudent.TabIndex = 1;
            btnUpdateStudent.Text = "Update Student";
            btnUpdateStudent.UseVisualStyleBackColor = true;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(377, 416);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(123, 29);
            btnDeleteStudent.TabIndex = 1;
            btnDeleteStudent.Text = "Delete Student";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(696, 415);
            txtID.Name = "txtID";
            txtID.Size = new Size(147, 27);
            txtID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(608, 418);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "Student ID:";
            // 
            // btnSeach_byID
            // 
            btnSeach_byID.Location = new Point(749, 448);
            btnSeach_byID.Name = "btnSeach_byID";
            btnSeach_byID.Size = new Size(94, 29);
            btnSeach_byID.TabIndex = 1;
            btnSeach_byID.Text = "Search";
            btnSeach_byID.UseVisualStyleBackColor = true;
            btnSeach_byID.Click += btnSeach_byID_Click;
            // 
            // Studentfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 486);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(btnSeach_byID);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnUpdateStudent);
            Controls.Add(btnGetstudent);
            Controls.Add(btnAddStudent);
            Controls.Add(dgvStudentData);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Studentfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            ((System.ComponentModel.ISupportInitialize)dgvStudentData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentData;
        private Button btnAddStudent;
        private Button btnGetstudent;
        private Button btnUpdateStudent;
        private Button btnDeleteStudent;
        private TextBox txtID;
        private Label label1;
        private Button btnSeach_byID;
    }
}