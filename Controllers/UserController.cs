using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class UserController : BaseController<User>
{
    public UserController(FirePopDbContext context) : base(context)
    {
    }
}