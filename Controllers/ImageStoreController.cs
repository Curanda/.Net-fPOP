using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class ImageStoreController : BaseController<ImageStore>
{
    public ImageStoreController(FirePopDbContext context) : base(context)
    {
    }
}