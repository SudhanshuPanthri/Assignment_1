using System.Text.Json.Serialization;

namespace Assignment__1.Models
{
    [Serializable]
    public class NewsArticle
    {
        [JsonPropertyName("author")]
        public string? Author { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("url")]
        public string? url { get; set; }
        [JsonPropertyName("urlToImage")]
        public string? urlToImage { get; set; }
        [JsonPropertyName("publishedAt")]
        public DateTime publishedAt { get; set; }
        [JsonPropertyName("content")]
        public string? content { get; set; }
    }

}
