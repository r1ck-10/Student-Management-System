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
    public partial class UpdateStudentfrm : Form
    {
        public UpdateStudentfrm()
        {
            InitializeComponent();
        }
        string apiUrl = "http://localhost:5140/api/Students";

        private async void btnOk_Click(object sender, EventArgs e)
        {
            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Get student ID from TextBox
                    if (!int.TryParse(txtID.Text, out int studentId))
                    {
                        MessageBox.Show("Invalid input. Please enter a valid integer for the student ID.");
                        return;
                    }

                    // Send GET request to retrieve all student data
                    HttpResponseMessage getResponse = await client.GetAsync(apiUrl);

                    // Check if the request was successful
                    if (getResponse.IsSuccessStatusCode)
                    {
                        // Read and deserialize the response content
                        string jsonContent = await getResponse.Content.ReadAsStringAsync();
                        var students = JsonConvert.DeserializeObject<Student[]>(jsonContent);

                        // Find the selected student by ID
                        var selectedStudent = students.FirstOrDefault(s => s.Id == studentId);

                        if (selectedStudent == null)
                        {
                            MessageBox.Show($"No student found with ID {studentId}.");
                            return;
                        }

                        // Ask the user which fields they want to update
                        MessageBox.Show($"Selected student: ID: {selectedStudent.Id}, Name: {selectedStudent.Name}");

                        // Get updated values from textboxes
                        string updatedName = txtName.Text;
                        string updatedDOBString = txtDOB.Text;
                        string updatedContact = txtContact.Text;
                        string updatedAddress = txtAddress.Text;
                        string updatedInfo = txtInfo.Text;

                        // Update only the non-empty fields
                        if (!string.IsNullOrEmpty(updatedName))
                            selectedStudent.Name = updatedName;

                        if (!string.IsNullOrEmpty(updatedDOBString))
                        {
                            // Convert the updated DOB string to DateTime
                            if (DateTime.TryParse(updatedDOBString, out DateTime updatedDOB))
                            {
                                selectedStudent.DOB = updatedDOB;
                            }
                            else
                            {
                                MessageBox.Show("Invalid date format. DOB not updated.");
                            }
                        }

                        if (!string.IsNullOrEmpty(updatedContact))
                            selectedStudent.Contact = updatedContact;

                        if (!string.IsNullOrEmpty(updatedAddress))
                            selectedStudent.Address = updatedAddress;

                        if (!string.IsNullOrEmpty(updatedInfo))
                            selectedStudent.Info = updatedInfo;

                        // Convert the updated student data to JSON
                        var jsonUpdatedStudent = JsonConvert.SerializeObject(selectedStudent);

                        // Create HttpContent for the request body
                        var content = new StringContent(jsonUpdatedStudent, Encoding.UTF8, "application/json");

                        // Send PUT request to update the student data
                        HttpResponseMessage putResponse = await client.PutAsync($"{apiUrl}/{selectedStudent.Id}", content);

                        // Check if the request was successful
                        if (putResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Student data updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show($"Error: {putResponse.StatusCode} - {putResponse.ReasonPhrase}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error: {getResponse.StatusCode} - {getResponse.ReasonPhrase}");
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Exception: {ex.Message}");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
