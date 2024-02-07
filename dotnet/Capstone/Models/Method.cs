using System.Collections.Generic;

namespace Capstone.Models
{
    public class Method
    {
        // Considereing that MashTemp is returned as an object ([]) in the JSON, we will have use a LIST to populate
        public List<MashTemperature> MashTemp { get; set; }
        public Fermentation Fermentation { get; set; }
        public bool Twist { get; set; } // will be returned in the json as null
    }
}
