using System;
using System.Linq;

namespace concole_app
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            Console.Write("Enter the number here: ");

            int numInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CubicMeter(numInput));
            */
            /*
            Console.WriteLine("Hi, this is a AND port");
            Console.WriteLine("Enter first number 0 or 1: ");
            int fNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number 0 or 1: ");
            int sNumber = Convert.ToInt32(Console.ReadLine());
            if (fNumber > 1 | sNumber > 1)
            {
                Console.WriteLine("Set a value of 0 or 1");
                
            }
            if (fNumber == 1 && sNumber == 1)
            {
                Console.WriteLine("Lightbulp is on");
            }
            if(fNumber == 0 && sNumber == 0)
            {
                Console.WriteLine("Lightbulp is on");
            }
            else
            {
                Console.WriteLine("Lightbulp is off");
            }
            */

            /*
            Console.Write(WhoBig(2, 3));
            */

            Console.WriteLine("Welcome to the old guessing game! \nTry to find the right word, you have 3 guesses!");
            
            string[] wordList = { "fireball", "dragoncave", "vikingaxe", "vikingship", "vallhalla"};
            Random randomWord = new Random();
            int index = randomWord.Next(wordList.Length);
            string finalWord = wordList[index];
            Random chaosWord = new Random();
            string newWord = new string(finalWord.ToCharArray().OrderBy(s => (chaosWord.Next(2) % 2) == 0).ToArray());
            
            Console.Write("This is the word: " + newWord + "\n");

 
            string guessedWord = Console.ReadLine();
            int guesses = 3; 
            while(guessedWord != wordList[index])
            {
                
                guesses--;
                Console.WriteLine($"Sorry, wrong guess! You have {guesses} guesses left! Try again.");
                guessedWord = Console.ReadLine();
                if (guesses <= 1)
                {
                    Console.WriteLine("To many guesses!");
                    break;
                }
                else if(guessedWord == wordList[index])
                {
                    Console.WriteLine("HURRAY! You win!");
                    break; 
                }
            }
            


            


           

            Console.ReadKey();



            /*
            while (guess != secretWord)
            {
                lives--;
                Console.WriteLine("Wrong letter! You have " + lives + " left");
                break;
            }
            */


            Console.ReadLine();
        }
        static int CubicMeter(int num, int num2)
        {
            int result = num * num * num;
            return result; 
        }

        static int WhoBig(int x, int y)
        {
            int result;
            if(x > y)
            {
                result = x;
            }
            else
            {
                result = y; 
            }
            return result;
        }

    }
}


