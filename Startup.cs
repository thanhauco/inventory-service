using HotChocolate;
// ... imports
public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        services.AddGraphQLServer().AddQueryType<Query>();
        // ... rest
    }
    public void Configure(IApplicationBuilder app) {
        app.UseEndpoints(e => {
            e.MapGraphQL();
            e.MapControllers();
        });
    }
}