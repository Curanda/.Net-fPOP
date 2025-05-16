using fPOP_REST.Data;
using fPOP_REST.Model;

namespace fPOP_REST.Controllers;

public class StreamingServiceController : BaseController<StreamingService>
{
    public StreamingServiceController(fPOP_Context context) : base(context)
    {
    }
}