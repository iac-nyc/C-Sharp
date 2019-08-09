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
/////////////////////////
/// Element Operators ///
/////////////////////////

ElementAt
ElementAtOrDefault
First
FirstOrDefault
Single
SingleOrDefault
Last 
LastOrDefault

Single<TSource>(IEnumerable<TSource>)

Returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.
*/

birds.Where(b => b.Name == "Robin").Single();// Name:Robin, Color:Red, Sightings: 5

birds.Single ( b => b.Name == "Dove"); // InvalidOperationException

birds.SingleOrDefault( b => b.Name == "Chickadee"); // null

birds.First(); // Name: Cardinal, Color:Red, Sightings: 3

birds.First(b => b.Color =="Red");// if no match there will exception