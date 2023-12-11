namespace StudentClient_Winform.Course_Form
{
    partial class UpdateCoursefrm
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
            txtTeacherInputID = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCourseDes = new TextBox();
            txtCoursePrice = new TextBox();
            txtCourseID = new TextBox();
            txtTeacherInputName = new TextBox();
            txtCourseInputName = new TextBox();
            txtCourseIDforUpdate = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(346, 272);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(246, 272);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 44;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 220);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 38;
            label5.Text = "Course Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 187);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 39;
            label4.Text = "Course Price:";
            // 
            // txtTeacherInputID
            // 
            txtTeacherInputID.AutoSize = true;
            txtTeacherInputID.Location = new Point(79, 121);
            txtTeacherInputID.Name = "txtTeacherInputID";
            txtTeacherInputID.Size = new Size(82, 20);
            txtTeacherInputID.TabIndex = 40;
            txtTeacherInputID.Text = "Teacher ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 154);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 41;
            label2.Text = "Teacher Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 88);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 42;
            label1.Text = "Course Name:";
            // 
            // txtCourseDes
            // 
            txtCourseDes.Location = new Point(167, 217);
            txtCourseDes.Name = "txtCourseDes";
            txtCourseDes.Size = new Size(233, 27);
            txtCourseDes.TabIndex = 33;
            // 
            // txtCoursePrice
            // 
            txtCoursePrice.Location = new Point(167, 184);
            txtCoursePrice.Name = "txtCoursePrice";
            txtCoursePrice.Size = new Size(233, 27);
            txtCoursePrice.TabIndex = 34;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(167, 118);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(233, 27);
            txtCourseID.TabIndex = 35;
            // 
            // txtTeacherInputName
            // 
            txtTeacherInputName.Location = new Point(167, 151);
            txtTeacherInputName.Name = "txtTeacherInputName";
            txtTeacherInputName.Size = new Size(233, 27);
            txtTeacherInputName.TabIndex = 36;
            // 
            // txtCourseInputName
            // 
            txtCourseInputName.Location = new Point(167, 85);
            txtCourseInputName.Name = "txtCourseInputName";
            txtCourseInputName.Size = new Size(233, 27);
            txtCourseInputName.TabIndex = 37;
            // 
            // txtCourseIDforUpdate
            // 
            txtCourseIDforUpdate.Location = new Point(167, 52);
            txtCourseIDforUpdate.Name = "txtCourseIDforUpdate";
            txtCourseIDforUpdate.Size = new Size(233, 27);
            txtCourseIDforUpdate.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 55);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 42;
            label3.Text = "Course ID:";
            // 
            // UpdateCoursefrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 340);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTeacherInputID);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtCourseDes);
            Controls.Add(txtCoursePrice);
            Controls.Add(txtCourseID);
            Controls.Add(txtTeacherInputName);
            Controls.Add(txtCourseIDforUpdate);
            Controls.Add(txtCourseInputName);
            Name = "UpdateCoursefrm";
            Text = "UpdateCoursefrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOk;
        private Label label5;
        private Label label4;
        private Label txtTeacherInputID;
        private Label label2;
        private Label label1;
        private TextBox txtCourseDes;
        private TextBox txtCoursePrice;
        private TextBox txtCourseID;
        private TextBox txtTeacherInputName;
        private TextBox txtCourseInputName;
        private TextBox txtCourseIDforUpdate;
        private Label label3;
    }
}