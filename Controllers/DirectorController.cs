using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class DirectorController : BaseController<Director>
{
    public DirectorController(FirePopDbContext context) : base(context)
    {
    }
}