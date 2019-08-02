using System;

namespace FunctionalProgramming
{
    class Program
    {
        
        
        // Delegates
        /*
          Define a method without actually giving it any functionality.
          Bluerint or Signature.
          Describe what it will do, not how it will do it.
          */
        delegate void SayGreeting(string name);
        
       
        public static void SayGoodbye(string name)
        {
            Console.WriteLine(string.Format("See ya later, {0}", name));
        }
        static void Main(string[] args)
        {
            SayGreeting sayGreeting = delegate(string name)
            {
                 Console.WriteLine(string.Format("Hello, {0}", name));
            }; 
            
            Console.WriteLine("What's your name?");
            string input = Console.ReadLine();
            sayGreeting(input);
            Console.ReadLine();
            sayGreeting = new SayGreeting(SayGoodbye);
            sayGreeting(input);
        }
    }
}