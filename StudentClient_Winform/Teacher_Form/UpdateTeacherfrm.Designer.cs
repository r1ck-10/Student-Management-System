namespace StudentClient_Winform.Teacher_Form
{
    partial class UpdateTeacherfrm
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
            label6 = new Label();
            label1 = new Label();
            txtInfo = new TextBox();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtDOB = new TextBox();
            txtID = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtclass = new TextBox();
            txtskill = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(276, 355);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(176, 355);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 28;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 268);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 21;
            label5.Text = "Info:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 168);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 22;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 135);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 23;
            label3.Text = "Contact:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 102);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 24;
            label2.Text = "DOB:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 36);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 25;
            label6.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 69);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 26;
            label1.Text = "Name:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(94, 265);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(233, 27);
            txtInfo.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(94, 165);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(233, 27);
            txtAddress.TabIndex = 16;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(94, 132);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(233, 27);
            txtContact.TabIndex = 17;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(94, 99);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(233, 27);
            txtDOB.TabIndex = 18;
            txtDOB.Text = "y-m-d";
            // 
            // txtID
            // 
            txtID.Location = new Point(94, 33);
            txtID.Name = "txtID";
            txtID.Size = new Size(233, 27);
            txtID.TabIndex = 19;
            // 
            // txtName
            // 
            txtName.Location = new Point(94, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(233, 27);
            txtName.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 234);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 31;
            label7.Text = "Class:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 201);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 32;
            label8.Text = "Skill:";
            // 
            // txtclass
            // 
            txtclass.Location = new Point(94, 231);
            txtclass.Name = "txtclass";
            txtclass.Size = new Size(233, 27);
            txtclass.TabIndex = 29;
            // 
            // txtskill
            // 
            txtskill.Location = new Point(94, 198);
            txtskill.Name = "txtskill";
            txtskill.Size = new Size(233, 27);
            txtskill.TabIndex = 30;
            // 
            // UpdateTeacherfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 396);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtclass);
            Controls.Add(txtskill);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(txtInfo);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtDOB);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Name = "UpdateTeacherfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateTeacherfrm";
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
        private Label label6;
        private Label label1;
        private TextBox txtInfo;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtDOB;
        private TextBox txtID;
        private TextBox txtName;
        private Label label7;
        private Label label8;
        private TextBox txtclass;
        private TextBox txtskill;
    }
}