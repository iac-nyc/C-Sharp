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


birds.GroupBy(b => b.Color).Select(g => new { Color = g.Key, Count = g.Count()});

/*
{
{ Color = Red, Count = 2},
{ Color = White, Count = 1},
{ Color = Blue, Count = 1},
{ Color = Yellow, Count = 1}
}
*/

birds.Sum(b => b.Sightings);
// 11

birds.GroupBy(b => b.Color).Select(g => new { Color = g.Key, Sightings = g.Sum(b => b.Sightings )});

/*
{
{Color = Red, Sightings = 8},
{Color = White, Sightings = 2},
{Color = Yello, Sightings = 0},
{Color = Blue, Sightings = 1}
}
*/


birds.Average(b => b.Sightings);

birds.Min(b => b.Sightings);

birds.Max(b => b.Sightings);


    