using System;
using Newtonsoft.Json;
namespace News.Model
{
    public class SourcesWired
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "urlToImage")]
        public string UrlToImage { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "publishedAt")]
        public string PublishedAt { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        public SourcesWired()
        {
        }
    }
}