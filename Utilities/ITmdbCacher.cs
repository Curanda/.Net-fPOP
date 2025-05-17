using fPOP_REST.Model;

namespace fPOP_REST.Utilities;

public interface ITmdbCacher
{
    TmdbRes? TrendingMovies { get; }
    DateTime LastRefreshed { get; }
    Task RefreshAsync();
}