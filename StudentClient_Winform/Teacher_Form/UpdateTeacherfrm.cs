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

namespace StudentClient_Winform.Teacher_Form
{
    public partial class UpdateTeacherfrm : Form
    {
        public UpdateTeacherfrm()
        {
            InitializeComponent();
        }
        private const string apiUrl = "http://localhost:5140/api/Teachers";
        private async void btnOk_Click(object sender, EventArgs e)
        {
            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Get student ID from TextBox
                    if (!int.TryParse(txtID.Text, out int teacherId))
                    {
                        MessageBox.Show("Invalid input. Please enter a valid integer for the Teacher ID.");
                        return;
                    }

                    // Send GET request to retrieve all student data
                    HttpResponseMessage getResponse = await client.GetAsync(apiUrl);

                    // Check if the request was successful
                    if (getResponse.IsSuccessStatusCode)
                    {
                        // Read and deserialize the response content
                        string jsonContent = await getResponse.Content.ReadAsStringAsync();
                        var teachers = JsonConvert.DeserializeObject<Teacher[]>(jsonContent);

                        // Find the selected student by ID
                        var selectedteacher = teachers.FirstOrDefault(s => s.Id == teacherId);

                        if (selectedteacher == null)
                        {
                            MessageBox.Show($"No teacher found with ID {teacherId}.");
                            return;
                        }

                        // Ask the user which fields they want to update
                        MessageBox.Show($"Selected Teacher: ID: {selectedteacher.Id}, Name: {selectedteacher.Name}");

                        // Get updated values from textboxes
                        string updatedName = txtName.Text;
                        string updatedDOBString = txtDOB.Text;
                        string updatedContact = txtContact.Text;
                        string updatedAddress = txtAddress.Text;
                        string updatedSkill = txtskill.Text;
                        string updatedClass = txtclass.Text;
                        string updatedInfo = txtInfo.Text;

                        // Update only the non-empty fields
                        if (!string.IsNullOrEmpty(updatedName))
                            selectedteacher.Name = updatedName;

                        if (!string.IsNullOrEmpty(updatedDOBString))
                        {
                            // Convert the updated DOB string to DateTime
                            if (DateTime.TryParse(updatedDOBString, out DateTime updatedDOB))
                            {
                                selectedteacher.DOB = updatedDOB;
                            }
                            else
                            {
                                MessageBox.Show("Invalid date format. DOB not updated.");
                            }
                        }

                        if (!string.IsNullOrEmpty(updatedContact))
                            selectedteacher.Contact = updatedContact;

                        if (!string.IsNullOrEmpty(updatedAddress))
                            selectedteacher.Address = updatedAddress;

                        if (!string.IsNullOrEmpty(updatedSkill))
                            selectedteacher.Skill = updatedSkill;

                        if (!string.IsNullOrEmpty(updatedClass))
                            selectedteacher.Class = updatedClass;

                        if (!string.IsNullOrEmpty(updatedInfo))
                            selectedteacher.Info = updatedInfo;

                        // Convert the updated student data to JSON
                        var jsonUpdatedStudent = JsonConvert.SerializeObject(selectedteacher);

                        // Create HttpContent for the request body
                        var content = new StringContent(jsonUpdatedStudent, Encoding.UTF8, "application/json");

                        // Send PUT request to update the student data
                        HttpResponseMessage putResponse = await client.PutAsync($"{apiUrl}/{selectedteacher.Id}", content);

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
    }
}
