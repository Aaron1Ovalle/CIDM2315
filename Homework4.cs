namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
      // Call Q1_method()
        Console.Write($"Enter a: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int num2 = int.Parse(Console.ReadLine());

        int largest = GetLargestNumber(num1 , num2);
        Console.WriteLine("a = " + num1 + "; b = " + num2 + ";");
        Console.WriteLine("The largest number is: " + largest);

        // Call Q2_method()
        Console.Write("Enter the value of N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter the shape (left or right): ");
        string shape = Console.ReadLine() ?? "left";

        PrintShape(N, shape);
    }

    // Q1
    static int GetLargestNumber(int a, int b)
    {
        return (a > b) ? a : b;
    }

    // Q2
    static void PrintShape(int N, string shape)
    {
        Console.WriteLine("N is: " + N + "; shape is " + shape );

        if (shape == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if (shape == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    
    }
    
}
