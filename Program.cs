using System;


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

        }
    }
}
