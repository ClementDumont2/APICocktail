using APIPerso.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIPerso.tools
{
    public class Drinks
    {
        //[JsonPropertyName("drinks")]
        //public List<Cocktail> Cocktails { get; set; }
        public List<Dto> drinks { get; set; }
        
        
    }
}
