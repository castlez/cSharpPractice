/*
 C# Practice Module
 * Copyright (c) 2015 Jonathan Castle
 * 
 * This module provide example of common programming
 * exercises to prove profficiency in the C# programming 
 * language.
 * 
 * Current exercises include:
 * hello world
 * random number between two bounds
 * slice up a sentence
 * 
 */

//imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cSharpPractice
{
    class Practice_Menu
    {
        //main method
        static void Main(string[] args)
        {
            Practice_Menu menu = new Practice_Menu();
            int result = menu.Menu();
            while (result != 0)
            {
                if (result == -1)
                {
                    Console.WriteLine("please enter one of the available options.");
                }
                result = menu.Menu();
            }
        }

        //menu method returns 
        //1 if successful
        //0 if the user wishes to quit
        //-1 if invalid input was provided
        int Menu()
        {
            Practice_Menu menu = new Practice_Menu();
            //populate menu with options    
            Console.WriteLine(">Welcome to the c# practice module!\nChoose one of the following practice modules:");
            Console.WriteLine(">0: exit");
            Console.WriteLine(">1: hello world");
            Console.WriteLine(">2: random number between two bounds");
            Console.WriteLine(">3: slice up a sentence");

            //collect user decision and launch proper action
            String ans = Console.ReadLine();
            switch (ans)
            {
                case "0": //quit
                    Console.WriteLine(">Goodbye (press any key to exit)");
                    Console.ReadKey();
                    return 0;
                case "1"://hello world
                    menu.hello_world();
                    Console.WriteLine(">Press any key to continue.\n");
                    Console.ReadKey();
                    return 1;
                case "2": //choose between two bounds
                    Console.WriteLine("chose two bounds for me to pick a random number between.");
                    Console.WriteLine("First number: ");
                    int lowb =int.Parse(Console.ReadLine());
                    Console.WriteLine("Second number: ");
                    int highb = int.Parse(Console.ReadLine());
                    menu.randBetween(lowb,highb);
                    return 1;
                case "3": //sentence slice
                    Console.WriteLine("Input a sentence to see it with every other word removed.");
                    Console.Write(">> ");
                    String sentence = Console.ReadLine();
                    menu.everyOther(sentence);
                    return 1;
                default: //incorrect input
                    return -1;
            }

        }

        //hello world exercise
        void hello_world()
        {
            Console.WriteLine("\n>Hello World!");
        }

        //takes two integer bounds and generates a random number 
        //between them
        void randBetween(int lowerBound, int upperBound)
        {
            Random random = new Random();
            int rng = random.Next(lowerBound,upperBound);
            Console.WriteLine("a random number between" + lowerBound + " and " + upperBound + " is " + rng);
        }

        //takes a string and prints every other word in it
        void everyOther(String input)
        {
            String output = "";
            int pr = 1; //prints every other
            foreach(string word in input.Split(' '))
            {
                if (pr == 1)
                {
                    output += "[" + word + "]";
                }
                pr = pr * -1; //alternate
            }
            Console.WriteLine("\nThe inputed sentence with every other word removed is");
            Console.WriteLine(output + '\n');
        }
    }
}
