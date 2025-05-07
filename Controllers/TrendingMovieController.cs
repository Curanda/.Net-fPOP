using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class TrendingMovieController : BaseController<TrendingMovie>
{
    public TrendingMovieController(FirePopDbContext context) : base(context)
    {
    }
}