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
    public partial class Course_Input_frm : Form
    {
        public Course_Input_frm()
        {
            InitializeComponent();
        }
        private const string apiUrl = "http://localhost:5140/api/Courses";
        private async void btnOk_Click(object sender, EventArgs e)
        {
            string coursename = txtCourseInputName.Text;
            string teacherID = txtTeacherInputID.Text;
            string teacherName = txtTeacherInputName.Text;
            string courseprice = txtCoursePrice.Text;
            string coursedes = txtCourseDes.Text;


            var newCourse = new
            {
                CourseName = coursename,
                TeacherID = teacherID,
                TeacherName = teacherName,
                CoursePrice = courseprice,
                CourseDescription = coursedes
            };

            // Convert enrollment data to JSON
            var jsonCourse = JsonConvert.SerializeObject(newCourse);

            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                // Create HttpContent for the request body
                var content = new StringContent(jsonCourse, Encoding.UTF8, "application/json");

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
