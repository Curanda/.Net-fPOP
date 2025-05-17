namespace fPOP_REST.Model;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class TmdbRes
{
    [JsonPropertyName("page")]
    public int Page { get; set; }
    
    [JsonPropertyName("results")]
    public List<TmdbMovie>? Results { get; set; }

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }
    
    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }
}