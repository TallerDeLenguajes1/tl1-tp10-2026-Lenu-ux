using System.Text.Json.Serialization;
namespace EspacioWeb;
// Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);
    public class Web
    {
        [JsonPropertyName("web_pages")]
        public List<string> web_pages { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("country")]
        public string country { get; set; }

        [JsonPropertyName("alpha_two_code")]
        public string alpha_two_code { get; set; }

        [JsonPropertyName("domains")]
        public List<string> domains { get; set; }

        [JsonPropertyName("state-province")]
        public string stateprovince { get; set; }
    }


