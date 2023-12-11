using Microsoft.VisualBasic.Devices;
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

namespace StudentClient_Winform.Classroom_Form
{
    public partial class Classroomfrm : Form
    {
        public Classroomfrm()
        {
            InitializeComponent();
        }
        private const string apiUrl = "http://localhost:5140/api/Classrooms";
        private void btnAddClassroom_Click(object sender, EventArgs e)
        {
            Classroom_Input_frm classroom_Input_Frm = new Classroom_Input_frm();
            classroom_Input_Frm.ShowDialog();
        }

        private async void btnGetClassroom_Click(object sender, EventArgs e)
        {
            dgvClassroomData.DataSource = null;
            dgvClassroomData.Columns.Clear();
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
                        var classrooms = JsonConvert.DeserializeObject<Classroom[]>(jsonContent);


                        // Populate DataGridView with student data
                        dgvClassroomData.DataSource = classrooms;

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
            dgvClassroomData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClassroomData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClassroomData.AllowUserToAddRows = false;
            dgvClassroomData.ReadOnly = true;

        }

        private void btnUpdateClassroom_Click(object sender, EventArgs e)
        {
            UpdateClassroomfrm updateClassroomfrm = new UpdateClassroomfrm();
            updateClassroomfrm.ShowDialog();
        }

        private async void btnDeleteClassroom_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dgvClassroomData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Classroom to delete.");
                return;
            }

            // Get the selected student's ID from the DataGridView
            int selectedClassroomId = (int)dgvClassroomData.SelectedRows[0].Cells["ID"].Value;

            // Confirm with the user before deleting
            DialogResult result = MessageBox.Show($"Are you sure you want to delete Classroom with ID {selectedClassroomId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Call the asynchronous method to delete the student
                await DeleteStudentByIdAsync(selectedClassroomId);
            }
        }
        static async Task DeleteStudentByIdAsync(int ClassroomId)
        {

            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send DELETE request to delete the specific student by ID
                    HttpResponseMessage response = await client.DeleteAsync($"{apiUrl}/{ClassroomId}");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Classroom with ID {ClassroomId} deleted successfully!");

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

        private async void btnGetClassroomByID_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear DataGridView
                dgvClassroomData.DataSource = null;

                // Get student ID from TextBox
                if (!int.TryParse(txtIDClassroom.Text, out int classroomId))
                {
                    MessageBox.Show("Invalid input. Please enter a valid integer for the Classroom ID.");
                    return;
                }

                // Create HttpClient instance
                using (HttpClient client = new HttpClient())
                {
                    // Send GET request to retrieve the specific student by ID
                    HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{classroomId}");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and deserialize the response content
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        var classroom = JsonConvert.DeserializeObject<Classroom>(jsonContent);

                        // Add columns dynamically if not added already
                        if (dgvClassroomData.Columns.Count == 0)
                        {
                            dgvClassroomData.Columns.Add("RoomNumber", "Room Number");
                            dgvClassroomData.Columns.Add("Schedule", "Schedule");
                            dgvClassroomData.Columns.Add("StudentNumber", "Student Number");
                            dgvClassroomData.Columns.Add("Course", "Course");
                            dgvClassroomData.Columns.Add("Description", "Description");
                        }

                        // Display the retrieved classroom data in DataGridView
                        dgvClassroomData.Rows.Add(classroom.RoomNumber, classroom.Schedule, classroom.StudentNumber, classroom.Course, classroom.Description);
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
