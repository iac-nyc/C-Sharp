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
Extension Methods:

Extension methods enable you to "add" methods to existing types without creating a new derived type, 
recompiling, or otherwise modifying the original type. Extension methods are a special kind of static method, 
but they are called as if they were instance methods on the extended type.
*/

///
// Where<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)
// Filters a sequence of values based on a predicate.   
//

birds.Where( (b) => b.Color == "Red"):

birds.Where( b => b.Color == "Red").OrderBy (b => b.Name);

birds.OrderByDescending ( b => b.Color );