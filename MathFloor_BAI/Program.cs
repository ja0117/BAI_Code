using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_BuzzGame
{
    public class Program
    {
        public string[] Players = { "Player A", "Player B", "Player C", "Player D", "Player E", "Player F", "Player G" };
        public int[] PlayerScores = new int[7];
        public int CurrentPlayer = 0;
        public int CurrentNumber = 0;
        public int MaxNumber = 1000;
        public int Buzz = 0;
        public int NoBuzz = 0;
        public int digit = 7;
        public static void Main(string[] args) 
        {
            Program run = new Program();
            run.RunGame();
        }

        public void RunGame()
        {
            while (CurrentNumber < MaxNumber)
            {
                for (int i = 0; i < Players.Length; i++)
                {
                    CurrentNumber = CurrentNumber + 1;
                    Console.WriteLine($"{Players[i]} said: {CurrentNumber}");
                    if (CurrentNumber.ToString().Contains(digit.ToString()) || isMultiple(CurrentNumber, digit))
                    {
                        PlayerScores[i] = PlayerScores[i] + 1;
                        Buzz = Buzz + 1;
                    }
                    else
                    {
                        NoBuzz = NoBuzz + 1;
                    }
                }
            }
            ShowResults();
        }

        public void ShowResults()
        {
            for (int i = 0; i < Players.Length; i++)
            {
                Console.WriteLine($"{Players[i]} has Buzzed {PlayerScores[i]} times");
            }
            Console.ReadLine();
        }

        public bool isMultiple(int a, int b)
        {
            if (a % b == 0)
                return true;
            else
                return false;
        }
    }
}
