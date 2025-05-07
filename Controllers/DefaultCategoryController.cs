using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class DefaultCategoryController : BaseController<DefaultCategory>
{
    public DefaultCategoryController(FirePopDbContext context) : base(context)
    {
    }
}