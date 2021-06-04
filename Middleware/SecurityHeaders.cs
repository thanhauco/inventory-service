using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
namespace InventoryService.Middleware {
    public class SecurityHeaders {
        private readonly RequestDelegate _next;
        public SecurityHeaders(RequestDelegate next) { _next = next; }
        public async Task Invoke(HttpContext ctx) {
            ctx.Response.Headers.Add("X-Frame-Options", "DENY");
            ctx.Response.Headers.Add("X-XSS-Protection", "1; mode=block");
            await _next(ctx);
        }
    }
}