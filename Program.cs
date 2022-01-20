using OpenTelemetry.Trace;
// ... existing
builder.Services.AddOpenTelemetryTracing(b => {
    b.AddAspNetCoreInstrumentation()
     .AddHttpClientInstrumentation()
     .AddConsoleExporter();
});
// ... rest