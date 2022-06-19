namespace Chojnowski_Student_Form
{
    public class Student
    {
        private static string Name;
        private static string Surname;
        private static int StudentNo;
        private static string Email;
        private static string Faculty;
        private static string PhoneNo;

        public static void SetName(string name)
        {
            Name = name;
        }
        public static void SetSurname(string surname)
        {
            Surname = surname;
        }
        public static void SetStudentNo(int studentno)
        {
            StudentNo = studentno;
        }
        public static void SetEmail(string email)
        {
            Email = email;
        }
        public static void SetFaculty(string faculty)
        {
            Faculty = faculty;
        }
        public static void SetPhoneNo(string phoneno)
        {
            PhoneNo = phoneno;
        }

        public static string StudentDetails()
        {
            string details;
            details = "Name " + Name + "\n";
            details = details + "Surname " + Surname + "\n";
            details = details + "Student No " + StudentNo.ToString() + "\n";
            details = details + "E-mail " + Email + "\n";
            details = details + "Falculty " + Faculty + "\n";
            details = details + "Phone No " + PhoneNo + "\n";

            return details;
        }
    }
}