using System;
using System.Threading;

namespace HelpNemoWithMath
{
    class Program
    {

        static double KwH1 = 0.20;
        static double MonthlyPayment1 = 150;
        static double total1;

        static double KwH2 = 0.15;
        static int MonthlyPayment2 = 180;
        static double total2;

        static void Main(string[] args) {
            for (int i = 0; i < 300; i++) {
                total1 += (MonthlyPayment1 + KwH1 * i);
                total2 += (MonthlyPayment2 + KwH2 * i);

                Console.WriteLine($"after day {i}");
                Console.WriteLine($"Option 1: {total1}");
                Console.WriteLine($"Option 2: {total2}");
            }

            
            Console.Read();
        }
    }
}
