using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class CountryController : BaseController<Country>
{
    public CountryController(fPOP_Context context) : base(context)
    {
    }
}