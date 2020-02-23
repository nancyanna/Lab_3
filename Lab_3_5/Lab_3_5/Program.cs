using System;

namespace Lab_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWorld = "viagar";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWorld))
            {
                isSpam = true;
                Console.WriteLine("The message is spam");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is isSpam");
            }
        }
    }
}
