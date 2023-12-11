namespace StudentClient_Winform.Classroom_Form
{
    partial class UpdateClassroomfrm
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
            txtDescription = new TextBox();
            txtCourse = new TextBox();
            txtStudentNumber = new TextBox();
            txtSchedule = new TextBox();
            txtRoomnumber = new TextBox();
            txtClassroomID = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(376, 284);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(276, 284);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 26;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 224);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 20;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 188);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 21;
            label4.Text = "Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 158);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 22;
            label3.Text = "Student Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 122);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 23;
            label2.Text = "Schedule:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 89);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 24;
            label1.Text = "Room Number:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(168, 221);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(233, 27);
            txtDescription.TabIndex = 15;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(168, 188);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(233, 27);
            txtCourse.TabIndex = 16;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(168, 155);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(233, 27);
            txtStudentNumber.TabIndex = 17;
            // 
            // txtSchedule
            // 
            txtSchedule.Location = new Point(168, 119);
            txtSchedule.Name = "txtSchedule";
            txtSchedule.Size = new Size(233, 27);
            txtSchedule.TabIndex = 18;
            // 
            // txtRoomnumber
            // 
            txtRoomnumber.Location = new Point(168, 86);
            txtRoomnumber.Name = "txtRoomnumber";
            txtRoomnumber.Size = new Size(233, 27);
            txtRoomnumber.TabIndex = 19;
            // 
            // txtClassroomID
            // 
            txtClassroomID.Location = new Point(168, 53);
            txtClassroomID.Name = "txtClassroomID";
            txtClassroomID.Size = new Size(233, 27);
            txtClassroomID.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 56);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 24;
            label6.Text = "Classroom ID:";
            // 
            // UpdateClassroomfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 325);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtCourse);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtSchedule);
            Controls.Add(txtClassroomID);
            Controls.Add(txtRoomnumber);
            Name = "UpdateClassroomfrm";
            Text = "Update Classroom";
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
        private TextBox txtDescription;
        private TextBox txtCourse;
        private TextBox txtStudentNumber;
        private TextBox txtSchedule;
        private TextBox txtRoomnumber;
        private TextBox txtClassroomID;
        private Label label6;
    }
}