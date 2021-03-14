using MassTransit;
// ... imports
public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        services.AddMassTransit(x => {
            x.UsingRabbitMq((context, cfg) => cfg.Host("localhost"));
        });
        services.AddMassTransitHostedService();
        // ... rest
    }
}