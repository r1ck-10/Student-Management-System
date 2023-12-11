using StudentClient_Winform.Enrollment_Form;
using StudentClient_Winform.Student_Form;
using StudentClient_Winform.Course_Form;
using StudentClient_Winform.Teacher_Form;
using StudentClient_Winform.Classroom_Form;
namespace StudentClient_Winform
{
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Studentfrm studentfrm = new Studentfrm();

            studentfrm.Show();
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            Enrollmentfrm enrollmentfrm = new Enrollmentfrm();
            enrollmentfrm.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            Coursefrm coursefrm = new Coursefrm();
            coursefrm.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Teacherfrm teacherfrm = new Teacherfrm();
            teacherfrm.Show();
        }

        private void btnClassroom_Click(object sender, EventArgs e)
        {
            Classroomfrm classroomfrm = new Classroomfrm();
            classroomfrm.Show();
        }
    }
}
