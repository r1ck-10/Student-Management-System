namespace StudentClient_Winform.Enrollment_Form
{
    partial class Enrollmentfrm
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
            txtEnrollmentID = new TextBox();
            btnGetbyID = new Button();
            btnDelete = new Button();
            btnupdateEnroll = new Button();
            btnGetEnrollment = new Button();
            btnAddEnroll = new Button();
            dgvEnrollData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEnrollData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(587, 419);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 11;
            label1.Text = "Enrollment ID:";
            // 
            // txtEnrollmentID
            // 
            txtEnrollmentID.Location = new Point(696, 414);
            txtEnrollmentID.Name = "txtEnrollmentID";
            txtEnrollmentID.Size = new Size(147, 27);
            txtEnrollmentID.TabIndex = 10;
            // 
            // btnGetbyID
            // 
            btnGetbyID.Location = new Point(749, 447);
            btnGetbyID.Name = "btnGetbyID";
            btnGetbyID.Size = new Size(94, 29);
            btnGetbyID.TabIndex = 5;
            btnGetbyID.Text = "Search";
            btnGetbyID.UseVisualStyleBackColor = true;
            btnGetbyID.Click += btnGetbyID_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(437, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Enrollment";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnupdateEnroll
            // 
            btnupdateEnroll.Location = new Point(287, 415);
            btnupdateEnroll.Name = "btnupdateEnroll";
            btnupdateEnroll.Size = new Size(144, 29);
            btnupdateEnroll.TabIndex = 7;
            btnupdateEnroll.Text = "Update Enrollment";
            btnupdateEnroll.UseVisualStyleBackColor = true;
            btnupdateEnroll.Click += btnupdateEnroll_Click;
            // 
            // btnGetEnrollment
            // 
            btnGetEnrollment.Location = new Point(144, 415);
            btnGetEnrollment.Name = "btnGetEnrollment";
            btnGetEnrollment.Size = new Size(137, 29);
            btnGetEnrollment.TabIndex = 8;
            btnGetEnrollment.Text = "Show Enrollments";
            btnGetEnrollment.UseVisualStyleBackColor = true;
            btnGetEnrollment.Click += btnGetEnrollment_Click;
            // 
            // btnAddEnroll
            // 
            btnAddEnroll.Location = new Point(16, 415);
            btnAddEnroll.Name = "btnAddEnroll";
            btnAddEnroll.Size = new Size(122, 29);
            btnAddEnroll.TabIndex = 9;
            btnAddEnroll.Text = "Add Enrollment";
            btnAddEnroll.UseVisualStyleBackColor = true;
            btnAddEnroll.Click += btnAddEnroll_Click;
            // 
            // dgvEnrollData
            // 
            dgvEnrollData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnrollData.Location = new Point(12, 11);
            dgvEnrollData.Name = "dgvEnrollData";
            dgvEnrollData.RowHeadersWidth = 51;
            dgvEnrollData.Size = new Size(831, 379);
            dgvEnrollData.TabIndex = 4;
            // 
            // Enrollmentfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 486);
            Controls.Add(label1);
            Controls.Add(txtEnrollmentID);
            Controls.Add(btnGetbyID);
            Controls.Add(btnDelete);
            Controls.Add(btnupdateEnroll);
            Controls.Add(btnGetEnrollment);
            Controls.Add(btnAddEnroll);
            Controls.Add(dgvEnrollData);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Enrollmentfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enrollment";
            ((System.ComponentModel.ISupportInitialize)dgvEnrollData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEnrollmentID;
        private Button btnGetbyID;
        private Button btnDelete;
        private Button btnupdateEnroll;
        private Button btnGetEnrollment;
        private Button btnAddEnroll;
        private DataGridView dgvEnrollData;
    }
}