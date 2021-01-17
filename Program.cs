using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using InventoryService.Data;
namespace InventoryService { public class Program { public static void Main(string[] args) { var host = CreateHostBuilder(args).Build(); using(var scope = host.Services.CreateScope()) { DbSeeder.Seed(scope.ServiceProvider.GetRequiredService<InventoryContext>()); } host.Run(); } public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); }); } }