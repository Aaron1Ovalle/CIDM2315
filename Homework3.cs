namespace Lecture3;

class Program
{
    static void Main(string[] args)
    {            //Q1
    Console.Write("Input an integer: ");
        int N = Convert.ToInt16(Console.ReadLine());

        if (IsPrime(N))
        {
            Console.WriteLine($"{N} is prime");
        }
        else
        {
            Console.WriteLine($"{N} is non-prime");
        }         //Q2
         for(int i = 0;i<N;i++){

            

        for(int j =0;j<N;j++){

            Console.Write("#");

        }

            Console.WriteLine();
         }


    }    
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    

    } 
     
}

