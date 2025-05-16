using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class AnimalController : BaseController<Animal>
{
    public AnimalController(fPOP_Context context) : base(context)
    {
    }
}