using System.Text.Json.Serialization;

namespace BlackOpsCiphers.Models.CipherModels
{
    public class Anomaly
    {
        [JsonPropertyName("issue")]
        public string Issue { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
    }
}
