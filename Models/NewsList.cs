using Newtonsoft.Json;

namespace Assignment__1.Models
{
    [Serializable]
    public class NewsList
    {
        [JsonProperty("articles")]
        public IEnumerable<NewsArticle> ?NewsArticles { get; set; }
    }
}
