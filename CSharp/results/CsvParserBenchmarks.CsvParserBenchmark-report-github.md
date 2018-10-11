``` ini

BenchmarkDotNet=v0.11.1, OS=Windows 10.0.17134.345 (1803/April2018Update/Redstone4)
Intel Core i7-7920HQ CPU 3.10GHz (Kaby Lake), 1 CPU, 2 logical and 2 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3190.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3190.0


```
|              Method |       Mean |     Error |    StdDev |
|-------------------- |-----------:|----------:|----------:|
|       LoadCsvHelper |   379.9 ms |  7.501 ms |  7.703 ms |
| LoadTextFieldParser | 1,861.5 ms | 36.662 ms | 39.228 ms |
