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
using System.Xml.Linq;

namespace StudentClient_Winform.Classroom_Form
{
    public partial class UpdateClassroomfrm : Form
    {
        public UpdateClassroomfrm()
        {
            InitializeComponent();
        }
        private const string apiUrl = "http://localhost:5140/api/Classrooms";
        private async void btnOk_Click(object sender, EventArgs e)
        {
            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Get student ID from TextBox
                    if (!int.TryParse(txtClassroomID.Text, out int classroomId))
                    {
                        MessageBox.Show("Invalid input. Please enter a valid integer for the classroom ID.");
                        return;
                    }

                    // Send GET request to retrieve all student data
                    HttpResponseMessage getResponse = await client.GetAsync(apiUrl);

                    // Check if the request was successful
                    if (getResponse.IsSuccessStatusCode)
                    {
                        // Read and deserialize the response content
                        string jsonContent = await getResponse.Content.ReadAsStringAsync();
                        var classrooms = JsonConvert.DeserializeObject<Classroom[]>(jsonContent);

                        // Find the selected student by ID
                        var selectedClassroom = classrooms.FirstOrDefault(s => s.Id == classroomId);

                        if (selectedClassroom == null)
                        {
                            MessageBox.Show($"No Classroom found with ID {classroomId}.");
                            return;
                        }

                        // Ask the user which fields they want to update
                        MessageBox.Show($"Selected Classroom: ID: {selectedClassroom.Id}, Name: {selectedClassroom.RoomNumber}");

                        // Get updated values from textboxes
                        string updatedroomnuber = txtRoomnumber.Text;
                        string updatedschedule = txtSchedule.Text;
                        string updatedstudentnumber = txtStudentNumber.Text;
                        string updatedcourse = txtCourse.Text;
                        string updatedDes = txtDescription.Text;

                        // Update only the non-empty fields
                        if (!string.IsNullOrEmpty(updatedroomnuber))
                            selectedClassroom.RoomNumber = updatedroomnuber;


                        if (!string.IsNullOrEmpty(updatedschedule))
                            selectedClassroom.Schedule = updatedschedule;

                        if (!string.IsNullOrEmpty(updatedstudentnumber))
                            selectedClassroom.StudentNumber = Convert.ToInt32(updatedstudentnumber);

                        if (!string.IsNullOrEmpty(updatedcourse))
                            selectedClassroom.Course = updatedcourse;

                        if (!string.IsNullOrEmpty(updatedDes))
                            selectedClassroom.Description = updatedDes;

                        // Convert the updated student data to JSON
                        var jsonUpdatedClassroom = JsonConvert.SerializeObject(selectedClassroom);

                        // Create HttpContent for the request body
                        var content = new StringContent(jsonUpdatedClassroom, Encoding.UTF8, "application/json");

                        // Send PUT request to update the student data
                        HttpResponseMessage putResponse = await client.PutAsync($"{apiUrl}/{selectedClassroom.Id}", content);

                        // Check if the request was successful
                        if (putResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Classroom data updated successfully!");
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
    }
}
