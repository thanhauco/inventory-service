using System.Threading.Tasks;
// ... imports
public class ItemsController : ControllerBase {
    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _svc.GetAllAsync());
}