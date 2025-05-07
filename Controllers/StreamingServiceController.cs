using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class StreamingServiceController : BaseController<StreamingService>
{
    public StreamingServiceController(FirePopDbContext context) : base(context)
    {
    }
}