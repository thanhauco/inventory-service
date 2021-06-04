using InventoryService.Middleware;
// ... imports
public class Startup {
    public void Configure(IApplicationBuilder app) {
        app.UseMiddleware<SecurityHeaders>();
        // ... rest
    }
}