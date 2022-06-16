``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1706 (21H1/May2021Update)
AMD Ryzen 5 2600, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.201
  [Host]     : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT
  DefaultJob : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT


```
|          Method |     Mean |   Error |  StdDev |
|---------------- |---------:|--------:|--------:|
|      OrderByNew | 167.5 μs | 3.34 μs | 4.34 μs |
| OrderByOriginal | 236.1 μs | 4.05 μs | 3.59 μs |
