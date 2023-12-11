namespace StudentClient_Winform.Enrollment_Form
{
    partial class Enrollment_input_frm
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
            btnCancel = new Button();
            btnOk = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEnrollDate = new TextBox();
            txtCourseName = new TextBox();
            txtCourseID = new TextBox();
            txtStudentName = new TextBox();
            txtStudentID = new TextBox();
            txtAmount = new TextBox();
            label6 = new Label();
            txtDiscount = new TextBox();
            label7 = new Label();
            txtDescription = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(337, 303);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(237, 303);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 14;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 167);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 8;
            label5.Text = "Enroll Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 134);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 9;
            label4.Text = "Course Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 101);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 10;
            label3.Text = "Course ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 68);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 11;
            label2.Text = "Student Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 35);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 12;
            label1.Text = "Student ID:";
            // 
            // txtEnrollDate
            // 
            txtEnrollDate.Location = new Point(131, 164);
            txtEnrollDate.Name = "txtEnrollDate";
            txtEnrollDate.Size = new Size(233, 27);
            txtEnrollDate.TabIndex = 3;
            txtEnrollDate.Text = "y-m-d";
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(131, 131);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(233, 27);
            txtCourseName.TabIndex = 4;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(131, 98);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(233, 27);
            txtCourseID.TabIndex = 5;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(131, 65);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(233, 27);
            txtStudentName.TabIndex = 6;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(131, 32);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(233, 27);
            txtStudentID.TabIndex = 7;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(131, 197);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(233, 27);
            txtAmount.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 200);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 8;
            label6.Text = "Amount:";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(131, 230);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(233, 27);
            txtDiscount.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 233);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 8;
            label7.Text = "Discount:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(131, 263);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(233, 27);
            txtDescription.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 266);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 8;
            label8.Text = "Description:";
            // 
            // Enrollment_input_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 344);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtDiscount);
            Controls.Add(txtAmount);
            Controls.Add(txtEnrollDate);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseID);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Name = "Enrollment_input_frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enrollment Input";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOk;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEnrollDate;
        private TextBox txtCourseName;
        private TextBox txtCourseID;
        private TextBox txtStudentName;
        private TextBox txtStudentID;
        private TextBox txtAmount;
        private Label label6;
        private TextBox txtDiscount;
        private Label label7;
        private TextBox txtDescription;
        private Label label8;
    }
}