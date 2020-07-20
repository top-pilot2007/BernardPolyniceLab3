using System;
using System.Collections.Generic;
using System.Text;

namespace BernardLab3
{
    class Calculation
    {
        public static void CalculateOddEven(string userName, double userNumber)
        {
            if (userNumber % 2 != 0 && userNumber <= 100 && userNumber >= 1)
            {
                Console.WriteLine($"{userName}, {userNumber} is Odd.");
            }
            else if (userNumber % 2 == 0 && 2 <= userNumber && userNumber <= 25)
            {
                Console.WriteLine($"{userName}, {userNumber} is Even and less than 25.");
            }
            else if (userNumber % 2 == 0 && 26 <= userNumber && userNumber <= 60)
            {
                Console.WriteLine($"{userName}, it's Even.");
            }
            else if (userNumber % 2 == 0 && userNumber > 60 && userNumber <= 100)
            {
                Console.WriteLine($"{userName}, {userNumber} is Even.");
            }
            else if (userNumber % 2 != 0 && userNumber > 60 && userNumber <= 100)
            {
                Console.WriteLine($"{userName}, {userNumber} is Odd.");
            }

            else
            {
                Console.WriteLine($"{userName}, {userNumber} is outside the scope of this program.");
            }

        }
    }
}
