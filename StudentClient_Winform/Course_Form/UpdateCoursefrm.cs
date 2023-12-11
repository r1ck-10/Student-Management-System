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
    public partial class UpdateCoursefrm : Form
    {
        public UpdateCoursefrm()
        {
            InitializeComponent();
        }
        string apiUrl = "http://localhost:5140/api/Courses";
        private async void btnOk_Click(object sender, EventArgs e)
        {
            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Get course ID from TextBox
                    if (!int.TryParse(txtCourseIDforUpdate.Text, out int courseId))
                    {
                        MessageBox.Show("Invalid input. Please enter a valid integer for the course ID.");
                        return;
                    }

                    // Send GET request to retrieve all course data
                    HttpResponseMessage getResponse = await client.GetAsync(apiUrl);

                    // Check if the request was successful
                    if (getResponse.IsSuccessStatusCode)
                    {
                        // Read and deserialize the response content
                        string jsonContent = await getResponse.Content.ReadAsStringAsync();
                        var courses = JsonConvert.DeserializeObject<Course[]>(jsonContent);

                        // Find the selected course by ID
                        var selectedCourse = courses.FirstOrDefault(course => course.Id == courseId);

                        if (selectedCourse == null)
                        {
                            MessageBox.Show($"No course found with ID {courseId}.");
                            return;
                        }

                        // Ask the user which fields they want to update
                        MessageBox.Show($"Selected course: ID: {selectedCourse.Id}, Name: {selectedCourse.CourseName}");

                        // Get updated values from textboxes
                        string updatedCourseName = txtCourseInputName.Text;
                        string updatedTeacherID = txtTeacherInputID.Text;
                        string updatedTeacherName = txtTeacherInputName.Text;
                        string updatedCoursePrice = txtCoursePrice.Text;
                        string updatedCourseDes = txtCourseDes.Text;

                        // Update only the non-empty fields
                        if (!string.IsNullOrEmpty(updatedCourseName))
                            selectedCourse.CourseName = updatedCourseName;

                        if (!string.IsNullOrEmpty(updatedTeacherID))
                            selectedCourse.TeacherId = Convert.ToInt32(updatedTeacherID);

                        if (!string.IsNullOrEmpty(updatedTeacherName))
                            selectedCourse.TeacherName = updatedTeacherName;

                        if (!string.IsNullOrEmpty(updatedCoursePrice))
                            selectedCourse.CoursePrice = Convert.ToInt32(updatedCoursePrice);

                        if (!string.IsNullOrEmpty(updatedCourseDes))
                            selectedCourse.CourseDescription = updatedCourseDes;

                        // Convert the updated course data to JSON
                        var jsonUpdatedCourse = JsonConvert.SerializeObject(selectedCourse);

                        // Create HttpContent for the request body
                        var content = new StringContent(jsonUpdatedCourse, Encoding.UTF8, "application/json");

                        // Send PUT request to update the course data
                        HttpResponseMessage putResponse = await client.PutAsync($"{apiUrl}/{selectedCourse.Id}", content);

                        // Check if the request was successful
                        if (putResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Course data updated successfully!");
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
