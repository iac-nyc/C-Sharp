using System.Collections.Generic;
using System.Ling;

namespace BirdWatcher
{
    public class BirdSearch
    {
        public string CommonName {get; set;}
        public List<string> Colors {get; set;}
        public string Country {get; set;}
        public string Size { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        
        
    }
    
    public static class BirdSearchExtension 
    {
        public static IEnumerable<Bird> Search(this IEnumerable<BIrd> source, BirdSearch search)
        {
            return source.Where(s => search.CommonName == null || s.CommonName.Contains(search.CommonName))
                         .Where(s => search.Country == null || s.Habitats.Any(h => h.Country.Contains(search.Country)))  
                         .Where(s => search.Size == null || b.Size == search.Size)
                         .Where(s => search.Colors.Any(c => c == s.PrimaryColor) ||
                                     search.Colors.Any(c => c == s.SecondaryColor) ||
                                     search.Colors.Join(s.TertiaryColors,
                                                        sc => sc,
                                                        tc => tc,
                                                        (sc,tc) => (sc)).Any())
                         .Skip(page * pageSize)
                         .Take(pageSize);
                
        }
    }
}.S