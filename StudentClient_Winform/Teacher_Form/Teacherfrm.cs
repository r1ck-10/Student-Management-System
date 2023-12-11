using Newtonsoft.Json;
using StudentMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentClient_Winform.Teacher_Form
{
    public partial class Teacherfrm : Form
    {
        public Teacherfrm()
        {
            InitializeComponent();
        }
        private const string apiUrl = "http://localhost:5140/api/Teachers";
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            Teacher_Input_frm teacher_Input_Frm = new Teacher_Input_frm();
            teacher_Input_Frm.ShowDialog();
        }

        private async void btnGetTeacher_Click(object sender, EventArgs e)
        {
            dgvTeacherData.DataSource = null;
            dgvTeacherData.Columns.Clear();
            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send GET request
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and deserialize the response content
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        var students = JsonConvert.DeserializeObject<Student[]>(jsonContent);


                        // Populate DataGridView with student data
                        dgvTeacherData.DataSource = students;

                        // Optionally, customize the DataGridView appearance
                        CustomizeDataGridView();
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Exception: {ex.Message}");
                }
            }
        }
        private void CustomizeDataGridView()
        {
            // Optionally customize the DataGridView appearance
            dgvTeacherData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTeacherData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeacherData.AllowUserToAddRows = false;
            dgvTeacherData.ReadOnly = true;

        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            UpdateTeacherfrm updateTeacherfrm = new UpdateTeacherfrm();
            updateTeacherfrm.ShowDialog();
        }

        private async void btnDeleteTeacher_Click(object sender, EventArgs e)
        {

            // Check if any row is selected
            if (dgvTeacherData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Teacher to delete.");
                return;
            }

            // Get the selected student's ID from the DataGridView
            int selectedTeacherId = (int)dgvTeacherData.SelectedRows[0].Cells["ID"].Value;

            // Confirm with the user before deleting
            DialogResult result = MessageBox.Show($"Are you sure you want to delete teacher with ID {selectedTeacherId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Call the asynchronous method to delete the student
                await DeleteStudentByIdAsync(selectedTeacherId);
            }
        }
        static async Task DeleteStudentByIdAsync(int teacherId)
        {

            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send DELETE request to delete the specific student by ID
                    HttpResponseMessage response = await client.DeleteAsync($"{apiUrl}/{teacherId}");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Teacher with ID {teacherId} deleted successfully!");

                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Exception: {ex.Message}");
                }
            }
        }

        private async void btnGetTeacherbyID_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear DataGridView
                dgvTeacherData.DataSource = null;

                // Get student ID from TextBox
                if (!int.TryParse(txtIDTeacher.Text, out int teacherId))
                {
                    MessageBox.Show("Invalid input. Please enter a valid integer for the student ID.");
                    return;
                }

                // Create HttpClient instance
                using (HttpClient client = new HttpClient())
                {
                    // Send GET request to retrieve the specific student by ID
                    HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{teacherId}");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and deserialize the response content
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        var teacher = JsonConvert.DeserializeObject<Teacher>(jsonContent);

                        // Add columns dynamically if not added already
                        if (dgvTeacherData.Columns.Count == 0)
                        {
                            dgvTeacherData.Columns.Add("ID", "ID");
                            dgvTeacherData.Columns.Add("Name", "Name");
                            dgvTeacherData.Columns.Add("DOB", "DOB");
                            dgvTeacherData.Columns.Add("Contact", "Contact");
                            dgvTeacherData.Columns.Add("Address", "Address");
                            dgvTeacherData.Columns.Add("Skill", "Skill");
                            dgvTeacherData.Columns.Add("Class", "Class");
                            dgvTeacherData.Columns.Add("Info", "Info");
                        }

                        // Display the retrieved student data in DataGridView
                        dgvTeacherData.Rows.Add(teacher.Id, teacher.Name, teacher.DOB, teacher.Contact, teacher.Address, teacher.Skill, teacher.Class, teacher.Info);
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }
    }
}
