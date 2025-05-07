using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class SexualOrientationController : BaseController<SexualOrientation>
{
    public SexualOrientationController(FirePopDbContext context) : base(context)
    {
    }
}