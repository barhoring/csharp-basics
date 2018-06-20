using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            double runningTotal = 0;
            double minutes;
            string entry;
            while(true){
                Console.WriteLine("Enter how many minutes you exercised or type \"quit\" to exit:");
                entry = Console.ReadLine();
                if(entry.ToLower() == "quit"){
                    break;
                }
                try {
                    minutes = double.Parse(entry);
                        
                    if(minutes <= 0){
                        Console.WriteLine(minutes + " is not an acceptable value.");
                        continue;
                    }
                    else if(minutes <=10){
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if(minutes <= 30){
                        Console.WriteLine("Way to go hot stuff!");        
                    }
                    else if(minutes <=60){
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }
                    else if(minutes > 60){
                        Console.WriteLine("Okay, now you're just showing off!");
                    }
                    runningTotal += minutes;
                    Console.WriteLine("You've exercised " + runningTotal + " minutes");
                }
                catch(FormatException) {
                    Console.WriteLine("That is not a valid input");
                    continue;
                }
            }
            Console.WriteLine("goodbye");

        }
    }
}
