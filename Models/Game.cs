using System.Text.Json.Serialization;

namespace BlackOpsCiphers.Models
{
    public class Game
    {
        [JsonPropertyName("game_name")]
        public string GameName { get; set; } = string.Empty;
        [JsonPropertyName("alias")]
        public string Alias { get; set; } = string.Empty;
        [JsonPropertyName("maps")]
        public List<Map> Maps { get; set; } = new List<Map>();
    }
}
