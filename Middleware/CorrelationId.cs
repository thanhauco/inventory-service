using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;
namespace InventoryService.Middleware {
    public class CorrelationId {
        private readonly RequestDelegate _next;
        public CorrelationId(RequestDelegate next) { _next = next; }
        public async Task Invoke(HttpContext ctx) {
            var id = Guid.NewGuid().ToString();
            ctx.Response.Headers.Add("X-Correlation-ID", id);
            await _next(ctx);
        }
    }
}