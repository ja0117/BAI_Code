using System;

namespace week4_Logica
{
    class Program
    {
        
        static void Main(string[] args) {

            //Console.WriteLine(Oefening5BBitShift(6).ToString());
            Oefening7C('p');
            Oefening7C();
        }



        static bool Oefening5A(int x) {
            if ((x & 1) == 0) {
                // Even number
                return true;
            }
            // Odd number
            return false;
        }

        static void Oefening5ASimpel() {
            Console.WriteLine(1 % 1);
            Console.WriteLine(2 % 1);
            Console.WriteLine(3 % 1);
            Console.WriteLine(4 % 1);
            Console.WriteLine(5 % 1);
            Console.WriteLine(6 % 1);
        }

        static bool Oefening5B(int x) {
            if ((x & 0b10000000000000000000000000000000) == 0) {
                return true;
            }
            return false;
        }

        static bool Oefening5BHEX(int x) {
            if ((x & 0x80000000) == 0) {
                return true;
            }
            return false;
        }

        static bool Oefening5BBitShift(int x) {
            if ((x >> 31) == 0) {
                return true;
            }
            return false;
        }

        static bool Oefening7C(char c) {
            int x = Convert.ToInt32(c);
            if ((x >> 6) == 1) {
                return true; 
            }
            return false;
        }

        static void Oefening7C() {
            Console.WriteLine((char)('a' & ~32));
            Console.WriteLine((char)('A' & ~32));
            Console.WriteLine((char)('B' | 32));
            Console.WriteLine((char)('B' & ~32));
        }
    }
}
