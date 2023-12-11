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

namespace StudentClient_Winform.Course_Form
{
    public partial class Coursefrm : Form
    {
        public Coursefrm()
        {
            InitializeComponent();
        }
        private const string apiUrl = "http://localhost:5140/api/Courses";
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Course_Input_frm course_Input_Frm = new Course_Input_frm();
            course_Input_Frm.ShowDialog();
        }

        private async void btnGetCourse_Click(object sender, EventArgs e)
        {
            dgvCourseData.DataSource = null;
            dgvCourseData.Columns.Clear();
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
                        dgvCourseData.DataSource = students;

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
            dgvCourseData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCourseData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourseData.AllowUserToAddRows = false;
            dgvCourseData.ReadOnly = true;

        }

        private async void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dgvCourseData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Course to delete.");
                return;
            }

            // Get the selected student's ID from the DataGridView
            int selectedCourseId = (int)dgvCourseData.SelectedRows[0].Cells["ID"].Value;

            // Confirm with the user before deleting
            DialogResult result = MessageBox.Show($"Are you sure you want to delete Course with ID {selectedCourseId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Call the asynchronous method to delete the student
                await DeleteStudentByIdAsync(selectedCourseId);
            }
        }
        static async Task DeleteStudentByIdAsync(int CourseId)
        {

            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send DELETE request to delete the specific student by ID
                    HttpResponseMessage response = await client.DeleteAsync($"{apiUrl}/{CourseId}");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Course with ID {CourseId} deleted successfully!");

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

        private async void btnGetCoursebyID_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear DataGridView
                dgvCourseData.DataSource = null;

                // Get enrollment ID from TextBox
                if (!int.TryParse(txtCourseID.Text, out int courseId))
                {
                    MessageBox.Show("Invalid input. Please enter a valid integer for the Course ID.");
                    return;
                }

                // Create HttpClient instance
                using (HttpClient client = new HttpClient())
                {
                    // Send GET request to retrieve the specific enrollment by ID
                    HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{courseId}");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and deserialize the response content
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        var course = JsonConvert.DeserializeObject<Course>(jsonContent);

                        // Add columns dynamically if not added already
                        if (dgvCourseData.Columns.Count == 0)
                        {
                            dgvCourseData.Columns.Add("EnrollmentID", "Enrollment ID");
                            dgvCourseData.Columns.Add("StudentID", "Student ID");
                            dgvCourseData.Columns.Add("StudentName", "Student Name");
                            dgvCourseData.Columns.Add("CourseID", "Course ID");
                            dgvCourseData.Columns.Add("CourseName", "Course Name");
                            dgvCourseData.Columns.Add("EnrollmentDate", "Enrollment Date");
                            dgvCourseData.Columns.Add("Amount", "Amount");
                            dgvCourseData.Columns.Add("Discount", "Discount");
                            dgvCourseData.Columns.Add("Description", "Description");
                        }

                        // Display the retrieved enrollment data in DataGridView
                        dgvCourseData.Rows.Add(course.CourseName, course.TeacherId, course.TeacherName, course.CoursePrice, course.CourseDescription);
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
