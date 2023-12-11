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

namespace StudentClient_Winform.Classroom_Form
{
    public partial class Classroom_Input_frm : Form
    {
        public Classroom_Input_frm()
        {
            InitializeComponent();
        }
        private const string apiUrl = "http://localhost:5140/api/Classrooms";
        private async void btnOk_Click(object sender, EventArgs e)
        {
            // Get user input from textboxes
            string roomnuber = txtRoomnumber.Text;
            string schedule = txtSchedule.Text;
            string studentnumber = txtStudentNumber.Text;
            string course = txtCourse.Text;
            string Des = txtDescription.Text;

            // Create an anonymous object with the user input
            var newClassroom = new
            {
                RoomNuber = roomnuber,
                Schedule = schedule,
                StudentNumber = studentnumber,
                Course = course,
                Description = Des
            };

            // Convert student data to JSON
            var jsonClassroom = JsonConvert.SerializeObject(newClassroom);

            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                // Create HttpContent for the request body
                var content = new StringContent(jsonClassroom, Encoding.UTF8, "application/json");

                // Send POST request
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Classroom report created successfully!");
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
        }
    }
}
