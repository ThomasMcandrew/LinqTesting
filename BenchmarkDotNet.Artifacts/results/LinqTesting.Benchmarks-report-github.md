``` ini

BenchmarkDotNet=v0.13.1, OS=arch 
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.102
  [Host]     : .NET 6.0.2 (6.0.222.11801), X64 RyuJIT
  DefaultJob : .NET 6.0.2 (6.0.222.11801), X64 RyuJIT


```
|                               Method |      Mean |     Error |    StdDev |
|------------------------------------- |----------:|----------:|----------:|
|                           OrderByNew |  5.041 ms | 0.0667 ms | 0.0592 ms |
|                      OrderByOriginal |  3.971 ms | 0.0358 ms | 0.0335 ms |
|      ConditionalQueryChainedWhereNew | 18.889 ms | 0.0969 ms | 0.0809 ms |
| ConditionalQueryChainedWhereOriginal | 20.312 ms | 0.0639 ms | 0.0598 ms |
