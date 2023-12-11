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

namespace StudentClient_Winform.Teacher_Form
{
    public partial class Teacher_Input_frm : Form
    {
        public Teacher_Input_frm()
        {
            InitializeComponent();
        }
        private const string apiUrl = "http://localhost:5140/api/Teachers";
        private async void btnOk_Click(object sender, EventArgs e)
        {
            // Get user input from textboxes
            string name = txtName.Text;
            string dob = txtDOB.Text;
            string contact = txtContact.Text;
            string address = txtAddress.Text;
            string skill = txtskill.Text;
            string classroom = txtclass.Text; 
            string info = txtInfo.Text;

            // Create an anonymous object with the user input
            var newTeacher = new
            {
                Name = name,
                DOB = dob,
                Contact = contact,
                Address = address,
                Skill = skill,
                Class = classroom,
                Info = info
            };

            // Convert student data to JSON
            var jsonTeacher = JsonConvert.SerializeObject(newTeacher);

            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                // Create HttpContent for the request body
                var content = new StringContent(jsonTeacher, Encoding.UTF8, "application/json");

                // Send POST request
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Teacher report created successfully!");
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
        }
    }
}
