using System.Text.Json.Serialization;

namespace IDHLDeveloperTest.Models
{
    public class Character
    {
        public int? _id { get; set; }
        public string? url { get; set; }
        public string? name { get; set; }
        public string? imageUrl { get; set; }
        public string[]? films { get; set; }
        public string[]? shortFilms { get; set; }
        public string[]? tvShows { get; set; }
        public string[]? videoGames { get; set; }
        public string[]? parkAttractions { get; set; }
        public string[]? allies { get; set; }
        public string[]? enemies { get; set; }
    }
}
