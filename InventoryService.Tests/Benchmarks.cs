using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
public class Benchmarks {
    [Benchmark]
    public void TestMethod() { /* ... */ }
}
// Program.cs in test project needs to run BenchmarkRunner.Run<Benchmarks>();