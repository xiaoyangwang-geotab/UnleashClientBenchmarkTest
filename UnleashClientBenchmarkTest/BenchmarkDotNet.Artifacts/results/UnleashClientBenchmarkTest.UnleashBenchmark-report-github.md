```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Intel Core Ultra 7 155H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 8.0.405
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2


```
| Method         | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| TestIsEnabled  | 2.788 μs | 0.0460 μs | 0.0582 μs | 0.1678 |   2.09 KB |
| TestGetVariant | 4.707 μs | 0.0938 μs | 0.1081 μs | 0.2975 |   3.67 KB |
