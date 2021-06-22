using Prometheus;
// ... imports
public class Startup {
    public void Configure(IApplicationBuilder app) {
        app.UseMetricServer();
        app.UseHttpMetrics();
        // ... rest
    }
}