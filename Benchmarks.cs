using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Security.Cryptography;
using AutoFixture;

namespace LinqTesting
{
    public class Benchmarks
    {
        public List<SampleData>? Samples { get; set; }
        [GlobalSetup]
        public void Setup()
        {
            Fixture fixture = new Fixture();
            Samples = fixture.CreateMany<SampleData>(1_000_00).ToList();
        }
/*
|          Method |     Mean |   Error |  StdDev |
|---------------- |---------:|--------:|--------:|
|      OrderByNew | 167.5 us | 3.34 us | 4.34 us |
| OrderByOriginal | 236.1 us | 4.05 us | 3.59 us |
*/
        [Benchmark]
        public void OrderByNew()
        {
            var result = Samples.If(true,
                    then => then.OrderBy(x => x.StartDate),
                    el => el.OrderByDescending(x => x.StartDate))
                .Skip(50)
                .Take(1_00)
                .ToList();
        }

        [Benchmark]
        public void OrderByOriginal()
        {
            IEnumerable<SampleData>? temp;
            if(true)
                temp = Samples.OrderBy(x => x.StartDate);
            else
                temp = Samples.OrderByDescending(x => x.StartDate);
            var result = temp.Skip(50).Take(1_00).ToList();
        }
    }
}