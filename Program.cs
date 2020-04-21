using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my guessing game");
            Console.WriteLine("Enter 1 for Easy    2 for Medium    3 for Hard");
            int n = int.Parse(Console.ReadLine());
            if(n == 1)
            {
                Easy();
            }else if (n == 2)
            {
                Medium();
            }else if(n == 3)
            {
                Hard();
            }
            else
            {
                Easy();
            }
        }

        static void Easy(){
            
            int guessNum, tryCount;
            Console.WriteLine("EASY");
            Console.Write("Enter a number between 1- 10: ");
            int num = int.Parse(Console.ReadLine());
            Random random = new Random();
            guessNum = random.Next(1, 10);
            tryCount = 1;
            while (num != guessNum && tryCount <= 5)
            {
                Console.WriteLine("That was wrong");
                Console.Write("Enter a new Number between 1- 10: ");
                num = int.Parse(Console.ReadLine());
                tryCount++;
            }
            if(num == guessNum)
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("Game Over");
            }
        }
        static void Medium()
        {

            int guessNum, tryCount;
            Console.WriteLine("MEDIUM");
            Console.Write("Enter a number between 1- 20: ");
            int num = int.Parse(Console.ReadLine());
            Random random = new Random();
            guessNum = random.Next(1, 20);
            tryCount = 1;
            while (num != guessNum && tryCount <= 3)
            {
                Console.WriteLine("That was wrong");
                Console.Write("Enter a new Number between 1- 20: ");
                num = int.Parse(Console.ReadLine());
                tryCount++;
            }
            if (num == guessNum)
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("Game Over");
            }
        }
        static void Hard()
        {

            int guessNum, tryCount;
            Console.WriteLine("HARD");
            Console.Write("Enter a number between 1- 50: ");
            int num = int.Parse(Console.ReadLine());
            Random random = new Random();
            guessNum = random.Next(1, 50);
            tryCount = 1;
            while (num != guessNum && tryCount <= 2)
            {
                Console.WriteLine("That was wrong");
                Console.Write("Enter a new Number between 1- 50: ");
                num = int.Parse(Console.ReadLine());
                tryCount++;
            }
            if (num == guessNum)
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("Game Over");
            }
        }
    }
}
