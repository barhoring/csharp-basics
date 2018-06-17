﻿using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningTotal = 0;
            bool keepGoing = true;
            while(keepGoing){
                Console.WriteLine("Enter how many minutes you exercised or type \"quit\" to exit:");
                string entry = Console.ReadLine();
                if(entry == "quit"){
                    keepGoing = false;
                }
                else {
                    try {
                        int minutes = int.Parse(entry);
                    }
                    catch(e) {
                        Console.WriteLine("That is not a valid input");
                        continue;
                    }

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

            }
            Console.WriteLine("goodbye");

        }
    }
}
