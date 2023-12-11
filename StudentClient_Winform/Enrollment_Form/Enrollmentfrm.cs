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

namespace StudentClient_Winform.Enrollment_Form
{
    public partial class Enrollmentfrm : Form
    {
        public Enrollmentfrm()
        {
            InitializeComponent();
        }
        private const string apiUrl = "http://localhost:5140/api/Enrollments";
        private void btnAddEnroll_Click(object sender, EventArgs e)
        {
            Enrollment_input_frm enrollment_Input_Frm = new Enrollment_input_frm();
            enrollment_Input_Frm.ShowDialog();
        }

        private async void btnGetEnrollment_Click(object sender, EventArgs e)
        {
            dgvEnrollData.DataSource = null;
            dgvEnrollData.Columns.Clear();
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
                        var students = JsonConvert.DeserializeObject<Enrollment[]>(jsonContent);


                        // Populate DataGridView with student data
                        dgvEnrollData.DataSource = students;

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
            dgvEnrollData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvEnrollData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEnrollData.AllowUserToAddRows = false;
            dgvEnrollData.ReadOnly = true;

        }

        private void btnupdateEnroll_Click(object sender, EventArgs e)
        {
            UpdateEnrollmentfrm updateEnrollmentfrm = new UpdateEnrollmentfrm();
            updateEnrollmentfrm.ShowDialog();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dgvEnrollData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Enrollment to delete.");
                return;
            }

            // Get the selected student's ID from the DataGridView
            int selectedEnrollmentId = (int)dgvEnrollData.SelectedRows[0].Cells["ID"].Value;

            // Confirm with the user before deleting
            DialogResult result = MessageBox.Show($"Are you sure you want to delete Enrollment with ID {selectedEnrollmentId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Call the asynchronous method to delete the student
                await DeleteStudentByIdAsync(selectedEnrollmentId);
            }
        }
        static async Task DeleteStudentByIdAsync(int enrollmentId)
        {

            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send DELETE request to delete the specific student by ID
                    HttpResponseMessage response = await client.DeleteAsync($"{apiUrl}/{enrollmentId}");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Enrollment with ID {enrollmentId} deleted successfully!");

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

        private async void btnGetbyID_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear DataGridView
                dgvEnrollData.DataSource = null;

                // Get enrollment ID from TextBox
                if (!int.TryParse(txtEnrollmentID.Text, out int enrollmentId))
                {
                    MessageBox.Show("Invalid input. Please enter a valid integer for the enrollment ID.");
                    return;
                }

                // Create HttpClient instance
                using (HttpClient client = new HttpClient())
                {
                    // Send GET request to retrieve the specific enrollment by ID
                    HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{enrollmentId}");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and deserialize the response content
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        var enrollment = JsonConvert.DeserializeObject<Enrollment>(jsonContent);

                        // Add columns dynamically if not added already
                        if (dgvEnrollData.Columns.Count == 0)
                        {
                            dgvEnrollData.Columns.Add("EnrollmentID", "Enrollment ID");
                            dgvEnrollData.Columns.Add("StudentID", "Student ID");
                            dgvEnrollData.Columns.Add("StudentName", "Student Name");
                            dgvEnrollData.Columns.Add("CourseID", "Course ID");
                            dgvEnrollData.Columns.Add("CourseName", "Course Name");
                            dgvEnrollData.Columns.Add("EnrollmentDate", "Enrollment Date");
                            dgvEnrollData.Columns.Add("Amount", "Amount");
                            dgvEnrollData.Columns.Add("Discount", "Discount");
                            dgvEnrollData.Columns.Add("Description", "Description");
                        }

                        // Display the retrieved enrollment data in DataGridView
                        dgvEnrollData.Rows.Add(enrollment.Id, enrollment.StudentId, enrollment.StudentName, enrollment.CourseId, enrollment.CourseName, enrollment.EnrollmentDate, enrollment.Amount, enrollment.Discount, enrollment.Description);
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
