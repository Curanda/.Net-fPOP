using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class LanguageController : BaseController<Language>
{
    public LanguageController(fPOP_Context context) : base(context)
    {
    }
}