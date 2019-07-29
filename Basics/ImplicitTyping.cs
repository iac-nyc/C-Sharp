using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdWatcher
{
    public class Bird
    {
        public Bird(string name, string color, int sightings)
        {
            Name = name;
            Color = color;
            Sightings = sightings;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Sightings { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Color: {1}, Sightings: {2}\n", Name, Color, Sightings);
        }
    }

    public static class BirdRepository
    {
        public static List<Bird> LoadBirds()
        {
            return new List<Bird>
            {
                new Bird ( "Cardinal", "Red", 3 ),
                new Bird ( "Dove", "White", 2 ),
                new Bird ( "Robin", "Red", 5 ),
                new Bird ( "Canary", "Yellow", 0 ),
                new Bird ( "Blue Jay", "Blue", 1 )
            };
        }
    }
}


// Implicit Typing

var canary = new Bird {Name="Canary", Color="Yellow", Sightings = 99};                              
birds.Add(canary);                                                                                  
birds;
/*
{ Name: Cardinal, Color: Red, Sightings: 3                                                                  
, Name: Dove, Color: White, Sightings: 2                                                                    
, Name: Robin, Color: Red, Sightings: 5                                                                     
, Name: Blue Jay, Color: Blue, Sightings: 1                                                                 
, Name: Canary, Color: Yellow, Sightings: 99                                                                
 }
*/

foreach(var bird in birds)                                                                          
{                                                                                                   
    Console.WriteLine(bird.Name);                                                                   
}

/*
Cardinal                                                                                                    
Dove                                                                                                        
Robin                                                                                                       
Blue Jay                                                                                                    
Canary
*/



// LINQ
from b in birds                                                                                     
where b.Color == "Red"                                                                              
select b;   
/*
{ Name: Cardinal, Color: Red, Sightings: 3                                                                  
, Name: Robin, Color: Red, Sightings: 5                                                                     
 }  
 */



from b in birds                                                                                     
where b.Color =="Red"                                                                               
select b.Name;  // { "Cardinal", "Robin" }


// Projecting LINQ Anonymous Types
from b in birds                                                                                     
where b.Color == "Red"                                                                              
select new { b.Name, b.Color };  //{ { Name = Cardinal, Color = Red }, { Name = Robin, Color = Red } }    





// Specify property name
from b in birds                                                                                                                                                                              
where b.Color =="Red"                                                                                                                                                                        
select new { BirdName = b.Name, BirdColor = b.Color};                                                                                                                                        
// { { BirdName = Cardinal, BirdColor = Red }, { BirdName = Robin, BirdColor = Red } }  



// Anonymous tyes
var anonymousPidgeon = new { Name ="Pidgeon", Color="White", Sightings=9};                                           
var anonymousCrow = new { Name="Crow", Color="Black", Sightings = 333};                                              
                                             
anonymousPidgeon.GetType() == anonymousCrow.GetType();                                                               
// true    


birds.Add(new Bird{                                                                                                  
    Name = anonymousCrow.Name,                                                                                       
    Color = anonymousCrow.Color,                                                                                     
    Sightings = anonymousCrow.Sightings                                                                              
}); 



///Ordering//

from b in birds                                                                                                      
orderby b.Name                                                                                                       
select b.Name;                                                                                                       
// { "Blue Jay", "Canary", "Cardinal", "Crow", "Dove", "Robin" } 



// Descending order
from b in birds                                                                                                      
orderby b.Name descending                                                                                            
select b.Name;                                                                                                       
// { "Robin", "Dove", "Crow", "Cardinal", "Canary", "Blue Jay" }  


// Descending order with Specific property
from b in birds                                                                                                      
orderby b.Color, b.Sightings descending                                                                              
select new { b.Name, b.Sightings };                                                                                  
/*
{ { Name = Crow, Sightings = 333 }, 
  { Name = Blue Jay, Sightings = 1 }, 
  { Name = Robin, Sightings = 5 }, 
  { Name = Cardinal, Sightings = 3 }, 
  { Name = Dove, Sightings = 2 }, 
  { Name = Canary, Sightings = 99 } }     
*/


// Group By 
var birdsByColor = from b in birds 
                   group b by b.Color;

foreach(var bird in birdsByColor)
{
    Consoel.WriteLine(bird.Key + " " + bird.Count());
}
/*
Red 2
White 2
Blue 1
Black 1
*/

//
// into keyword
//
from b in birds
group b by b.Color into birdsByColor
where birdsByColor.Count() > 1
select new { Color = birdsByColor.Key, Count = birdsByColor.Count() };

/*
{
{Color = Red, Count = 2},
{Color = White, Count = 2}
}
*/