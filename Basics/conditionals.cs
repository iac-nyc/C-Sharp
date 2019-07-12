using System;

namespace IftekharChowdhury.PracticeSession
{
    class Program
    {
        public static void Main()
        {
        
            bool keepGoing = true;
        
            while(keepGoing){
                           
                    Console.Write("Enter a number: ");
                    string entry = Console.ReadLine();                
                                 
                    if(entry == "quit")
                    {
                        keepGoing = false;
                       
                    }
                    else 
                    {
                        int number = int.Parse(entry);
                        int result = number * number;
                        Console.WriteLine($"{entry} multiplied by itself is equal to {result}");
                    }               
                              
               }
                 
                
            Console.WriteLine("Goodbye!");
           
                                     
        }
    }
}