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


// LINQ: Range, Empty, and DefaultIfEmpty

var numbers = Enumerable.Range(0,10);
numbers;
/*
{0,1,2,3,4,5,6,7,8,9}
*/

Enumerable.Repeat("LINQ is awesome!",3);
/*
{"LINQ is awesome!","LINQ is awesome!","LINQ is awesome!"}
*/


var blankBirds = Enumerable.Repeat(new Bird(), 2);
/*
{
Name: , Color: , Sightings: 0,
Name: , Color: , Sightings: 0
}
*/

var number = Enumerable.Empty<int>();
number;
// { }



    