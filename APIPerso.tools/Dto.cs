using System.Text.Json.Serialization;

namespace APIPerso.Tools
{
    public class Dto
    {
        [JsonPropertyName("idDrink")]
        public string Id { get; set; }

        [JsonPropertyName("strDrink")]
        public string Name { get; set; }

        [JsonPropertyName("strInstructions")]
        public string Instructions { get; set; }
    }

}


