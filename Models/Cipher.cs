using System.Text.Json.Serialization;
using BlackOpsCiphers.Models.CipherModels;

namespace BlackOpsCiphers.Models
{
    public class Cipher
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        [JsonPropertyName("location")]
        public Location Location { get; set; } = new Location();
        [JsonPropertyName("type")]
        public CipherType Type { get; set; } = new CipherType();
        [JsonPropertyName("texture_name")]
        public string TextureName { get; set; } = string.Empty;
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;
        [JsonPropertyName("ciphertext")]
        public string Ciphertext { get; set; } = string.Empty;
        [JsonPropertyName("is_solved")]
        public bool IsSolved { get; set; }
        [JsonPropertyName("plaintext")]
        public string Plaintext { get; set; } = string.Empty;
        [JsonPropertyName("formatted_plaintext")]
        public string FormattedPlaintext { get; set; } = string.Empty;
        [JsonPropertyName("anomalies")]
        public List<Anomaly> Anomalies { get; set; } = new List<Anomaly>();
        [JsonPropertyName("notes")]
        public List<string> Notes { get; set; } = new List<string>();
        [JsonPropertyName("relationships")]
        public List<Relationship> Relationships { get; set; } = new List<Relationship>();
        [JsonPropertyName("steps")]
        public List<string> Steps { get; set; } = new List<string>();
        [JsonPropertyName("order")]
        public int Order { get; set; }
    }
}
