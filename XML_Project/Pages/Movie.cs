namespace BookBrowse.Pages
{
   
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text.Json.Serialization;
    using System.Text.Json;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using JsonConverter = Newtonsoft.Json.JsonConverter;
    using JsonSerializer = Newtonsoft.Json.JsonSerializer;
    using JsonConverterAttribute = Newtonsoft.Json.JsonConverterAttribute;

    public class Movie
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("results")]
        public List<MovieResult> Results { get; set; }
    }

    public class MovieResult
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("backDropPath")]
        public string BackDropPath { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("originalLanguage")]
        public long OriginalLanguage { get; set; }

        [JsonProperty("originalTitle")]
        public string OriginalTitle { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("posterPath")]
        public string PosterPath { get; set; }

        [JsonProperty("mediaType")]
        public long MediaType { get; set; }

        [JsonProperty("genreIds")]
        public List<long> GenreIds { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("releaseDate")]
        public DateTimeOffset ReleaseDate { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("voteAverage")]
        public double VoteAverage { get; set; }

        [JsonProperty("voteCount")]
        public long VoteCount { get; set; }
    }
}
