using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using InventoryService.Data;
namespace InventoryService { public class Startup { public void ConfigureServices(IServiceCollection services) { services.AddDbContext<InventoryContext>(o => o.UseInMemoryDatabase("Inv")); services.AddControllers(); } public void Configure(IApplicationBuilder app) { app.UseRouting(); app.UseEndpoints(e => e.MapControllers()); } } }