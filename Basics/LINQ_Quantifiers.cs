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


/*
Quantifier operations return a Boolean value 

Methods:

All =	Determines whether all the elements in a sequence satisfy a condition.

Any = Determines whether any elements in a sequence satisfy a condition.

Contains =	Determines whether a sequence contains a specified element.


*/

birds.Any( b => b.Name == "Eagle")
    
if ( !birds.Any (b => b.Name == "Eagle"))
{
    birds.Add(new Bird { Name = "Eagle"});
}