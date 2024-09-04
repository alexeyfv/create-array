using System.Buffers;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark;

[CategoriesColumn]
[MemoryDiagnoser]
[SimpleJob(iterationCount: 25)]
public class Benchmark
{
    public static IEnumerable<int> GenerateLarge()
    {
        for (int i = 10; i < 100; i += 10) yield return i;
        for (int i = 100; i < 1_000; i += 100) yield return i;
        for (int i = 1_000; i < 10_000; i += 1000) yield return i;
        for (int i = 10_000; i < 100_000; i += 10_000) yield return i;
        for (int i = 100_000; i <= 1_000_000; i += 100_000) yield return i;
    }

    [ParamsSource(nameof(GenerateLarge))]
    public int Size { get; set; }

    [Benchmark(Baseline = true)]
    public int New()
    {
        var sum = 0;
        int[] array = new int[Size];
        for (var i = 0; i < Size; i++) sum += array[i];
        return sum;
    }

    [Benchmark]
    public int Stackalloc()
    {
        var sum = 0;
        Span<int> array = stackalloc int[Size];
        for (var i = 0; i < Size; i++) sum += array[i];
        return sum;
    }

    [Benchmark]
    public int GcAllocateUninitializedArray<T>()
    {
        var sum = 0;
        int[] array = GC.AllocateUninitializedArray<int>(Size);
        for (var i = 0; i < Size; i++) sum += array[i];
        return sum;
    }

    [Benchmark]
    public int ArrayPoolRent()
    {
        var sum = 0;
        int[] array = ArrayPool<int>.Shared.Rent(Size);
        for (var i = 0; i < Size; i++) sum += array[i];
        ArrayPool<int>.Shared.Return(array);
        return sum;
    }

    [Benchmark]
    public int ArrayCreateInstance()
    {
        var sum = 0;
        var array = (int[])Array.CreateInstance(typeof(int), Size);
        for (var i = 0; i < Size; i++) sum += array[i];
        return sum;
    }
}

