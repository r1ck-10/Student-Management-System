namespace StudentClient_Winform.Course_Form
{
    partial class Course_Input_frm
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
            label4 = new Label();
            txtTeacherInputID = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCoursePrice = new TextBox();
            txtCourseID = new TextBox();
            txtTeacherInputName = new TextBox();
            txtCourseInputName = new TextBox();
            txtCourseDes = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(334, 293);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(234, 293);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 32;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 179);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 27;
            label4.Text = "Course Price:";
            // 
            // txtTeacherInputID
            // 
            txtTeacherInputID.AutoSize = true;
            txtTeacherInputID.Location = new Point(70, 113);
            txtTeacherInputID.Name = "txtTeacherInputID";
            txtTeacherInputID.Size = new Size(82, 20);
            txtTeacherInputID.TabIndex = 28;
            txtTeacherInputID.Text = "Teacher ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 146);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 29;
            label2.Text = "Teacher Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 80);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 30;
            label1.Text = "Course Name:";
            // 
            // txtCoursePrice
            // 
            txtCoursePrice.Location = new Point(158, 176);
            txtCoursePrice.Name = "txtCoursePrice";
            txtCoursePrice.Size = new Size(233, 27);
            txtCoursePrice.TabIndex = 19;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(158, 110);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(233, 27);
            txtCourseID.TabIndex = 20;
            // 
            // txtTeacherInputName
            // 
            txtTeacherInputName.Location = new Point(158, 143);
            txtTeacherInputName.Name = "txtTeacherInputName";
            txtTeacherInputName.Size = new Size(233, 27);
            txtTeacherInputName.TabIndex = 21;
            // 
            // txtCourseInputName
            // 
            txtCourseInputName.Location = new Point(158, 77);
            txtCourseInputName.Name = "txtCourseInputName";
            txtCourseInputName.Size = new Size(233, 27);
            txtCourseInputName.TabIndex = 22;
            // 
            // txtCourseDes
            // 
            txtCourseDes.Location = new Point(158, 209);
            txtCourseDes.Name = "txtCourseDes";
            txtCourseDes.Size = new Size(233, 27);
            txtCourseDes.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 212);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 27;
            label5.Text = "Course Description:";
            // 
            // Course_Input_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 344);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTeacherInputID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCourseDes);
            Controls.Add(txtCoursePrice);
            Controls.Add(txtCourseID);
            Controls.Add(txtTeacherInputName);
            Controls.Add(txtCourseInputName);
            Name = "Course_Input_frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Input";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOk;
        private Label label4;
        private Label txtTeacherInputID;
        private Label label2;
        private Label label1;
        private TextBox txtCoursePrice;
        private TextBox txtCourseID;
        private TextBox txtTeacherInputName;
        private TextBox txtCourseInputName;
        private TextBox txtCourseDes;
        private Label label5;
    }
}