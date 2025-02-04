namespace Lecture2;
class Program
{
    static void Main(string[] args)
    {
         Console.Write("Enter a letter grade: ");
        string grade = Console.ReadLine(); grade.ToUpper();
        switch (grade)
        {
            case "A":
                Console.WriteLine("GPA: 4");
                break;
            case "B":
                Console.WriteLine("GPA: 3");
                break;
            case "C":
                Console.WriteLine("GPA: 2");
                break;
            case "D":
                Console.WriteLine("GPA: 1");
                break;
            case "F":
                Console.WriteLine("GPA: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }
    }
}         
           


