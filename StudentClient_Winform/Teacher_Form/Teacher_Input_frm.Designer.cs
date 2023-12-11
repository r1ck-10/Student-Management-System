namespace StudentClient_Winform.Teacher_Form
{
    partial class Teacher_Input_frm
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
            txtInfo = new TextBox();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtDOB = new TextBox();
            txtName = new TextBox();
            txtskill = new TextBox();
            label6 = new Label();
            txtclass = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(304, 331);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(204, 331);
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
            label5.Location = new Point(52, 256);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 8;
            label5.Text = "Info:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 157);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 9;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 124);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 10;
            label3.Text = "Contact:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 91);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 11;
            label2.Text = "DOB:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 58);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 12;
            label1.Text = "Name:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(101, 253);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(233, 27);
            txtInfo.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(101, 154);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(233, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(101, 121);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(233, 27);
            txtContact.TabIndex = 5;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(101, 88);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(233, 27);
            txtDOB.TabIndex = 6;
            txtDOB.Text = "y-m-d";
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(233, 27);
            txtName.TabIndex = 7;
            // 
            // txtskill
            // 
            txtskill.Location = new Point(101, 187);
            txtskill.Name = "txtskill";
            txtskill.Size = new Size(233, 27);
            txtskill.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 190);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 9;
            label6.Text = "Skill:";
            // 
            // txtclass
            // 
            txtclass.Location = new Point(101, 220);
            txtclass.Name = "txtclass";
            txtclass.Size = new Size(233, 27);
            txtclass.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 223);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 9;
            label7.Text = "Class:";
            // 
            // Teacher_Input_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 372);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInfo);
            Controls.Add(txtclass);
            Controls.Add(txtskill);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtDOB);
            Controls.Add(txtName);
            Name = "Teacher_Input_frm";
            Text = "Teacher_Input_frm";
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
        private TextBox txtInfo;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtDOB;
        private TextBox txtName;
        private TextBox txtskill;
        private Label label6;
        private TextBox txtclass;
        private Label label7;
    }
}