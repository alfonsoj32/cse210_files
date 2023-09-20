using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int random_num = randomGenerator.Next(1, 101);
        int guess = -1;

        while (guess != random_num)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (random_num > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (random_num < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}