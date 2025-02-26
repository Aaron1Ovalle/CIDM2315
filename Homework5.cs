namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
    {
        // Call Q1_mehtod()
         Console.Write($"Enter a: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int num2 = int.Parse(Console.ReadLine());

        int largest = GetLargestNumber(num1 , num2);
        Console.WriteLine("a = " + num1 + "; b = " + num2 + ";");
        Console.WriteLine("The largest number is: " + largest);

        // Call Q2_method()
        int largestOfFour = GetLargestOfFour();
        Console.WriteLine("The largest number of four is: " + largestOfFour);

        // Call Q3_mehotd()
        createAccount();
    }

    // Q1_method
    static int GetLargestNumber(int a, int b)
    {
        return (a > b) ? a : b;
    }

    // Q2_method()
    static int GetLargestOfFour()
    {
        Console.WriteLine("Enter four integers:");

        string? input1 = Console.ReadLine();
        string? input2 = Console.ReadLine();
        string? input3 = Console.ReadLine();
        string? input4 = Console.ReadLine();

        if (input1 == null || input2 == null || input3 == null || input4 == null)
        {
            throw new ArgumentNullException("Input cannot be null");
        }

        int num1 = int.Parse(input1);
        int num2 = int.Parse(input2);
        int num3 = int.Parse(input3);
        int num4 = int.Parse(input4);
        int largest1 = GetLargestOfTwoHelper(num1, num2);
        int largest2 = GetLargestOfTwoHelper(num3, num4);

        return GetLargestOfTwoHelper(largest1, largest2);
    }

    static int GetLargestOfTwoHelper(int a, int b)
    {
        return Math.Max(a, b);
    }

    // Q3_method()
    static bool checkAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        return age >= 22;
    }
    static void createAccount()
    {
        Console.WriteLine("Enter username:");
        string? username = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string? password = Console.ReadLine();

        Console.WriteLine("Enter password again:");
        string? confirmPassword = Console.ReadLine();

        Console.WriteLine("Enter birth year:");
        string? birthYearInput = Console.ReadLine();

        if (username == null || password == null || confirmPassword == null || birthYearInput == null)
        {
            throw new ArgumentNullException("Input cannot be null");
        }

        int birthYear = int.Parse(birthYearInput);

        if (checkAge(birthYear))
        {
            if (password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
    }

  

       
}
