using System;

namespace IftekharChowdhury.PracticeSession
{
    class Program
    {
        static void Main()
        {
            // TODO Declare and assign a "thing" string variable.
            // Example: "movie", "book", "color", etc.
          string thing = "movie";
            
            
            // TODO Prompt the user with the text "What is your name?" 
            // and assign their value to a "name" string variable.
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            
            
            // TODO Prompt the user with the text 
            // "What is your favorite <thing>?" 
            Console.Write($"What is your favorite {thing}? ");
            // and assign their value to a "favoriteThing" string variable.
            string favoriteThing = Console.ReadLine();
            
            // TODO Write the user's name and favorite thing to the console.
            // Example: "My name is Iftekhar and my favorite movie is Doctor Zhivago."
            
            Console.WriteLine($"My name is {name} and my favorite movie is {favoriteThing}");
        }
    }
}