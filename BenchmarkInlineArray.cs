using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark;

[CategoriesColumn]
[MemoryDiagnoser]
[SimpleJob(iterationCount: 25)]
public class Benchmarkinlinearray
{
    [Benchmark]
    public int InlineArray10()
    {
        var buffer = new Buffer10();
        var sum = 0;
        for (var i = 0; i < 10; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray20()
    {
        var buffer = new Buffer20();
        var sum = 0;
        for (var i = 0; i < 20; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray30()
    {
        var buffer = new Buffer30();
        var sum = 0;
        for (var i = 0; i < 30; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray40()
    {
        var buffer = new Buffer40();
        var sum = 0;
        for (var i = 0; i < 40; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray50()
    {
        var buffer = new Buffer50();
        var sum = 0;
        for (var i = 0; i < 50; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray60()
    {
        var buffer = new Buffer60();
        var sum = 0;
        for (var i = 0; i < 60; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray70()
    {
        var buffer = new Buffer70();
        var sum = 0;
        for (var i = 0; i < 70; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray80()
    {
        var buffer = new Buffer80();
        var sum = 0;
        for (var i = 0; i < 80; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray90()
    {
        var buffer = new Buffer90();
        var sum = 0;
        for (var i = 0; i < 90; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray100()
    {
        var buffer = new Buffer100();
        var sum = 0;
        for (var i = 0; i < 100; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray200()
    {
        var buffer = new Buffer200();
        var sum = 0;
        for (var i = 0; i < 200; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray300()
    {
        var buffer = new Buffer300();
        var sum = 0;
        for (var i = 0; i < 300; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray400()
    {
        var buffer = new Buffer400();
        var sum = 0;
        for (var i = 0; i < 400; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray500()
    {
        var buffer = new Buffer500();
        var sum = 0;
        for (var i = 0; i < 500; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray600()
    {
        var buffer = new Buffer600();
        var sum = 0;
        for (var i = 0; i < 600; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray700()
    {
        var buffer = new Buffer700();
        var sum = 0;
        for (var i = 0; i < 700; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray800()
    {
        var buffer = new Buffer800();
        var sum = 0;
        for (var i = 0; i < 800; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray900()
    {
        var buffer = new Buffer900();
        var sum = 0;
        for (var i = 0; i < 900; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray1000()
    {
        var buffer = new Buffer1000();
        var sum = 0;
        for (var i = 0; i < 1000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray2000()
    {
        var buffer = new Buffer2000();
        var sum = 0;
        for (var i = 0; i < 2000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray3000()
    {
        var buffer = new Buffer3000();
        var sum = 0;
        for (var i = 0; i < 3000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray4000()
    {
        var buffer = new Buffer4000();
        var sum = 0;
        for (var i = 0; i < 4000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray5000()
    {
        var buffer = new Buffer5000();
        var sum = 0;
        for (var i = 0; i < 5000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray6000()
    {
        var buffer = new Buffer6000();
        var sum = 0;
        for (var i = 0; i < 6000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray7000()
    {
        var buffer = new Buffer7000();
        var sum = 0;
        for (var i = 0; i < 7000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray8000()
    {
        var buffer = new Buffer8000();
        var sum = 0;
        for (var i = 0; i < 8000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray9000()
    {
        var buffer = new Buffer9000();
        var sum = 0;
        for (var i = 0; i < 9000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray10000()
    {
        var buffer = new Buffer10000();
        var sum = 0;
        for (var i = 0; i < 10000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray20000()
    {
        var buffer = new Buffer20000();
        var sum = 0;
        for (var i = 0; i < 20000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray30000()
    {
        var buffer = new Buffer30000();
        var sum = 0;
        for (var i = 0; i < 30000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray40000()
    {
        var buffer = new Buffer40000();
        var sum = 0;
        for (var i = 0; i < 40000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray50000()
    {
        var buffer = new Buffer50000();
        var sum = 0;
        for (var i = 0; i < 50000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray60000()
    {
        var buffer = new Buffer60000();
        var sum = 0;
        for (var i = 0; i < 60000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray70000()
    {
        var buffer = new Buffer70000();
        var sum = 0;
        for (var i = 0; i < 70000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray80000()
    {
        var buffer = new Buffer80000();
        var sum = 0;
        for (var i = 0; i < 80000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray90000()
    {
        var buffer = new Buffer90000();
        var sum = 0;
        for (var i = 0; i < 90000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray100_000()
    {
        var buffer = new Buffer100000();
        var sum = 0;
        for (var i = 0; i < 100_000; i++) sum += buffer[i];
        return sum;
    }
    
    [Benchmark]
    public int InlineArray200000()
    {
        var buffer = new Buffer200000();
        var sum = 0;
        for (var i = 0; i < 200000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray300000()
    {
        var buffer = new Buffer300000();
        var sum = 0;
        for (var i = 0; i < 300000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray400000()
    {
        var buffer = new Buffer400000();
        var sum = 0;
        for (var i = 0; i < 400000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray500000()
    {
        var buffer = new Buffer500000();
        var sum = 0;
        for (var i = 0; i < 500000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray600000()
    {
        var buffer = new Buffer600000();
        var sum = 0;
        for (var i = 0; i < 600000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray700000()
    {
        var buffer = new Buffer700000();
        var sum = 0;
        for (var i = 0; i < 700000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray800000()
    {
        var buffer = new Buffer800000();
        var sum = 0;
        for (var i = 0; i < 800000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray900000()
    {
        var buffer = new Buffer900000();
        var sum = 0;
        for (var i = 0; i < 900000; i++) sum += buffer[i];
        return sum;
    }

    [Benchmark]
    public int InlineArray1_000_000()
    {        
        var buffer = new Buffer1000000();
        var sum = 0;
        for (var i = 0; i < 1_000_000; i++) sum += buffer[i];
        return sum;
    }

    [InlineArray(10)]
    public struct Buffer10 { public int Value; }
    
    [InlineArray(10)]
    public struct Buffer1as0 { public string Value; }

    [InlineArray(20)]
    public struct Buffer20 { public int Value; }

    [InlineArray(30)]
    public struct Buffer30 { public int Value; }

    [InlineArray(40)]
    public struct Buffer40 { public int Value; }

    [InlineArray(50)]
    public struct Buffer50 { public int Value; }

    [InlineArray(60)]
    public struct Buffer60 { public int Value; }

    [InlineArray(70)]
    public struct Buffer70 { public int Value; }

    [InlineArray(80)]
    public struct Buffer80 { public int Value; }

    [InlineArray(90)]
    public struct Buffer90 { public int Value; }

    [InlineArray(100)]
    public struct Buffer100 { public int Value; }

    [InlineArray(200)]
    public struct Buffer200 { public int Value; }

    [InlineArray(300)]
    public struct Buffer300 { public int Value; }

    [InlineArray(400)]
    public struct Buffer400 { public int Value; }

    [InlineArray(500)]
    public struct Buffer500 { public int Value; }

    [InlineArray(600)]
    public struct Buffer600 { public int Value; }

    [InlineArray(700)]
    public struct Buffer700 { public int Value; }

    [InlineArray(800)]
    public struct Buffer800 { public int Value; }

    [InlineArray(900)]
    public struct Buffer900 { public int Value; }

    [InlineArray(1000)]
    public struct Buffer1000 { public int Value; }

    [InlineArray(2000)]
    public struct Buffer2000 { public int Value; }

    [InlineArray(3000)]
    public struct Buffer3000 { public int Value; }

    [InlineArray(4000)]
    public struct Buffer4000 { public int Value; }

    [InlineArray(5000)]
    public struct Buffer5000 { public int Value; }

    [InlineArray(6000)]
    public struct Buffer6000 { public int Value; }

    [InlineArray(7000)]
    public struct Buffer7000 { public int Value; }

    [InlineArray(8000)]
    public struct Buffer8000 { public int Value; }

    [InlineArray(9000)]
    public struct Buffer9000 { public int Value; }

    [InlineArray(10_000)]
    public struct Buffer10000 { public int Value; }

    [InlineArray(20_000)]
    public struct Buffer20000 { public int Value; }

    [InlineArray(30_000)]
    public struct Buffer30000 { public int Value; }

    [InlineArray(40_000)]
    public struct Buffer40000 { public int Value; }

    [InlineArray(50_000)]
    public struct Buffer50000 { public int Value; }

    [InlineArray(60_000)]
    public struct Buffer60000 { public int Value; }

    [InlineArray(70_000)]
    public struct Buffer70000 { public int Value; }

    [InlineArray(80_000)]
    public struct Buffer80000 { public int Value; }

    [InlineArray(90_000)]
    public struct Buffer90000 { public int Value; }

    [InlineArray(100_000)]
    public struct Buffer100000 { public int Value; }

    [InlineArray(200_000)]
    public struct Buffer200000 { public int Value; }

    [InlineArray(300_000)]
    public struct Buffer300000 { public int Value; }

    [InlineArray(400_000)]
    public struct Buffer400000 { public int Value; }

    [InlineArray(500_000)]
    public struct Buffer500000 { public int Value; }

    [InlineArray(600_000)]
    public struct Buffer600000 { public int Value; }

    [InlineArray(700_000)]
    public struct Buffer700000 { public int Value; }

    [InlineArray(800_000)]
    public struct Buffer800000 { public int Value; }

    [InlineArray(900_000)]
    public struct Buffer900000 { public int Value; }

    [InlineArray(1_000_000)]
    public struct Buffer1000000 { public int Value; }
}
