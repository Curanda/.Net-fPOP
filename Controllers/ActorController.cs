using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class ActorController : BaseController<Actor>
{
    public ActorController(fPOP_Context context) : base(context)
    {
    }
}