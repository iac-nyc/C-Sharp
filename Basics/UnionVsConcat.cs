using System;
using System.Diagnostics;
using System.Linq;

namespace UnionVsConcat
{
    class Program
    {
        public static void Main(string[] args)
        {
            var listA = Enumerable.Range(0, 100000);
            var listB = Enumerable.Range(50000, 100000);
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            var listC = listA.Union(listB);
            stopwatch.Stop();
            
            var unionTicks = stopwatch.ElapsedTicks;
            stopwatch.Restart();
            
            var listD = listA.Concat(listB).Distinct();
            var concatTicks = stopwatch.ElapsedTicks;
            
            Console.WriteLine(string.Format("Union took {0} ticks", unionTicks));            
            Console.WriteLine(string.Format("Concat took {0} ticks", concatTicks));
            
            
            if(unionTicks > concatTicks)
            {
                Console.WriteLine("Concat is faster by {0}",(unionTicks - concatTicks));
            }
            else if (concatTicks > unionTicks)
            {
                 Console.WriteLine("Union is faster by {0}",( concatTicks - unionTicks));
            }
        }
    }
}