using Polly;
// ... existing
builder.Services.AddHttpClient("External", client => {
    client.BaseAddress = new Uri("https://api.example.com");
}).AddTransientHttpErrorPolicy(p => p.WaitAndRetryAsync(3, _ => TimeSpan.FromMilliseconds(600)));
// ... rest