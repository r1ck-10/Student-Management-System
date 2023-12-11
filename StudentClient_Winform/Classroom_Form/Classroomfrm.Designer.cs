namespace StudentClient_Winform.Classroom_Form
{
    partial class Classroomfrm
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
            txtIDClassroom = new TextBox();
            btnGetClassroomByID = new Button();
            btnDeleteClassroom = new Button();
            btnUpdateClassroom = new Button();
            btnGetClassroom = new Button();
            btnAddClassroom = new Button();
            dgvClassroomData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClassroomData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(594, 419);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 19;
            label1.Text = "Classroom ID:";
            // 
            // txtIDClassroom
            // 
            txtIDClassroom.Location = new Point(696, 414);
            txtIDClassroom.Name = "txtIDClassroom";
            txtIDClassroom.Size = new Size(147, 27);
            txtIDClassroom.TabIndex = 18;
            // 
            // btnGetClassroomByID
            // 
            btnGetClassroomByID.Location = new Point(749, 447);
            btnGetClassroomByID.Name = "btnGetClassroomByID";
            btnGetClassroomByID.Size = new Size(94, 29);
            btnGetClassroomByID.TabIndex = 13;
            btnGetClassroomByID.Text = "Search";
            btnGetClassroomByID.UseVisualStyleBackColor = true;
            btnGetClassroomByID.Click += btnGetClassroomByID_Click;
            // 
            // btnDeleteClassroom
            // 
            btnDeleteClassroom.Location = new Point(437, 415);
            btnDeleteClassroom.Name = "btnDeleteClassroom";
            btnDeleteClassroom.Size = new Size(140, 29);
            btnDeleteClassroom.TabIndex = 14;
            btnDeleteClassroom.Text = "Delete Classroom";
            btnDeleteClassroom.UseVisualStyleBackColor = true;
            btnDeleteClassroom.Click += btnDeleteClassroom_Click;
            // 
            // btnUpdateClassroom
            // 
            btnUpdateClassroom.Location = new Point(287, 415);
            btnUpdateClassroom.Name = "btnUpdateClassroom";
            btnUpdateClassroom.Size = new Size(144, 29);
            btnUpdateClassroom.TabIndex = 15;
            btnUpdateClassroom.Text = "Update Classroom";
            btnUpdateClassroom.UseVisualStyleBackColor = true;
            btnUpdateClassroom.Click += btnUpdateClassroom_Click;
            // 
            // btnGetClassroom
            // 
            btnGetClassroom.Location = new Point(144, 415);
            btnGetClassroom.Name = "btnGetClassroom";
            btnGetClassroom.Size = new Size(137, 29);
            btnGetClassroom.TabIndex = 16;
            btnGetClassroom.Text = "Show Classrooms";
            btnGetClassroom.UseVisualStyleBackColor = true;
            btnGetClassroom.Click += btnGetClassroom_Click;
            // 
            // btnAddClassroom
            // 
            btnAddClassroom.Location = new Point(16, 415);
            btnAddClassroom.Name = "btnAddClassroom";
            btnAddClassroom.Size = new Size(122, 29);
            btnAddClassroom.TabIndex = 17;
            btnAddClassroom.Text = "Add Classroom";
            btnAddClassroom.UseVisualStyleBackColor = true;
            btnAddClassroom.Click += btnAddClassroom_Click;
            // 
            // dgvClassroomData
            // 
            dgvClassroomData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClassroomData.Location = new Point(12, 11);
            dgvClassroomData.Name = "dgvClassroomData";
            dgvClassroomData.RowHeadersWidth = 51;
            dgvClassroomData.Size = new Size(831, 379);
            dgvClassroomData.TabIndex = 12;
            // 
            // Classroomfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 486);
            Controls.Add(label1);
            Controls.Add(txtIDClassroom);
            Controls.Add(btnGetClassroomByID);
            Controls.Add(btnDeleteClassroom);
            Controls.Add(btnUpdateClassroom);
            Controls.Add(btnGetClassroom);
            Controls.Add(btnAddClassroom);
            Controls.Add(dgvClassroomData);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Classroomfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Classroom";
            ((System.ComponentModel.ISupportInitialize)dgvClassroomData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIDClassroom;
        private Button btnGetClassroomByID;
        private Button btnDeleteClassroom;
        private Button btnUpdateClassroom;
        private Button btnGetClassroom;
        private Button btnAddClassroom;
        private DataGridView dgvClassroomData;
    }
}