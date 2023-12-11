using Newtonsoft.Json;
using StudentMS.Models;
using System.Text;

internal class Program
{
    static async Task Main()
    {
        while (true)
        {
            Console.WriteLine("Welcome To Student Management System APP!");
            mainop();
            Console.Write("Please choose one option (or type 'exit' to exit): ");
            string op = Console.ReadLine();

            if (op.ToLower() == "exit")
            {
                break;
            }

            switch (op)
            {
                case "1":
                    op1();
                    Console.Write("Please choose one option: ");
                    string op_Student = Console.ReadLine();
                    if (op_Student == "1")
                    {
                        await CreateStudentReportAsync();
                    }
                    else if (op_Student == "2")
                    {
                        await GetStudentDataAsync();
                    }
                    else if (op_Student == "3")
                    {
                        await GetStudentByIdAsync();
                    }
                    else if (op_Student == "4")
                    {
                        await UpdateStudentDataAsync();
                    }
                    else if (op_Student == "5")
                    {
                        await DeleteStudentByIdAsync();
                    }
                    break;
                case "2":
                    op2();
                    Console.Write("Please choose one option: ");
                    string op_Enrollment = Console.ReadLine();
                    if (op_Enrollment == "1")
                    {
                        await CreateEnrollmentAsync();
                    }
                    else if (op_Enrollment == "2")
                    {
                        await GetEnrollmentsAsync();
                    }
                    else if (op_Enrollment == "3")
                    {
                        await GetEnrollmentByIdAsync();
                    }
                    else if (op_Enrollment == "4")
                    {
                        await UpdateEnrollmentAsync();
                    }
                    else if (op_Enrollment == "5")
                    {
                        await DeleteEnrollmentAsync();
                    }
                    break;
                case "3":
                    op3();
                    Console.Write("Please choose one option: ");
                    string op_Course = Console.ReadLine();
                    if (op_Course == "1")
                    {
                        await CreateCourseAsync();
                    }
                    else if (op_Course == "2")
                    {
                        await GetCoursesAsync();
                    }
                    else if (op_Course == "3")
                    {
                        await GetCourseByIdAsync();
                    }
                    else if (op_Course == "4")
                    {
                        await UpdateCourseAsync();
                    }
                    else if (op_Course == "5")
                    {
                        await DeleteCourseAsync();
                    }
                    break;
                case "4":
                    op4();
                    Console.Write("Please choose one option: ");
                    string op_Teacher = Console.ReadLine();
                    if (op_Teacher == "1")
                    {
                        await CreateTeacherAsync();
                    }
                    else if (op_Teacher == "2")
                    {
                        await GetTeachersAsync();
                    }
                    else if (op_Teacher == "3")
                    {
                        await GetTeacherByIdAsync();
                    }
                    else if (op_Teacher == "4")
                    {
                        await UpdateTeacherAsync();
                    }
                    else if (op_Teacher == "5")
                    {
                        await DeleteTeacherAsync();
                    }
                    break;
                case "5":
                    op5();
                    Console.Write("Please choose one option: ");
                    string op_class = Console.ReadLine();
                    if (op_class == "1")
                    {
                        await CreateClassAsync();
                    }
                    else if (op_class == "2")
                    {
                        await GetClassesAsync();
                    }
                    else if (op_class == "3")
                    {
                        await GetClassByIdAsync();
                    }
                    else if (op_class == "4")
                    {
                        await UpdateClassAsync();
                    }
                    else if (op_class == "5")
                    {
                        await DeleteClassAsync();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }
    }



    //Options
    public static void mainop()
    {
        Console.WriteLine(""""
            [1]. Student
            [2]. Enrollment
            [3]. Course
            [4]. Teacher
            [5]. Classroom
            """");
    }
    public static void op1()
    {
        Console.WriteLine("""
            [1]. Create Student Record
            [2]. Get all Student Records
            [3]. Get Student Record by ID
            [4]. Update Student Record
            [5]. Delete Student Record
            """);
    }
    public static void op2()
    {
        Console.WriteLine("""
        [1]. Create Enrollment Record
        [2]. Get all Enrollment Records
        [3]. Get Enrollment Record by ID
        [4]. Update Enrollment Record
        [5]. Delete Enrollment Record
        """);
    }
    public static void op3()
    {
        Console.WriteLine("""
        [1]. Create Course Record
        [2]. Get all Course Records
        [3]. Get Course Record by ID
        [4]. Update Course Record
        [5]. Delete Course Record
        """);
    }
    public static void op4()
    {
        Console.WriteLine("""
        [1]. Create Teacher Record
        [2]. Get all Teacher Records
        [3]. Get Teacher Record by ID
        [4]. Update Teacher Record
        [5]. Delete Teacher Record
        """);
    }
    public static void op5()
    {
        Console.WriteLine("""
    [1]. Create Classroom Record
    [2]. Get all Classroom Records
    [3]. Get Classroom Record by ID
    [4]. Update Classroom Record
    [5]. Delete Classroom Record
    """);
    }

    //students
    static async Task GetStudentDataAsync()
    {
        // API endpoint URL
        string apiUrl = "http://localhost:5140/api/Students";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Send GET request
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    var students = JsonConvert.DeserializeObject<Student[]>(jsonContent);

                    // Display the retrieved student data in a table
                    Console.WriteLine("+--------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| ID | Name            | DOB                  | Contact | Address          | Info            |");
                    Console.WriteLine("+--------------------------------------------------------------------------------------------+");

                    foreach (var student in students)
                    {
                        Console.WriteLine($"| {student.Id,-3} | {student.Name,-15} | {student.DOB,-20:MM/dd/yyyy} | {student.Contact,-5} | {student.Address,-18} | {student.Info,-11} |");
                    }

                    Console.WriteLine("+--------------------------------------------------------------------------------------------+");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task CreateStudentReportAsync()
    {
        // API endpoint URL
        string apiUrl = "http://localhost:5140/api/Students";


        // Get user input for student data
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter date of birth (yyyy-mm-dd): ");
        string dob = Console.ReadLine();

        Console.Write("Enter contact number: ");
        string contact = Console.ReadLine();

        Console.Write("Enter address: ");
        string address = Console.ReadLine();

        Console.Write("Enter additional information: ");
        string info = Console.ReadLine();

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
                Console.WriteLine("Student report created successfully!");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }
    }
    static async Task UpdateStudentDataAsync()
    {
        // API endpoint URL
        string apiUrl = "http://localhost:5140/api/Students";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Send GET request to retrieve all student data
                HttpResponseMessage getResponse = await client.GetAsync(apiUrl);

                // Check if the request was successful
                if (getResponse.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await getResponse.Content.ReadAsStringAsync();
                    var students = JsonConvert.DeserializeObject<Student[]>(jsonContent);

                    // Display the retrieved student data
                    Console.WriteLine("Student Data:");
                    Console.WriteLine("+" + new string('-', 78) + "+");
                    Console.WriteLine("| ID | Name            | DOB       | Contact | Address            | Info            |");
                    Console.WriteLine("+" + new string('-', 78) + "+");

                    foreach (var student in students)
                    {
                        Console.WriteLine($"| {student.Id,-3} | {student.Name,-15} | {student.DOB,-10} | {student.Contact,-8} | {student.Address,-18} | {student.Info,-15} |");
                    }

                    Console.WriteLine("+" + new string('-', 78) + "+");

                    // Ask the user for the student ID to update
                    Console.Write("Enter the ID of the student you want to update: ");
                    int studentId;
                    if (!int.TryParse(Console.ReadLine(), out studentId))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        return;
                    }

                    // Find the selected student by ID
                    var selectedStudent = students.FirstOrDefault(s => s.Id == studentId);

                    if (selectedStudent == null)
                    {
                        Console.WriteLine($"No student found with ID {studentId}.");
                        return;
                    }

                    // Ask the user which fields they want to update
                    Console.WriteLine($"Selected student: ID: {selectedStudent.Id}, Name: {selectedStudent.Name}");

                    Console.Write("Enter updated Name (press Enter to skip): ");
                    string updatedName = Console.ReadLine();

                    Console.Write("Enter updated DOB (press Enter to skip): ");
                    string updatedDOBString = Console.ReadLine();

                    Console.Write("Enter updated Contact (press Enter to skip): ");
                    string updatedContact = Console.ReadLine();

                    Console.Write("Enter updated Address (press Enter to skip): ");
                    string updatedAddress = Console.ReadLine();

                    Console.Write("Enter updated Info (press Enter to skip): ");
                    string updatedInfo = Console.ReadLine();

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
                            Console.WriteLine("Invalid date format. DOB not updated.");
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
                        Console.WriteLine("Student data updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine($"Error: {putResponse.StatusCode} - {putResponse.ReasonPhrase}");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {getResponse.StatusCode} - {getResponse.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }

    static async Task DeleteStudentByIdAsync()
    {
        // API endpoint URL
        string apiUrl = "http://localhost:5140/api/Students";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the student ID to delete
                Console.Write("Enter the ID of the student you want to delete: ");
                int studentId;
                if (!int.TryParse(Console.ReadLine(), out studentId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send DELETE request to delete the specific student by ID
                HttpResponseMessage response = await client.DeleteAsync($"{apiUrl}/{studentId}");

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Student with ID {studentId} deleted successfully!");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task GetStudentByIdAsync()
    {
        // API endpoint URL
        string apiUrl = "http://localhost:5140/api/Students";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the student ID to retrieve
                Console.Write("Enter the ID of the student you want to retrieve: ");
                int studentId;
                if (!int.TryParse(Console.ReadLine(), out studentId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send GET request to retrieve the specific student by ID
                HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{studentId}");

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    var student = JsonConvert.DeserializeObject<Student>(jsonContent);

                    // Display the retrieved student data
                    Console.WriteLine($"Student Data for ID {studentId}:");
                    Console.WriteLine("+" + new string('-', 78) + "+");
                    Console.WriteLine("| ID | Name            | DOB       | Contact | Address            | Info            |");
                    Console.WriteLine("+" + new string('-', 78) + "+");

                    Console.WriteLine($"| {student.Id,-3} | {student.Name,-15} | {student.DOB,-10} | {student.Contact,-8} | {student.Address,-18} | {student.Info,-15} |");

                    Console.WriteLine("+" + new string('-', 78) + "+");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }

    //enrollment
    static async Task CreateEnrollmentAsync()
    {
        // API endpoint URL for Enrollment
        string apiUrl = "http://localhost:5140/api/Enrollments";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for Enrollment data
                Console.WriteLine("Enter Enrollment data:");

                Console.Write("Enter Student ID: ");
                int studentId = int.Parse(Console.ReadLine());

                Console.Write("Enter Student Name: ");
                string studentName = Console.ReadLine();

                Console.Write("Enter Course ID: ");
                int courseId = int.Parse(Console.ReadLine());

                Console.Write("Enter Course Name: ");
                string courseName = Console.ReadLine();

                Console.Write("Enter Enrollment Date (yyyy-mm-dd): ");
                string enrollmentDate = Console.ReadLine();

                Console.Write("Enter Amount: ");
                int amount = int.Parse(Console.ReadLine());

                Console.Write("Enter Discount: ");
                int discount = int.Parse(Console.ReadLine());

                Console.Write("Enter Description: ");
                string description = Console.ReadLine();

                // Create an anonymous object with the Enrollment data
                var newEnrollment = new
                {
                    StudentId = studentId,
                    StudentName = studentName,
                    CourseId = courseId,
                    CourseName = courseName,
                    EnrollmentDate = enrollmentDate,
                    Amount = amount,
                    Discount = discount,
                    Description = description
                };

                // Convert Enrollment data to JSON
                var jsonEnrollment = JsonConvert.SerializeObject(newEnrollment);

                // Create HttpContent for the request body
                var content = new StringContent(jsonEnrollment, Encoding.UTF8, "application/json");

                // Send POST request to create Enrollment
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Enrollment created successfully!");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task GetEnrollmentsAsync()
    {
        // API endpoint URL for Enrollments
        string apiUrl = "http://localhost:5140/api/Enrollments";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Send GET request to retrieve all Enrollments
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    var enrollments = JsonConvert.DeserializeObject<Enrollment[]>(jsonContent);

                    // Display the retrieved Enrollment data
                    Console.WriteLine("Enrollment Data:");
                    Console.WriteLine("+" + new string('-', 92) + "+");
                    Console.WriteLine("| ID | Student ID | Student Name        | Course ID | Course Name         | Enrollment Date | Amount | Discount | Description       |");
                    Console.WriteLine("+" + new string('-', 92) + "+");

                    foreach (var enrollment in enrollments)
                    {
                        Console.WriteLine($"| {enrollment.Id,-3} | {enrollment.StudentId,-10} | {enrollment.StudentName,-20} | {enrollment.CourseId,-9} | {enrollment.CourseName,-20} | {enrollment.EnrollmentDate,-16} | {enrollment.Amount,-6} | {enrollment.Discount,-9} | {enrollment.Description,-18} |");
                    }

                    Console.WriteLine("+" + new string('-', 92) + "+");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task GetEnrollmentByIdAsync()
    {
        // API endpoint URL for Enrollment
        string apiUrl = "http://localhost:5140/api/Enrollments";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the Enrollment ID to retrieve
                Console.Write("Enter the ID of the Enrollment you want to retrieve: ");
                int enrollmentId;
                if (!int.TryParse(Console.ReadLine(), out enrollmentId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send GET request to retrieve the specific Enrollment by ID
                HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{enrollmentId}");

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    var enrollment = JsonConvert.DeserializeObject<Enrollment>(jsonContent);

                    // Display the retrieved Enrollment data
                    Console.WriteLine($"Enrollment Data for ID {enrollmentId}:");
                    Console.WriteLine("+" + new string('-', 92) + "+");
                    Console.WriteLine("| ID | Student ID | Student Name        | Course ID | Course Name         | Enrollment Date | Amount | Discount | Description       |");
                    Console.WriteLine("+" + new string('-', 92) + "+");

                    Console.WriteLine($"| {enrollment.Id,-3} | {enrollment.StudentId,-10} | {enrollment.StudentName,-20} | {enrollment.CourseId,-9} | {enrollment.CourseName,-20} | {enrollment.EnrollmentDate,-16} | {enrollment.Amount,-6} | {enrollment.Discount,-9} | {enrollment.Description,-18} |");

                    Console.WriteLine("+" + new string('-', 92) + "+");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task UpdateEnrollmentAsync()
    {
        // API endpoint URL for Enrollment
        string apiUrl = "http://localhost:5140/api/Enrollments";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the Enrollment ID to update
                Console.Write("Enter the ID of the enrollment you want to update: ");
                int enrollmentId;
                if (!int.TryParse(Console.ReadLine(), out enrollmentId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send GET request to retrieve the specific enrollment by ID
                HttpResponseMessage getResponse = await client.GetAsync($"{apiUrl}/{enrollmentId}");

                // Check if the request was successful
                if (getResponse.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await getResponse.Content.ReadAsStringAsync();
                    var enrollment = JsonConvert.DeserializeObject<Enrollment>(jsonContent);

                    // Display the retrieved enrollment data
                    Console.WriteLine($"Enrollment Data for ID {enrollmentId}:");
                    Console.WriteLine("+" + new string('-', 78) + "+");
                    Console.WriteLine("| ID | StudentId | StudentName        | CourseId | CourseName         | EnrollmentDate | Amount | Discount | Description        |");
                    Console.WriteLine("+" + new string('-', 78) + "+");

                    Console.WriteLine($"| {enrollment.Id,-3} | {enrollment.StudentId,-9} | {enrollment.StudentName,-18} | {enrollment.CourseId,-8} | {enrollment.CourseName,-18} | {enrollment.EnrollmentDate,-15} | {enrollment.Amount,-6} | {enrollment.Discount,-8} | {enrollment.Description,-18} |");

                    Console.WriteLine("+" + new string('-', 78) + "+");

                    // Ask the user which fields they want to update
                    Console.WriteLine($"Selected enrollment: ID: {enrollment.Id}, StudentName: {enrollment.StudentName}");

                    Console.Write("Enter updated StudentName (press Enter to skip): ");
                    string updatedStudentName = Console.ReadLine();

                    Console.Write("Enter updated CourseName (press Enter to skip): ");
                    string updatedCourseName = Console.ReadLine();

                    Console.Write("Enter updated EnrollmentDate (press Enter to skip): ");
                    string updatedEnrollmentDate = Console.ReadLine();

                    Console.Write("Enter updated Amount (press Enter to skip): ");
                    string updatedAmount = Console.ReadLine();

                    Console.Write("Enter updated Discount (press Enter to skip): ");
                    string updatedDiscount = Console.ReadLine();

                    Console.Write("Enter updated Description (press Enter to skip): ");
                    string updatedDescription = Console.ReadLine();

                    // Update only the non-empty fields
                    if (!string.IsNullOrEmpty(updatedStudentName))
                        enrollment.StudentName = updatedStudentName;

                    if (!string.IsNullOrEmpty(updatedCourseName))
                        enrollment.CourseName = updatedCourseName;

                    if (!string.IsNullOrEmpty(updatedEnrollmentDate))
                        enrollment.EnrollmentDate = DateTime.Parse(updatedEnrollmentDate);

                    if (!string.IsNullOrEmpty(updatedAmount) && int.TryParse(updatedAmount, out int amount))
                        enrollment.Amount = amount;

                    if (!string.IsNullOrEmpty(updatedDiscount) && int.TryParse(updatedDiscount, out int discount))
                        enrollment.Discount = discount;

                    if (!string.IsNullOrEmpty(updatedDescription))
                        enrollment.Description = updatedDescription;

                    // Convert the updated enrollment data to JSON
                    var jsonUpdatedEnrollment = JsonConvert.SerializeObject(enrollment);

                    // Create HttpContent for the request body
                    var content = new StringContent(jsonUpdatedEnrollment, Encoding.UTF8, "application/json");

                    // Send PUT request to update the enrollment data
                    HttpResponseMessage putResponse = await client.PutAsync($"{apiUrl}/{enrollment.Id}", content);

                    // Check if the request was successful
                    if (putResponse.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Enrollment data updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine($"Error: {putResponse.StatusCode} - {putResponse.ReasonPhrase}");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {getResponse.StatusCode} - {getResponse.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task DeleteEnrollmentAsync()
    {
        // API endpoint URL for Enrollment
        string apiUrl = "http://localhost:5140/api/Enrollments";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the Enrollment ID to delete
                Console.Write("Enter the ID of the enrollment you want to delete: ");
                int enrollmentId;
                if (!int.TryParse(Console.ReadLine(), out enrollmentId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send DELETE request to delete the specific enrollment by ID
                HttpResponseMessage deleteResponse = await client.DeleteAsync($"{apiUrl}/{enrollmentId}");

                // Check if the request was successful
                if (deleteResponse.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Enrollment with ID {enrollmentId} deleted successfully!");
                }
                else
                {
                    Console.WriteLine($"Error: {deleteResponse.StatusCode} - {deleteResponse.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }

    //Course
    static async Task CreateCourseAsync()
    {
        // API endpoint URL for Course
        string apiUrl = "http://localhost:5140/api/Courses";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for course data to create
                Console.Write("Enter CourseName: ");
                string courseName = Console.ReadLine();

                Console.Write("Enter TeacherName: ");
                string teacherName = Console.ReadLine();

                Console.Write("Enter CoursePrice: ");
                if (!int.TryParse(Console.ReadLine(), out int coursePrice))
                {
                    Console.WriteLine("Invalid input for CoursePrice. Please enter a valid integer.");
                    return;
                }

                Console.Write("Enter CourseDescription: ");
                string courseDescription = Console.ReadLine();

                // Create a new Course object
                var newCourse = new Course
                {
                    CourseName = courseName,
                    TeacherName = teacherName,
                    CoursePrice = coursePrice,
                    CourseDescription = courseDescription
                };

                // Convert the new course data to JSON
                var jsonNewCourse = JsonConvert.SerializeObject(newCourse);

                // Create HttpContent for the request body
                var content = new StringContent(jsonNewCourse, Encoding.UTF8, "application/json");

                // Send POST request to create the new course
                HttpResponseMessage postResponse = await client.PostAsync(apiUrl, content);

                // Check if the request was successful
                if (postResponse.IsSuccessStatusCode)
                {
                    Console.WriteLine("Course created successfully!");
                }
                else
                {
                    Console.WriteLine($"Error: {postResponse.StatusCode} - {postResponse.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task GetCoursesAsync()
    {
        // API endpoint URL for Course
        string apiUrl = "http://localhost:5140/api/Courses";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Send GET request to retrieve all courses
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    var courses = JsonConvert.DeserializeObject<Course[]>(jsonContent);

                    // Display the retrieved course data
                    Console.WriteLine("Course Data:");
                    Console.WriteLine("+" + new string('-', 65) + "+");
                    Console.WriteLine("| ID | CourseName         | TeacherName       | CoursePrice | CourseDescription           |");
                    Console.WriteLine("+" + new string('-', 65) + "+");

                    foreach (var course in courses)
                    {
                        Console.WriteLine($"| {course.Id,-3} | {course.CourseName,-18} | {course.TeacherName,-18} | {course.CoursePrice,-12} | {course.CourseDescription,-28} |");
                    }

                    Console.WriteLine("+" + new string('-', 65) + "+");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task GetCourseByIdAsync()
    {
        // API endpoint URL for Course
        string apiUrl = "http://localhost:5140/api/Courses";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the Course ID to retrieve
                Console.Write("Enter the ID of the course you want to retrieve: ");
                int courseId;
                if (!int.TryParse(Console.ReadLine(), out courseId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send GET request to retrieve the specific course by ID
                HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{courseId}");

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    var course = JsonConvert.DeserializeObject<Course>(jsonContent);

                    // Display the retrieved course data
                    Console.WriteLine($"Course Data for ID {courseId}:");
                    Console.WriteLine("+" + new string('-', 65) + "+");
                    Console.WriteLine("| ID | CourseName         | TeacherName       | CoursePrice | CourseDescription           |");
                    Console.WriteLine("+" + new string('-', 65) + "+");

                    Console.WriteLine($"| {course.Id,-3} | {course.CourseName,-18} | {course.TeacherName,-18} | {course.CoursePrice,-12} | {course.CourseDescription,-28} |");

                    Console.WriteLine("+" + new string('-', 65) + "+");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task UpdateCourseAsync()
    {
        // API endpoint URL for Course
        string apiUrl = "http://localhost:5140/api/Courses";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the Course ID to update
                Console.Write("Enter the ID of the course you want to update: ");
                int courseId;
                if (!int.TryParse(Console.ReadLine(), out courseId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send GET request to retrieve the specific course by ID
                HttpResponseMessage getResponse = await client.GetAsync($"{apiUrl}/{courseId}");

                // Check if the request was successful
                if (getResponse.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await getResponse.Content.ReadAsStringAsync();
                    var course = JsonConvert.DeserializeObject<Course>(jsonContent);

                    // Display the retrieved course data
                    Console.WriteLine($"Course Data for ID {courseId}:");
                    Console.WriteLine("+" + new string('-', 65) + "+");
                    Console.WriteLine("| ID | CourseName         | TeacherName       | CoursePrice | CourseDescription           |");
                    Console.WriteLine("+" + new string('-', 65) + "+");

                    Console.WriteLine($"| {course.Id,-3} | {course.CourseName,-18} | {course.TeacherName,-18} | {course.CoursePrice,-12} | {course.CourseDescription,-28} |");

                    Console.WriteLine("+" + new string('-', 65) + "+");

                    // Ask the user which fields they want to update
                    Console.WriteLine($"Selected course: ID: {course.Id}, CourseName: {course.CourseName}");

                    Console.Write("Enter updated CourseName (press Enter to skip): ");
                    string updatedCourseName = Console.ReadLine();

                    Console.Write("Enter updated TeacherName (press Enter to skip): ");
                    string updatedTeacherName = Console.ReadLine();

                    Console.Write("Enter updated CoursePrice (press Enter to skip): ");
                    string updatedCoursePrice = Console.ReadLine();

                    Console.Write("Enter updated CourseDescription (press Enter to skip): ");
                    string updatedCourseDescription = Console.ReadLine();

                    // Update only the non-empty fields
                    if (!string.IsNullOrEmpty(updatedCourseName))
                        course.CourseName = updatedCourseName;

                    if (!string.IsNullOrEmpty(updatedTeacherName))
                        course.TeacherName = updatedTeacherName;

                    if (!string.IsNullOrEmpty(updatedCoursePrice) && int.TryParse(updatedCoursePrice, out int coursePrice))
                        course.CoursePrice = coursePrice;

                    if (!string.IsNullOrEmpty(updatedCourseDescription))
                        course.CourseDescription = updatedCourseDescription;

                    // Convert the updated course data to JSON
                    var jsonUpdatedCourse = JsonConvert.SerializeObject(course);

                    // Create HttpContent for the request body
                    var content = new StringContent(jsonUpdatedCourse, Encoding.UTF8, "application/json");

                    // Send PUT request to update the course data
                    HttpResponseMessage putResponse = await client.PutAsync($"{apiUrl}/{course.Id}", content);

                    // Check if the request was successful
                    if (putResponse.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Course data updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine($"Error: {putResponse.StatusCode} - {putResponse.ReasonPhrase}");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {getResponse.StatusCode} - {getResponse.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task DeleteCourseAsync()
    {
        // API endpoint URL for Course
        string apiUrl = "http://localhost:5140/api/Courses";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the Course ID to delete
                Console.Write("Enter the ID of the course you want to delete: ");
                int courseId;
                if (!int.TryParse(Console.ReadLine(), out courseId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send DELETE request to delete the specific course by ID
                HttpResponseMessage deleteResponse = await client.DeleteAsync($"{apiUrl}/{courseId}");

                // Check if the request was successful
                if (deleteResponse.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Course with ID {courseId} deleted successfully!");
                }
                else
                {
                    Console.WriteLine($"Error: {deleteResponse.StatusCode} - {deleteResponse.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }

    //Teacher
    static async Task CreateTeacherAsync()
    {
        // API endpoint URL for Teacher
        string apiUrl = "http://localhost:5140/api/Teachers";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for teacher data to create
                Console.Write("Enter Teacher Name: ");
                string teacherName = Console.ReadLine();

                Console.Write("Enter Teacher DOB (YYYY-MM-DD): ");
                string teacherDOB = Console.ReadLine();

                Console.Write("Enter Teacher Contact: ");
                string teacherContact = Console.ReadLine();

                Console.Write("Enter Teacher Address: ");
                string teacherAddress = Console.ReadLine();

                Console.Write("Enter Teacher Skill: ");
                string teacherSkill = Console.ReadLine();

                Console.Write("Enter Teacher Class: ");
                string teacherClass = Console.ReadLine();

                Console.Write("Enter Teacher Info: ");
                string teacherInfo = Console.ReadLine();

                // Create a new Teacher object
                var newTeacher = new Teacher
                {
                    Name = teacherName,
                    DOB = DateTime.Parse(teacherDOB),
                    Contact = teacherContact,
                    Address = teacherAddress,
                    Skill = teacherSkill,
                    Class = teacherClass,
                    Info = teacherInfo
                };

                // Convert the new teacher data to JSON
                var jsonNewTeacher = JsonConvert.SerializeObject(newTeacher);

                // Create HttpContent for the request body
                var content = new StringContent(jsonNewTeacher, Encoding.UTF8, "application/json");

                // Send POST request to create the new teacher
                HttpResponseMessage postResponse = await client.PostAsync(apiUrl, content);

                // Check if the request was successful
                if (postResponse.IsSuccessStatusCode)
                {
                    Console.WriteLine("Teacher created successfully!");
                }
                else
                {
                    Console.WriteLine($"Error: {postResponse.StatusCode} - {postResponse.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task GetTeachersAsync()
    {
        // API endpoint URL for Teacher
        string apiUrl = "http://localhost:5140/api/Teachers";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Send GET request to retrieve all teachers
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    var teachers = JsonConvert.DeserializeObject<Teacher[]>(jsonContent);

                    // Display the retrieved teacher data
                    Console.WriteLine("Teacher Data:");
                    Console.WriteLine("+" + new string('-', 78) + "+");
                    Console.WriteLine("| ID | Name               | DOB       | Contact     | Address            | Skill               | Class               | Info               |");
                    Console.WriteLine("+" + new string('-', 78) + "+");

                    foreach (var teacher in teachers)
                    {
                        Console.WriteLine($"| {teacher.Id,-3} | {teacher.Name,-18} | {teacher.DOB,-10} | {teacher.Contact,-12} | {teacher.Address,-18} | {teacher.Skill,-18} | {teacher.Class,-18} | {teacher.Info,-18} |");
                    }

                    Console.WriteLine("+" + new string('-', 78) + "+");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task GetTeacherByIdAsync()
    {
        // API endpoint URL for Teacher
        string apiUrl = "http://localhost:5140/api/Teachers";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the Teacher ID to retrieve
                Console.Write("Enter the ID of the teacher you want to retrieve: ");
                int teacherId;
                if (!int.TryParse(Console.ReadLine(), out teacherId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send GET request to retrieve the specific teacher by ID
                HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{teacherId}");

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    var teacher = JsonConvert.DeserializeObject<Teacher>(jsonContent);

                    // Display the retrieved teacher data
                    Console.WriteLine($"Teacher Data for ID {teacherId}:");
                    Console.WriteLine("+" + new string('-', 78) + "+");
                    Console.WriteLine("| ID | Name               | DOB       | Contact     | Address            | Skill               | Class               | Info               |");
                    Console.WriteLine("+" + new string('-', 78) + "+");

                    Console.WriteLine($"| {teacher.Id,-3} | {teacher.Name,-18} | {teacher.DOB,-10} | {teacher.Contact,-12} | {teacher.Address,-18} | {teacher.Skill,-18} | {teacher.Class,-18} | {teacher.Info,-18} |");

                    Console.WriteLine("+" + new string('-', 78) + "+");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task UpdateTeacherAsync()
    {
        // API endpoint URL for Teacher
        string apiUrl = "http://localhost:5140/api/Teachers";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the Teacher ID to update
                Console.Write("Enter the ID of the teacher you want to update: ");
                int teacherId;
                if (!int.TryParse(Console.ReadLine(), out teacherId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send GET request to retrieve the specific teacher by ID
                HttpResponseMessage getResponse = await client.GetAsync($"{apiUrl}/{teacherId}");

                // Check if the request was successful
                if (getResponse.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await getResponse.Content.ReadAsStringAsync();
                    var teacher = JsonConvert.DeserializeObject<Teacher>(jsonContent);

                    // Display the retrieved teacher data
                    Console.WriteLine($"Teacher Data for ID {teacherId}:");
                    Console.WriteLine("+" + new string('-', 78) + "+");
                    Console.WriteLine("| ID | Name               | DOB       | Contact     | Address            | Skill               | Class               | Info               |");
                    Console.WriteLine("+" + new string('-', 78) + "+");

                    Console.WriteLine($"| {teacher.Id,-3} | {teacher.Name,-18} | {teacher.DOB,-10} | {teacher.Contact,-12} | {teacher.Address,-18} | {teacher.Skill,-18} | {teacher.Class,-18} | {teacher.Info,-18} |");

                    Console.WriteLine("+" + new string('-', 78) + "+");

                    // Ask the user which fields they want to update
                    Console.WriteLine($"Selected teacher: ID: {teacher.Id}, Name: {teacher.Name}");

                    Console.Write("Enter updated Name (press Enter to skip): ");
                    string updatedName = Console.ReadLine();

                    Console.Write("Enter updated DOB (YYYY-MM-DD, press Enter to skip): ");
                    string updatedDOB = Console.ReadLine();

                    Console.Write("Enter updated Contact (press Enter to skip): ");
                    string updatedContact = Console.ReadLine();

                    Console.Write("Enter updated Address (press Enter to skip): ");
                    string updatedAddress = Console.ReadLine();

                    Console.Write("Enter updated Skill (press Enter to skip): ");
                    string updatedSkill = Console.ReadLine();

                    Console.Write("Enter updated Class (press Enter to skip): ");
                    string updatedClass = Console.ReadLine();

                    Console.Write("Enter updated Info (press Enter to skip): ");
                    string updatedInfo = Console.ReadLine();

                    // Update only the non-empty fields
                    if (!string.IsNullOrEmpty(updatedName))
                        teacher.Name = updatedName;

                    if (!string.IsNullOrEmpty(updatedDOB))
                        teacher.DOB = DateTime.Parse(updatedDOB);

                    if (!string.IsNullOrEmpty(updatedContact))
                        teacher.Contact = updatedContact;

                    if (!string.IsNullOrEmpty(updatedAddress))
                        teacher.Address = updatedAddress;

                    if (!string.IsNullOrEmpty(updatedSkill))
                        teacher.Skill = updatedSkill;

                    if (!string.IsNullOrEmpty(updatedClass))
                        teacher.Class = updatedClass;

                    if (!string.IsNullOrEmpty(updatedInfo))
                        teacher.Info = updatedInfo;

                    // Convert the updated teacher data to JSON
                    var jsonUpdatedTeacher = JsonConvert.SerializeObject(teacher);

                    // Create HttpContent for the request body
                    var content = new StringContent(jsonUpdatedTeacher, Encoding.UTF8, "application/json");

                    // Send PUT request to update the teacher data
                    HttpResponseMessage putResponse = await client.PutAsync($"{apiUrl}/{teacher.Id}", content);

                    // Check if the request was successful
                    if (putResponse.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Teacher data updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine($"Error: {putResponse.StatusCode} - {putResponse.ReasonPhrase}");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {getResponse.StatusCode} - {getResponse.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task DeleteTeacherAsync()
    {
        // API endpoint URL for Teacher
        string apiUrl = "http://localhost:5140/api/Teachers";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the Teacher ID to delete
                Console.Write("Enter the ID of the teacher you want to delete: ");
                int teacherId;
                if (!int.TryParse(Console.ReadLine(), out teacherId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send DELETE request to delete the specific teacher by ID
                HttpResponseMessage deleteResponse = await client.DeleteAsync($"{apiUrl}/{teacherId}");

                // Check if the request was successful
                if (deleteResponse.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Teacher with ID {teacherId} deleted successfully!");
                }
                else
                {
                    Console.WriteLine($"Error: {deleteResponse.StatusCode} - {deleteResponse.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }

    //Classroom
    static async Task CreateClassAsync()
    {
        // API endpoint URL for Class
        string apiUrl = "http://localhost:5140/api/Classes";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for class data to create
                Console.Write("Enter Room Number: ");
                string roomNumber = Console.ReadLine();

                Console.Write("Enter Schedule: ");
                string schedule = Console.ReadLine();

                Console.Write("Enter Student Number: ");
                if (!int.TryParse(Console.ReadLine(), out int studentNumber))
                {
                    Console.WriteLine("Invalid input for Student Number. Please enter a valid integer.");
                    return;
                }

                Console.Write("Enter Course: ");
                string course = Console.ReadLine();

                Console.Write("Enter Description: ");
                string description = Console.ReadLine();

                // Create a new Class object
                var newClass = new Classroom
                {
                    RoomNumber = roomNumber,
                    Schedule = schedule,
                    StudentNumber = studentNumber,
                    Course = course,
                    Description = description
                };

                // Convert the new class data to JSON
                var jsonNewClass = JsonConvert.SerializeObject(newClass);

                // Create HttpContent for the request body
                var content = new StringContent(jsonNewClass, Encoding.UTF8, "application/json");

                // Send POST request to create the new class
                HttpResponseMessage postResponse = await client.PostAsync(apiUrl, content);

                // Check if the request was successful
                if (postResponse.IsSuccessStatusCode)
                {
                    Console.WriteLine("Class created successfully!");
                }
                else
                {
                    Console.WriteLine($"Error: {postResponse.StatusCode} - {postResponse.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task GetClassesAsync()
    {
        // API endpoint URL for Class
        string apiUrl = "http://localhost:5140/api/Classes";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Send GET request to retrieve all classes
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    var classes = JsonConvert.DeserializeObject<Classroom[]>(jsonContent);

                    // Display the retrieved class data
                    Console.WriteLine("Class Data:");
                    Console.WriteLine("+" + new string('-', 72) + "+");
                    Console.WriteLine("| ID | Room Number | Schedule  | Student Number | Course            | Description        |");
                    Console.WriteLine("+" + new string('-', 72) + "+");

                    foreach (var classObj in classes)
                    {
                        Console.WriteLine($"| {classObj.Id,-3} | {classObj.RoomNumber,-12} | {classObj.Schedule,-9} | {classObj.StudentNumber,-15} | {classObj.Course,-18} | {classObj.Description,-18} |");
                    }

                    Console.WriteLine("+" + new string('-', 72) + "+");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task GetClassByIdAsync()
    {
        // API endpoint URL for Class
        string apiUrl = "http://localhost:5140/api/Classes";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the Class ID to retrieve
                Console.Write("Enter the ID of the class you want to retrieve: ");
                int classId;
                if (!int.TryParse(Console.ReadLine(), out classId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send GET request to retrieve the specific class by ID
                HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{classId}");

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    var classObj = JsonConvert.DeserializeObject<Classroom>(jsonContent);

                    // Display the retrieved class data
                    Console.WriteLine($"Class Data for ID {classId}:");
                    Console.WriteLine("+" + new string('-', 72) + "+");
                    Console.WriteLine("| ID | Room Number | Schedule  | Student Number | Course            | Description        |");
                    Console.WriteLine("+" + new string('-', 72) + "+");

                    Console.WriteLine($"| {classObj.Id,-3} | {classObj.RoomNumber,-12} | {classObj.Schedule,-9} | {classObj.StudentNumber,-15} | {classObj.Course,-18} | {classObj.Description,-18} |");

                    Console.WriteLine("+" + new string('-', 72) + "+");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task UpdateClassAsync()
    {
        // API endpoint URL for Class
        string apiUrl = "http://localhost:5140/api/Classes";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the Class ID to update
                Console.Write("Enter the ID of the class you want to update: ");
                int classId;
                if (!int.TryParse(Console.ReadLine(), out classId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send GET request to retrieve the specific class by ID
                HttpResponseMessage getResponse = await client.GetAsync($"{apiUrl}/{classId}");

                // Check if the request was successful
                if (getResponse.IsSuccessStatusCode)
                {
                    // Read and deserialize the response content
                    string jsonContent = await getResponse.Content.ReadAsStringAsync();
                    var classObj = JsonConvert.DeserializeObject<Classroom>(jsonContent);

                    // Display the retrieved class data
                    Console.WriteLine($"Class Data for ID {classId}:");
                    Console.WriteLine("+" + new string('-', 72) + "+");
                    Console.WriteLine("| ID | Room Number | Schedule  | Student Number | Course            | Description        |");
                    Console.WriteLine("+" + new string('-', 72) + "+");

                    Console.WriteLine($"| {classObj.Id,-3} | {classObj.RoomNumber,-12} | {classObj.Schedule,-9} | {classObj.StudentNumber,-15} | {classObj.Course,-18} | {classObj.Description,-18} |");

                    Console.WriteLine("+" + new string('-', 72) + "+");

                    // Ask the user which fields they want to update
                    Console.WriteLine($"Selected class: ID: {classObj.Id}, Room Number: {classObj.RoomNumber}");

                    Console.Write("Enter updated Room Number (press Enter to skip): ");
                    string updatedRoomNumber = Console.ReadLine();

                    Console.Write("Enter updated Schedule (press Enter to skip): ");
                    string updatedSchedule = Console.ReadLine();

                    Console.Write("Enter updated Student Number (press Enter to skip): ");
                    string updatedStudentNumber = Console.ReadLine();

                    Console.Write("Enter updated Course (press Enter to skip): ");
                    string updatedCourse = Console.ReadLine();

                    Console.Write("Enter updated Description (press Enter to skip): ");
                    string updatedDescription = Console.ReadLine();

                    // Update only the non-empty fields
                    if (!string.IsNullOrEmpty(updatedRoomNumber))
                        classObj.RoomNumber = updatedRoomNumber;

                    if (!string.IsNullOrEmpty(updatedSchedule))
                        classObj.Schedule = updatedSchedule;

                    if (!string.IsNullOrEmpty(updatedStudentNumber) && int.TryParse(updatedStudentNumber, out int studentNumber))
                        classObj.StudentNumber = studentNumber;

                    if (!string.IsNullOrEmpty(updatedCourse))
                        classObj.Course = updatedCourse;

                    if (!string.IsNullOrEmpty(updatedDescription))
                        classObj.Description = updatedDescription;

                    // Convert the updated class data to JSON
                    var jsonUpdatedClass = JsonConvert.SerializeObject(classObj);

                    // Create HttpContent for the request body
                    var content = new StringContent(jsonUpdatedClass, Encoding.UTF8, "application/json");

                    // Send PUT request to update the class data
                    HttpResponseMessage putResponse = await client.PutAsync($"{apiUrl}/{classObj.Id}", content);

                    // Check if the request was successful
                    if (putResponse.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Class data updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine($"Error: {putResponse.StatusCode} - {putResponse.ReasonPhrase}");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {getResponse.StatusCode} - {getResponse.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    static async Task DeleteClassAsync()
    {
        // API endpoint URL for Class
        string apiUrl = "http://localhost:5140/api/Classes";

        // Create HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Ask the user for the Class ID to delete
                Console.Write("Enter the ID of the class you want to delete: ");
                int classId;
                if (!int.TryParse(Console.ReadLine(), out classId))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }

                // Send DELETE request to delete the specific class by ID
                HttpResponseMessage deleteResponse = await client.DeleteAsync($"{apiUrl}/{classId}");

                // Check if the request was successful
                if (deleteResponse.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Class with ID {classId} deleted successfully!");
                }
                else
                {
                    Console.WriteLine($"Error: {deleteResponse.StatusCode} - {deleteResponse.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}