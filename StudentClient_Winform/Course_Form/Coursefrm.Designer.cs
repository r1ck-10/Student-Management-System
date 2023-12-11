namespace StudentClient_Winform.Course_Form
{
    partial class Coursefrm
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
            txtCourseID = new TextBox();
            btnGetCoursebyID = new Button();
            btnDeleteCourse = new Button();
            button3 = new Button();
            btnGetCourse = new Button();
            btnAddCourse = new Button();
            dgvCourseData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCourseData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(614, 419);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 19;
            label1.Text = "Course ID:";
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(696, 414);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(147, 27);
            txtCourseID.TabIndex = 18;
            // 
            // btnGetCoursebyID
            // 
            btnGetCoursebyID.Location = new Point(749, 447);
            btnGetCoursebyID.Name = "btnGetCoursebyID";
            btnGetCoursebyID.Size = new Size(94, 29);
            btnGetCoursebyID.TabIndex = 13;
            btnGetCoursebyID.Text = "Search";
            btnGetCoursebyID.UseVisualStyleBackColor = true;
            btnGetCoursebyID.Click += btnGetCoursebyID_Click;
            // 
            // btnDeleteCourse
            // 
            btnDeleteCourse.Location = new Point(437, 415);
            btnDeleteCourse.Name = "btnDeleteCourse";
            btnDeleteCourse.Size = new Size(140, 29);
            btnDeleteCourse.TabIndex = 14;
            btnDeleteCourse.Text = "Delete Course";
            btnDeleteCourse.UseVisualStyleBackColor = true;
            btnDeleteCourse.Click += btnDeleteCourse_Click;
            // 
            // button3
            // 
            button3.Location = new Point(287, 415);
            button3.Name = "button3";
            button3.Size = new Size(144, 29);
            button3.TabIndex = 15;
            button3.Text = "Update Course";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnGetCourse
            // 
            btnGetCourse.Location = new Point(144, 415);
            btnGetCourse.Name = "btnGetCourse";
            btnGetCourse.Size = new Size(137, 29);
            btnGetCourse.TabIndex = 16;
            btnGetCourse.Text = "Show Courses";
            btnGetCourse.UseVisualStyleBackColor = true;
            btnGetCourse.Click += btnGetCourse_Click;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(16, 415);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(122, 29);
            btnAddCourse.TabIndex = 17;
            btnAddCourse.Text = "Add Course";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // dgvCourseData
            // 
            dgvCourseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourseData.Location = new Point(12, 11);
            dgvCourseData.Name = "dgvCourseData";
            dgvCourseData.RowHeadersWidth = 51;
            dgvCourseData.Size = new Size(831, 379);
            dgvCourseData.TabIndex = 12;
            // 
            // Coursefrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 486);
            Controls.Add(label1);
            Controls.Add(txtCourseID);
            Controls.Add(btnGetCoursebyID);
            Controls.Add(btnDeleteCourse);
            Controls.Add(button3);
            Controls.Add(btnGetCourse);
            Controls.Add(btnAddCourse);
            Controls.Add(dgvCourseData);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Coursefrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course";
            ((System.ComponentModel.ISupportInitialize)dgvCourseData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCourseID;
        private Button btnGetCoursebyID;
        private Button btnDeleteCourse;
        private Button button3;
        private Button btnGetCourse;
        private Button btnAddCourse;
        private DataGridView dgvCourseData;
    }
}