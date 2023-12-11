using Newtonsoft.Json;
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

namespace StudentClient_Winform.Enrollment_Form
{
    public partial class Enrollment_input_frm : Form
    {
        public Enrollment_input_frm()
        {
            InitializeComponent();
        }
        private const string apiUrl = "http://localhost:5140/api/Enrollments";
        private async void btnOk_Click(object sender, EventArgs e)
        {
            // Get user input from textboxes
            string studentID = txtStudentID.Text;
            string studentName = txtStudentName.Text;
            string courseID = txtCourseID.Text;
            string courseName = txtCourseName.Text;
            string enrollmentDate = txtEnrollDate.Text;
            string amount = txtAmount.Text;
            string discount = txtDiscount.Text;
            string description = txtDescription.Text;

            // Create an anonymous object with the user input
            var newEnrollment = new
            {
                StudentID = studentID,
                StudentName = studentName,
                CourseID = courseID,
                CourseName = courseName,
                EnrollmentDate = enrollmentDate,
                Amount = amount,
                Discount = discount,
                Description = description
            };
            // Convert enrollment data to JSON
            var jsonEnrollment = JsonConvert.SerializeObject(newEnrollment);

            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                // Create HttpContent for the request body
                var content = new StringContent(jsonEnrollment, Encoding.UTF8, "application/json");

                // Send POST request
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Student report created successfully!");
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
