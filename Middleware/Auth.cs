using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
namespace InventoryService.Middleware { public class Auth { private readonly RequestDelegate _next; public Auth(RequestDelegate next) { _next = next; } public async Task Invoke(HttpContext ctx) { if(!ctx.Request.Headers.ContainsKey("Auth")) { ctx.Response.StatusCode = 401; return; } await _next(ctx); } } }