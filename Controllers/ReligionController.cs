using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class ReligionController : BaseController<Religion>
{
    public ReligionController(FirePopDbContext context) : base(context)
    {
    }
}