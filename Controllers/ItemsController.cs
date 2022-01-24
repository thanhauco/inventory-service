using Microsoft.Extensions.Configuration;
// ... imports
public class ItemsController : ControllerBase {
    private readonly IConfiguration _config;
    public ItemsController(IConfiguration config) { _config = config; }
    [HttpGet("pricing")]
    public IActionResult GetPricing() {
        if (_config.GetValue<bool>("FeatureFlags:NewPricing")) return Ok("New Pricing");
        return Ok("Old Pricing");
    }
}