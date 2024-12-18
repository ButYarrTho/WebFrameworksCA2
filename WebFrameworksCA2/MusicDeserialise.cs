﻿using Newtonsoft.Json;

namespace WebFrameworksCA2
{
    public class Artists
    {
        [JsonProperty("topartists")]
        public Topartists Topartists { get; set; }

        [JsonProperty("results")]
        public SearchResults Results { get; set; }
    }

    public class Topartists
    {
        [JsonProperty("artist")]
        public Artist[] Artist { get; set; }

        [JsonProperty("@attr")]
        public _attr Attr { get; set; }
    }

    public class SearchResults
    {
        [JsonProperty("opensearch:Query")]
        public SearchQuery Query { get; set; }

        [JsonProperty("opensearch:totalResults")]
        public string TotalResults { get; set; }

        [JsonProperty("opensearch:startIndex")]
        public string StartIndex { get; set; }

        [JsonProperty("opensearch:itemsPerPage")]
        public string ItemsPerPage { get; set; }

        [JsonProperty("artistmatches")]
        public ArtistMatches ArtistMatches { get; set; }
    }

    public class SearchQuery
    {
        [JsonProperty("searchTerms")]
        public string SearchTerms { get; set; }

        [JsonProperty("startPage")]
        public string StartPage { get; set; }
    }

    public class ArtistMatches
    {
        [JsonProperty("artist")]
        public Artist[] Artists { get; set; }
    }

    public class Artist
    {
        [JsonProperty("streamable")]
        public string Streamable { get; set; }

        [JsonProperty("image")]
        public Image[] Image { get; set; }

        [JsonProperty("mbid")]
        public string Mbid { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("playcount")]
        public string Playcount { get; set; }

        [JsonProperty("@attr")]
        public _attr1 Attr { get; set; }

        [JsonProperty("listeners")]
        public string Listeners { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Image
    {
        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("#text")]
        public string Text { get; set; }
    }

    public class _attr1
    {
        [JsonProperty("rank")]
        public string Rank { get; set; }
    }

    public class _attr
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("totalPages")]
        public string TotalPages { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("perPage")]
        public string PerPage { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }
    }
}
