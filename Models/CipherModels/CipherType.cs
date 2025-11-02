using System.Text.Json.Serialization;

namespace BlackOpsCiphers.Models.CipherModels
{
    public class CipherType
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        [JsonPropertyName("documentation_link")]
        public string DocumentationLink { get; set; } = string.Empty;
    }
}
