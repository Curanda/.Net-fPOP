using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace fPOP_REST.Model;

public class TmdbMovie
{
    private string _posterpath;
    
    
    [JsonPropertyName("backdrop_path")]
    public string BackdropPath { get; set; } = string.Empty;
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;
    
    [JsonPropertyName("original_title")]
    public string OriginalTitle { get; set; } = string.Empty;
    
    [JsonPropertyName("overview")]
    public string Overview { get; set; } = string.Empty;

    [JsonPropertyName("poster_path")]
    public string PosterPath
    {
        get => _posterpath;
        set
        {
            _posterpath = "https://image.tmdb.org/t/p/original"+value;
        }
    }


    [JsonPropertyName("media_type")]
    public string MediaType { get; set; } = string.Empty;
    
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }
    
    [JsonPropertyName("original_language")]
    public string OriginalLanguage { get; set; } = string.Empty;
    
    [JsonPropertyName("genre_ids")]
    public List<int> GenreIds { get; set; } = [];
    
    [JsonPropertyName("popularity")]
    public double Popularity { get; set; }
    
    [JsonPropertyName("release_date")]
    public string ReleaseDate { get; set; } = string.Empty;
    
    [JsonPropertyName("video")]
    public bool Video { get; set; }
    
    [JsonPropertyName("vote_average")]
    public double VoteAverage { get; set; }
    
    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }
}