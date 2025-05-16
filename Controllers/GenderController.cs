using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class GenderController : BaseController<Gender>
{
    public GenderController(fPOP_Context context) : base(context)
    {
    }
}