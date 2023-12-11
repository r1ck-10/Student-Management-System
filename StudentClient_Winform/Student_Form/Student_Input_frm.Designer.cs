namespace StudentClient_Winform.Student_Form
{
    partial class Student_Input_frm
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
            txtName = new TextBox();
            label1 = new Label();
            txtDOB = new TextBox();
            label2 = new Label();
            txtContact = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtInfo = new TextBox();
            label5 = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(233, 27);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 42);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(90, 72);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(233, 27);
            txtDOB.TabIndex = 0;
            txtDOB.Text = "y-m-d";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 75);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "DOB:";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(90, 105);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(233, 27);
            txtContact.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 108);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 1;
            label3.Text = "Contact:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(90, 138);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(233, 27);
            txtAddress.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 141);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 1;
            label4.Text = "Address:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(90, 171);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(233, 27);
            txtInfo.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 174);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 1;
            label5.Text = "Info:";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(170, 228);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(270, 228);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Student_Input_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 269);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInfo);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtDOB);
            Controls.Add(txtName);
            Name = "Student_Input_frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Input";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private TextBox txtDOB;
        private Label label2;
        private TextBox txtContact;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtInfo;
        private Label label5;
        private Button btnOk;
        private Button btnCancel;
    }
}