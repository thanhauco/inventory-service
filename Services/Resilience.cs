using System;
using System.Threading.Tasks;
namespace InventoryService.Services { public static class Resilience { public static async Task Retry(Func<Task> action) { try { await action(); } catch { await Task.Delay(100); await action(); } } } }