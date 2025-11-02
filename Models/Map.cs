using System.Text.Json.Serialization;

namespace BlackOpsCiphers.Models
{
    public class Map
    {
        [JsonPropertyName("map_name")]
        public string MapName { get; set; } = string.Empty;
        [JsonPropertyName("alias")]
        public string Alias { get; set; } = string.Empty;
        [JsonPropertyName("ciphers")]
        public List<Cipher> MapCiphers { get; set; } = new List<Cipher>();
    }
}
