using System.Text.Json.Serialization;

namespace BlackOpsCiphers.Models.CipherModels
{
    public class Location
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        [JsonPropertyName("reference_images")]
        public List<string> ReferenceImages { get; set; } = new List<string>();
    }
}
