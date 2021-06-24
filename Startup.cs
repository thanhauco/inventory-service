using InventoryService.Middleware;
// ... imports
public class Startup {
    public void Configure(IApplicationBuilder app) {
        app.UseMiddleware<CorrelationId>();
        // ... rest
    }
}