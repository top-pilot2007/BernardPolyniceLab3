using System;

namespace BernardLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("HELLO THERE!! Before we get started, what is your name? ");
            string userName = Console.ReadLine().ToUpper();
            Console.Write($"Pleasure to meet you {userName}! ");
            string continueYesNo = "y";

            while (continueYesNo == "y" || continueYesNo == "")
            {
                Console.Write("Enter a number between 1 and 100: ");
                try
                {
                    double userNumber = double.Parse(Console.ReadLine());

                    Calculation.CalculateOddEven(userName, userNumber);
                }
                catch (Exception numberOutOfLimit)
                {

                    Console.WriteLine(numberOutOfLimit.Message);
                }

                Console.Write($"Would you like to continue {userName}? (y/n) ");
                continueYesNo = Console.ReadLine().ToLower().Trim();
            }
            Console.WriteLine($"Goodbye {userName}!!!  Its been REAL!!!");

        }

    }
}
