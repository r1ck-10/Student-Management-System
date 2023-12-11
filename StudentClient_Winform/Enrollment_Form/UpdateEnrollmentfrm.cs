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
    public partial class UpdateEnrollmentfrm : Form
    {
        public UpdateEnrollmentfrm()
        {
            InitializeComponent();
        }
        string apiUrl = "http://localhost:5140/api/Enrollments";
        private async void btnOk_Click(object sender, EventArgs e)
        {
            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Get enrollment ID from TextBox
                    if (!int.TryParse(txtEnrollmentID.Text, out int enrollmentId))
                    {
                        MessageBox.Show("Invalid input. Please enter a valid integer for the enrollment ID.");
                        return;
                    }

                    // Send GET request to retrieve all enrollment data
                    HttpResponseMessage getResponse = await client.GetAsync(apiUrl);

                    // Check if the request was successful
                    if (getResponse.IsSuccessStatusCode)
                    {
                        // Read and deserialize the response content
                        string jsonContent = await getResponse.Content.ReadAsStringAsync();
                        var enrollments = JsonConvert.DeserializeObject<Enrollment[]>(jsonContent);

                        // Find the selected enrollment by ID
                        var selectedEnrollment = enrollments.FirstOrDefault(enrollment => enrollment.Id == enrollmentId);

                        if (selectedEnrollment == null)
                        {
                            MessageBox.Show($"No enrollment found with ID {enrollmentId}.");
                            return;
                        }

                        // Ask the user which fields they want to update
                        MessageBox.Show($"Selected enrollment: ID: {selectedEnrollment.Id}, Name: {selectedEnrollment.StudentName}");

                        // Get updated values from textboxes
                        string updatedName = txtStudentName.Text;
                        string updatedCourseID = txtCourseID.Text;
                        string updatedCourseName = txtCourseName.Text;
                        string updatedEnrollmentDate = txtEnrollDate.Text;
                        string updatedAmount = txtAmount.Text;
                        string updatedDiscount = txtDiscount.Text;
                        string updatedDescription = txtDescription.Text;

                        // Update only the non-empty fields
                        if (!string.IsNullOrEmpty(updatedName))
                            selectedEnrollment.StudentName = updatedName;

                        // Update other fields as needed

                        // Convert the updated enrollment data to JSON
                        var jsonUpdatedEnrollment = JsonConvert.SerializeObject(selectedEnrollment);

                        // Create HttpContent for the request body
                        var content = new StringContent(jsonUpdatedEnrollment, Encoding.UTF8, "application/json");

                        // Send PUT request to update the enrollment data
                        HttpResponseMessage putResponse = await client.PutAsync($"{apiUrl}/{selectedEnrollment.Id}", content);

                        // Check if the request was successful
                        if (putResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Enrollment data updated successfully!");
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
