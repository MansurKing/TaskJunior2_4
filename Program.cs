using System;

namespace TaskJunior2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int firstValue = 0;
            int finishValue = 101;
            int numberDivisibleFirst = 3;
            int numberDivisibleFirstSecond = 5;
            int number = random.Next(firstValue, finishValue);
            int sum = 0;

            Console.WriteLine(number);

            for (int i = number; i > firstValue; i--)
            {
                if ((i % numberDivisibleFirst == 0) || (i % numberDivisibleFirstSecond == 0))
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
