using System.Net.Http.Headers;
using System.Text.Json;
using fPOP_REST.Model;

namespace fPOP_REST.Utilities;

public static class TmdbCaller
{
    private static readonly HttpClient httpClient;
    private static JsonSerializerOptions options = new() { PropertyNameCaseInsensitive = true};
    private const string ApiKey = "eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI1ZWNlYjdmMDk0Y2JkMzYxYmI5MWFjYTk0NmI0NDQ0YiIsIm5iZiI6MS43NDc0MTY5OTQwODMwMDAyZSs5LCJzdWIiOiI2ODI3NzdhMjU5YzM4Njc1ZGRhZGE5YTAiLCJzY29wZXMiOlsiYXBpX3JlYWQiXSwidmVyc2lvbiI6MX0.obcb_apz6qF9E7_oAYLgf4r6Sn2BGZystGJH3fqUtZQ";

    static TmdbCaller()
    {
        httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ApiKey);
    }

    public static async Task<TmdbRes> GetTrendingMovies()
    {
        var res = await httpClient.GetAsync("https://api.themoviedb.org/3/trending/movie/week?language=en-US");
        if (!res.IsSuccessStatusCode) throw new Exception("Failed to fetch data from external apiu");
        var data = await res.Content.ReadAsStringAsync();
        
        return JsonSerializer.Deserialize<TmdbRes>(data, options)!;
    }
    
    
    
}

// https://image.tmdb.org/t/p/original/6FRFIogh3zFnVWn7Z6zcYnIbRcX.jpg