using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCaliWebApp.Models
{
    public class RandomFacts
    {
        public string Key { get; set; }
        public string Fact { get; set; }

        public string Refresh = "Refresh to see other facts";

    }

    public class RandomFactsDataContext
    {
        public IEnumerable<RandomFacts> GetRandomFacts()
        {
            return new[]
            {
                new RandomFacts {Key = "Første Fact" , Fact = "2+2=4" },
                new RandomFacts {Key = "Anden Fact" , Fact = "Dette er dynamisk indhold"},
                new RandomFacts {Key =  "Tredje Fact", Fact = "Hunde > Katte"} 

            };



        }
    }
    
}
