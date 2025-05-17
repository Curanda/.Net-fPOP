using fPOP_REST.Model;

namespace fPOP_REST.Utilities;

public class TmdbCacher: ITmdbCacher
{
    public TmdbRes? TrendingMovies { get; set; }
    public DateTime LastRefreshed { get; set; }
    

    public async Task RefreshAsync()
    {
        try
        {
            TrendingMovies = await TmdbCaller.GetTrendingMovies();
            LastRefreshed = DateTime.Now;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error refreshing cache: {ex.Message}");
            TrendingMovies = null;
        }
    }
    
    
    
}