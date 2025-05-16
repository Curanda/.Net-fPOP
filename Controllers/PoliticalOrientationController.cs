using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class PoliticalOrientationController : BaseController<PoliticalOrientation>
{
    public PoliticalOrientationController(fPOP_Context context) : base(context)
    {
    }
}