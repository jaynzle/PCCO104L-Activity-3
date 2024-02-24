using System;

class Program 
{
    public static void Main(string[] args) 
    {
        int num;
        while (true)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out num))
            {
                if (num == 0)
                {
                    Console.WriteLine("Program Terminated.");
                    break;
                }

                {
                    star(num);
                }
            }
            else
            {
                Console.WriteLine($"Invalid value: {input}.");
            }
        }
    }

    static void star(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }
            if (i == 0 || i == n - 1)
            {
                Console.WriteLine("*");
            }
            else
            {
                Console.Write("*");
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }
    }
}