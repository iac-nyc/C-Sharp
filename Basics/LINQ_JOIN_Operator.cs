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
////JOINS///////////
////////////////////

var colors = new List<string> {"Red", "Blue", "Purple"};

var favoriteBirds = from b in birds
                    join c in colors on b.Color equals c
                    select b;
favoriteBirds;
/*
{
Name: Cardinal, Color: Red, Sightings: 3,
Name: Robin, Color: Red, Sightings: 5,
Name: Blue Jay, Color: Blue, Sightings: 1
}
*/

////////////////////////////////
// IEnumerable<T> 
// The first sequence to join.
///////////////////////////////
/* outer.Join(inner,
             outerKeySelector,
             innerKeySelector,
             resultSelector);

*/
///////////////////////////////////
var favBirds = birds.Join(colors,
                         b => b.Color,
                         c => c,
                         (bird, color) => bird);
/*
{
Name: Cardinal, Color: Red, Sightings: 3,
Name: Robin, Color: Red, Sightings: 5,
Name: Blue Jay, Color: Blue, Sightings: 1
}
*/

// An Enumerable of Anonymously typed objects
var favBirds = birds.Join(colors,
                         b => b.Color,
                         c => c,
                        (bird, color) => new { Color = color, Bird = bird});

 /*
{{
Color = Red, Bird = Name: Cardinal, Color: Red, Sightings: 3,
Color = Red, Bird = Name: Robin, Color: Red, Sightings: 5,
Color = Red, Bird = Name: Blue Jay, Color: Blue, Sightings: 1
}}
*/                   























