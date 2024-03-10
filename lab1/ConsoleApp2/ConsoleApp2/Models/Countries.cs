using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Countries
    {
        public string Title { get; set; }
        public string Cities { get; set; }
        public Countries(string title, string cities)
        {
            Title = title;
            Cities = cities;
        }
        public static void Countriesss(Dictionary<string, string> dic)
        {
            foreach (var obj in dic)
            {
                Console.WriteLine($"В стране {obj.Key} находятся города {obj.Value}");
            }
        }

    }
}
