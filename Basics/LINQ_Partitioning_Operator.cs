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




////////////////////
////Partitioning////
////////////////////
birds.Take(3);

birds.OrderBy(b => b.Name.Length).Take(3);

/*
Enumerable.Skip(IEnumerable<TSource>, Int32) Method
*/

birds.OrderBy(b => b.Names.length).Skip(3).Take(3);

/*
TakeWhile<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)
*/

birds.OrderBy(b => b.Name.Length).TakeWhile(b =>b.Name.Length < 6);

/*
SkipWhile<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)

Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.
*/


birds.OrderBy(b => b.Name.Length).SkipWhile(b =>b.Name.Length < 6);






















