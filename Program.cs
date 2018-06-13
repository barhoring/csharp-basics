using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningTotal = 0;
            bool keepGoing = true;
            while(keepGoing){
                Console.WriteLine("Enter how many minutes you exercised or type 'quit' to exit:");
                string entry = Console.ReadLine();
                int minutes = int.Parse(entry);
                runningTotal += minutes;
                Console.WriteLine(entry);
                Console.WriteLine("You've exercised " + runningTotal + " minutes");
            }

        }
    }
}
