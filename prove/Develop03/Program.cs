using System;

namespace DailyScripture
{
    class Program
    {
        
        static void Main()
        {
            Scripture scripture = new Scripture("1 Nephi ", 3, 7, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them. ");
            Console.Clear();
            scripture.Display(); 
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nYou got this, you memorized the scripture!!");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }
    }
}