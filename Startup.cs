using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using InventoryService.Data;
using InventoryService.Services;
using InventoryService.Middleware;
namespace InventoryService { public class Startup { public void ConfigureServices(IServiceCollection services) { services.AddDbContext<InventoryContext>(o => o.UseInMemoryDatabase("Inv")); services.AddScoped<IItemService, ItemService>(); services.AddControllers(); services.AddSwaggerGen(); services.AddHealthChecks(); } public void Configure(IApplicationBuilder app) { app.UseSwagger(); app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API")); app.UseMiddleware<Auth>(); app.UseRouting(); app.UseEndpoints(e => { e.MapControllers(); e.MapHealthChecks("/health"); }); } } }