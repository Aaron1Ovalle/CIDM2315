namespace Homework6;

class Program
{
    class program
    {
        static void Main(string[] args)
        {
            
            Professor prof1 = new Professor("Alice", "Java", 9000);
            Professor prof2 = new Professor("Bob", "Math", 8000);

            
            Student student1 = new Student("Lisa", "Java", 90);
            Student student2 = new Student("Tom", "Math", 80);

            
            Console.WriteLine($"Professor {prof1.GetProfName()} teaches {prof1.GetClassTeach()}, and the salary is: {prof1.GetSalary()}");
            Console.WriteLine($"Professor {prof2.GetProfName()} teaches {prof2.GetClassTeach()}, and the salary is: {prof2.GetSalary()}");

            
            Console.WriteLine($"Student {student1.GetStudentName()} enrolls in {student1.GetClassEnroll()}, and the grade is: {student1.GetGrade()}");
            Console.WriteLine($"Student {student2.GetStudentName()} enrolls in {student2.GetClassEnroll()}, and the grade is: {student2.GetGrade()}");

            double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
            Console.WriteLine($"The salary difference between {prof1.GetProfName()} and {prof2.GetProfName()} is: {salaryDifference}");

            double totalGrade = student1.GetGrade() + student2.GetGrade();
            Console.WriteLine($"The total grade of {student1.GetStudentName()} and {student2.GetStudentName()} is: {totalGrade}");
        }
    }

    class Professor
    {
        private string profName;
        private string classTeach;
        private double salary;

        public Professor(string name, string teach, double sal)
        {
            profName = name;
            classTeach = teach;
            salary = sal;
        }

        public void SetSalary(double salary_amount)
        {
            salary = salary_amount;
        }

        public double GetSalary()
        {
            return salary;
        }

        public string GetProfName()
        {
            return profName;
        }

        public string GetClassTeach()
        {
            return classTeach;
        }
    }

    class Student
    {
        private string studentName;
        private string classEnroll;
        private double studentGrade;

        public Student(string name, string enroll, double grade)
        {
            studentName = name;
            classEnroll = enroll;
            studentGrade = grade;
        }

        public void SetGrade(double newGrade)
        {
            studentGrade = newGrade;
        }

        public double GetGrade()
        {
            return studentGrade;
        }

        public string GetStudentName()
        {
            return studentName;
        }

        public string GetClassEnroll()
        {
            return classEnroll;
        }
    }
}



