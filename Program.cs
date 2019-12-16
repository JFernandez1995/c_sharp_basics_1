using System;
using System.Collections.Generic;    //this namespace allows you to use lists

namespace c_sharp_basics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // this will write to the console 
            Console.WriteLine("Hello World!");

            /*strings*/

            //initializing strings
            string example = "Hello" + " World";
            Console.WriteLine(example);

            //String interpolation. Just append $ in string to add assigned value
            string interpolateString = " World";
            Console.WriteLine($"Hello{interpolateString}");


            //Length property of a string. Use '.' operator to see different properties and methods for a string.
            string interpolateString2= "Hello World";
            Console.WriteLine($"Hello World has {interpolateString2.Length}" + " characters");

            //using methods

            string original = "   Hello THERE programmer    ";
            Console.WriteLine($"[{original}]");

            //trimmed beginning
            string trimmedOriginal = original.TrimStart();
            Console.WriteLine($"[{trimmedOriginal }]");


            //trimmed end
            trimmedOriginal = trimmedOriginal.TrimEnd();
            Console.WriteLine($"[{trimmedOriginal }]");

            //replavce methods
            string repHello = "Hello World!";
            Console.WriteLine(repHello);
            repHello = repHello.Replace("Hello", "Sup");
            Console.WriteLine(repHello);


            //contains methods, return true or false if it finds subtring in the string

            string songLyrics = "All I want for Christmas is you ";
            Console.WriteLine(songLyrics.Contains("Christmas"));
            Console.WriteLine(songLyrics.Contains("New Year"));



            /*basic integer math*/

            int a = 5;
            int b = 6;
            int c = a * b;

            Console.WriteLine(c);

            //same operators as c or java
            //precedence like PEMDAS

            int maxINT = int.MaxValue;
            int minINT = int.MinValue;
            Console.WriteLine($"The range of integers go from {minINT} to {maxINT}");

            //overflow
            int overflow = maxINT + 5;
            Console.WriteLine($"This is how much the int will overflow when added 5: {overflow}");

            //doubles contain floating points


            /*loops*/
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }


            /**/

            var names = new List<string> { "Jessie", "Ana", "Felipe" }; //you can initialize a variable containing a list of strings
            foreach (var name in names) //foreach name in the list
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");  //print out the name
            }

            //add more names
            names.Add("Charles");
            names.Add("Grace");
            names.Add("Maria");

            foreach (var name in names) //foreach name in the list
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");  //print out the name
            }



            //refrencing list by index
            Console.WriteLine($"{names[0]}.");
            Console.WriteLine($"I've added {names[4]} and {names[5]} to the list.");

            //count
            Console.Write("There are " +names.Count + " people in this list" );

            // you can have lists with different types
            //fibonacci

            var fibNums = new List<int> { 1, 1};



            while (fibNums.Count < 20)
            {
                var previous = fibNums[fibNums.Count - 1];
                var previous2 = fibNums[fibNums.Count - 2];

                fibNums.Add(previous + previous2);

            }

            foreach (var item in fibNums)
                Console.WriteLine(item);

            //end fibonacci


        }
    }
}
