using HealthChecks.UI.Client;
// ... imports
public class Startup {
    public void Configure(IApplicationBuilder app) {
        app.UseEndpoints(e => {
            e.MapHealthChecks("/health", new HealthCheckOptions { ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse });
            e.MapHealthChecksUI();
            // ... rest
        });
    }
}