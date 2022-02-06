using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
public class IntegrationTests : IClassFixture<WebApplicationFactory<Program>> {
    private readonly WebApplicationFactory<Program> _factory;
    public IntegrationTests(WebApplicationFactory<Program> factory) { _factory = factory; }
    [Fact]
    public async Task Get_EndpointsReturnSuccess() {
        var client = _factory.CreateClient();
        var response = await client.GetAsync("/minimal");
        response.EnsureSuccessStatusCode();
    }
}