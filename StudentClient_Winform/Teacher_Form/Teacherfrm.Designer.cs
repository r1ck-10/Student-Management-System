namespace StudentClient_Winform.Teacher_Form
{
    partial class Teacherfrm
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
            label1 = new Label();
            txtIDTeacher = new TextBox();
            btnGetTeacherbyID = new Button();
            btnDeleteTeacher = new Button();
            btnUpdateTeacher = new Button();
            btnGetTeacher = new Button();
            btnAddTeacher = new Button();
            dgvTeacherData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTeacherData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(608, 419);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 27;
            label1.Text = "Teacher ID:";
            // 
            // txtIDTeacher
            // 
            txtIDTeacher.Location = new Point(696, 414);
            txtIDTeacher.Name = "txtIDTeacher";
            txtIDTeacher.Size = new Size(147, 27);
            txtIDTeacher.TabIndex = 26;
            // 
            // btnGetTeacherbyID
            // 
            btnGetTeacherbyID.Location = new Point(749, 447);
            btnGetTeacherbyID.Name = "btnGetTeacherbyID";
            btnGetTeacherbyID.Size = new Size(94, 29);
            btnGetTeacherbyID.TabIndex = 21;
            btnGetTeacherbyID.Text = "Search";
            btnGetTeacherbyID.UseVisualStyleBackColor = true;
            btnGetTeacherbyID.Click += btnGetTeacherbyID_Click;
            // 
            // btnDeleteTeacher
            // 
            btnDeleteTeacher.Location = new Point(437, 415);
            btnDeleteTeacher.Name = "btnDeleteTeacher";
            btnDeleteTeacher.Size = new Size(140, 29);
            btnDeleteTeacher.TabIndex = 22;
            btnDeleteTeacher.Text = "Delete Teacher";
            btnDeleteTeacher.UseVisualStyleBackColor = true;
            btnDeleteTeacher.Click += btnDeleteTeacher_Click;
            // 
            // btnUpdateTeacher
            // 
            btnUpdateTeacher.Location = new Point(287, 415);
            btnUpdateTeacher.Name = "btnUpdateTeacher";
            btnUpdateTeacher.Size = new Size(144, 29);
            btnUpdateTeacher.TabIndex = 23;
            btnUpdateTeacher.Text = "Update Teacher";
            btnUpdateTeacher.UseVisualStyleBackColor = true;
            btnUpdateTeacher.Click += btnUpdateTeacher_Click;
            // 
            // btnGetTeacher
            // 
            btnGetTeacher.Location = new Point(144, 415);
            btnGetTeacher.Name = "btnGetTeacher";
            btnGetTeacher.Size = new Size(137, 29);
            btnGetTeacher.TabIndex = 24;
            btnGetTeacher.Text = "Show Teachers";
            btnGetTeacher.UseVisualStyleBackColor = true;
            btnGetTeacher.Click += btnGetTeacher_Click;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Location = new Point(16, 415);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(122, 29);
            btnAddTeacher.TabIndex = 25;
            btnAddTeacher.Text = "Add Teacher";
            btnAddTeacher.UseVisualStyleBackColor = true;
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // dgvTeacherData
            // 
            dgvTeacherData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacherData.Location = new Point(12, 11);
            dgvTeacherData.Name = "dgvTeacherData";
            dgvTeacherData.RowHeadersWidth = 51;
            dgvTeacherData.Size = new Size(831, 379);
            dgvTeacherData.TabIndex = 20;
            // 
            // Teacherfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 486);
            Controls.Add(label1);
            Controls.Add(txtIDTeacher);
            Controls.Add(btnGetTeacherbyID);
            Controls.Add(btnDeleteTeacher);
            Controls.Add(btnUpdateTeacher);
            Controls.Add(btnGetTeacher);
            Controls.Add(btnAddTeacher);
            Controls.Add(dgvTeacherData);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Teacherfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher";
            ((System.ComponentModel.ISupportInitialize)dgvTeacherData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIDTeacher;
        private Button btnGetTeacherbyID;
        private Button btnDeleteTeacher;
        private Button btnUpdateTeacher;
        private Button btnGetTeacher;
        private Button btnAddTeacher;
        private DataGridView dgvTeacherData;
    }
}