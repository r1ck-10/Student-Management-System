namespace StudentClient_Winform.Enrollment_Form
{
    partial class UpdateEnrollmentfrm
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDescription = new TextBox();
            txtDiscount = new TextBox();
            txtAmount = new TextBox();
            txtEnrollDate = new TextBox();
            txtCourseName = new TextBox();
            txtCourseID = new TextBox();
            txtStudentName = new TextBox();
            txtEnrollmentID = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(337, 335);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(237, 335);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 32;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 274);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 23;
            label8.Text = "Description:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 241);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 24;
            label7.Text = "Discount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 208);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 25;
            label6.Text = "Amount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 175);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 26;
            label5.Text = "Enroll Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 142);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 27;
            label4.Text = "Course Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 109);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 28;
            label3.Text = "Course ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 29;
            label2.Text = "Student Name:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(135, 271);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(233, 27);
            txtDescription.TabIndex = 15;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(135, 238);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(233, 27);
            txtDiscount.TabIndex = 16;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(135, 205);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(233, 27);
            txtAmount.TabIndex = 17;
            // 
            // txtEnrollDate
            // 
            txtEnrollDate.Location = new Point(135, 172);
            txtEnrollDate.Name = "txtEnrollDate";
            txtEnrollDate.Size = new Size(233, 27);
            txtEnrollDate.TabIndex = 18;
            txtEnrollDate.Text = "y-m-d";
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(135, 139);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(233, 27);
            txtCourseName.TabIndex = 19;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(135, 106);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(233, 27);
            txtCourseID.TabIndex = 20;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(135, 73);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(233, 27);
            txtStudentName.TabIndex = 21;
            // 
            // txtEnrollmentID
            // 
            txtEnrollmentID.Location = new Point(135, 40);
            txtEnrollmentID.Name = "txtEnrollmentID";
            txtEnrollmentID.Size = new Size(233, 27);
            txtEnrollmentID.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 43);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 30;
            label9.Text = "Enrollment ID:";
            // 
            // UpdateEnrollmentfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 376);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(txtDescription);
            Controls.Add(txtDiscount);
            Controls.Add(txtAmount);
            Controls.Add(txtEnrollDate);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseID);
            Controls.Add(txtStudentName);
            Controls.Add(txtEnrollmentID);
            Name = "UpdateEnrollmentfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Enrollment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOk;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDescription;
        private TextBox txtDiscount;
        private TextBox txtAmount;
        private TextBox txtEnrollDate;
        private TextBox txtCourseName;
        private TextBox txtCourseID;
        private TextBox txtStudentName;
        private TextBox txtEnrollmentID;
        private Label label9;
    }
}