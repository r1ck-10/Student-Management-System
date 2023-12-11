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

namespace StudentClient_Winform.Student_Form
{
    public partial class Studentfrm : Form
    {
        public Studentfrm()
        {
            InitializeComponent();
        }
        private const string apiUrl = "http://localhost:5140/api/Students";
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student_Input_frm frm = new Student_Input_frm();
            frm.ShowDialog();
        }

        private async void btnGetstudent_Click(object sender, EventArgs e)
        {
            dgvStudentData.DataSource = null;
            dgvStudentData.Columns.Clear();
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
                        dgvStudentData.DataSource = students;

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
            dgvStudentData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudentData.AllowUserToAddRows = false;
            dgvStudentData.ReadOnly = true;

        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            UpdateStudentfrm updatestudentfrm = new UpdateStudentfrm();
            updatestudentfrm.ShowDialog();
        }

        private async void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dgvStudentData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            // Get the selected student's ID from the DataGridView
            int selectedStudentId = (int)dgvStudentData.SelectedRows[0].Cells["ID"].Value;

            // Confirm with the user before deleting
            DialogResult result = MessageBox.Show($"Are you sure you want to delete student with ID {selectedStudentId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Call the asynchronous method to delete the student
                await DeleteStudentByIdAsync(selectedStudentId);
            }
        }
        static async Task DeleteStudentByIdAsync(int studentId)
        {

            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send DELETE request to delete the specific student by ID
                    HttpResponseMessage response = await client.DeleteAsync($"{apiUrl}/{studentId}");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Student with ID {studentId} deleted successfully!");

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

        private async void btnSeach_byID_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear DataGridView
                dgvStudentData.DataSource = null;

                // Get student ID from TextBox
                if (!int.TryParse(txtID.Text, out int studentId))
                {
                    MessageBox.Show("Invalid input. Please enter a valid integer for the student ID.");
                    return;
                }

                // Create HttpClient instance
                using (HttpClient client = new HttpClient())
                {
                    // Send GET request to retrieve the specific student by ID
                    HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{studentId}");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and deserialize the response content
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        var student = JsonConvert.DeserializeObject<Student>(jsonContent);

                        // Add columns dynamically if not added already
                        if (dgvStudentData.Columns.Count == 0)
                        {
                            dgvStudentData.Columns.Add("ID", "ID");
                            dgvStudentData.Columns.Add("Name", "Name");
                            dgvStudentData.Columns.Add("DOB", "DOB");
                            dgvStudentData.Columns.Add("Contact", "Contact");
                            dgvStudentData.Columns.Add("Address", "Address");
                            dgvStudentData.Columns.Add("Info", "Info");
                        }

                        // Display the retrieved student data in DataGridView
                        dgvStudentData.Rows.Add(student.Id, student.Name, student.DOB, student.Contact, student.Address, student.Info);
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
