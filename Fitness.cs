using System;
namespace ChowdhuryFitness.FitnessJunky{
    class Program {
        static void Main(){
            // Prompt user for minutes exercised 
            // Add minutes exercised to total 
            // Display total minutes exercised to the screen 
            // Repeat until user quits 
            
           
            
                 double runningTotal = 0;
                 bool keepGoing = true; 
            
                 while(keepGoing){
                    Console.Write("How many minutes you exercised or type 'q' to exit: ");
                    string entry = System.Console.ReadLine();
                     
                  
                     
                     if(entry.ToLower() == "q"){
                        // keepGoing = false;
                         break;
                     }else {
                    
                        
                         try{
                            double minutes = double.Parse(entry);
                             
                             if(minutes <=0){
                                 Console.WriteLine(minutes + " is not an acceptable value.");
                              continue;
                          }   
                           else if( minutes <= 10){
                              Console.WriteLine("Beter than nothing!");
                          } else if(minutes <=30){
                            Console.WriteLine("Way to go Ninja Warrior!");
                          } else if(minutes >30 && minutes <=60){
                            Console.WriteLine("Wow, you're tough");
                          } else {
                            Console.WriteLine("OK! You're showing off!");
                          } 
                                runningTotal += minutes;
                             
                         }catch(FormatException){
                             Console.WriteLine("Not a valid input");
                             continue;
                         
                         }
                      
                          
                   Console.WriteLine("You've entered "+runningTotal+" minutes");
                     }
                }
            Console.WriteLine("Goodbye");
        }
    }
}
