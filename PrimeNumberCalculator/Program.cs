using System;

namespace PrimeNumberCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            //Get user input method - this where validation
            //IsEven method -reusable elsewhere
            //IsPrime - needs the other methods

            Console.WriteLine("Welcome to the Prime Number Calculator!\n");
            bool goagain = true;
            while(goagain == true)
            {
                Console.WriteLine("Please enter a number between 1 and 1001 exclusive: ");
                string input = Console.ReadLine();
                int number = GetInput(input);
                Console.WriteLine(number);
                if(number == -1)
                {
                    Console.WriteLine("\nLooks like we didnt get a useable input");
                    Console.WriteLine("Let's try again!");

                    //continue skips to the next run of the loop, essentially taking
                    //us to the top of the loop again
                    continue;
                }

                Console.WriteLine($"Is {number} prime? {IsPrime(number)}");

               // Console.WriteLine($" 4 is even: {IsEven(4)}");
               // Console.WriteLine($"11 is not even: {IsEven(11)}");
            }


        }

        public static int GetInput(string input)
        {
            int num = int.Parse(input);

            if(num > 1 && num <= 100000)
            {
                return num;
            }
            else
            {
                Console.WriteLine("That number was not between 1 and 1001 exclusive. Please try again. ");
                return -1; //throws an exception, old school method.
            }
        }

        public static bool IsEven(int num)
        {
            if(num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPrime(int num)
        {
            if(num == 2)
            {
                return true;
            }

            if(IsEven(num))
            {
                return false;
            }
            else
            {
                for (int i = 3; i < num; i+= 2)
                {
                   bool divisible = num % i == 0;
                    if(divisible == true)
                    {
                        return false;
                    }
                }

                return true;
            }

        }
    }
}
