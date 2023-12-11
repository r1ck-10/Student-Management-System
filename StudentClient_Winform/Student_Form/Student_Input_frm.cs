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

namespace StudentClient_Winform.Student_Form
{
    public partial class Student_Input_frm : Form
    {
        public Student_Input_frm()
        {
            InitializeComponent();
        }
        private const string apiUrl = "http://localhost:5140/api/Students";


        private async void btnOk_Click(object sender, EventArgs e)
        {
            // Get user input from textboxes
            string name = txtName.Text;
            string dob = txtDOB.Text;
            string contact = txtContact.Text;
            string address = txtAddress.Text;
            string info = txtInfo.Text;

            // Create an anonymous object with the user input
            var newStudent = new
            {
                Name = name,
                DOB = dob,
                Contact = contact,
                Address = address,
                Info = info
            };

            // Convert student data to JSON
            var jsonStudent = JsonConvert.SerializeObject(newStudent);

            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                // Create HttpContent for the request body
                var content = new StringContent(jsonStudent, Encoding.UTF8, "application/json");

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
