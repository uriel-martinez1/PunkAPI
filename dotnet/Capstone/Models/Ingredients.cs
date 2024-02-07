using System.Collections.Generic;

namespace Capstone.Models
{
    public class Ingredients
    {
        public List<Malt> Malts { get; set; }
        public List<Hop> Hops { get; set; }
        public string Yeast { get; set; }
    }
}
