# CsvParser
Csvのパーサーライブラリの比較検証のためのリポジトリです。



## 比較結果

下記リンクのcsvファイルでBenchmarkDotNetで試した場合。

http://www.post.japanpost.jp/zipcode/dl/kogaki/zip/ken_all.zip

### C#

|              Method |       Mean |    Error |   StdDev |     Median |
|-------------------- |-----------:|---------:|---------:|-----------:|
|       CsvHelper |   481.0 ms | 36.95 ms | 109.0 ms |   409.9 ms |
| TextFieldParser | 2,841.7 ms | 56.42 ms | 116.5 ms | 2,848.2 ms |

NBenchも試そうと思ったが使い方がよくわからず、あまり流行っていないっぽく見送り。

http://www.aaronstannard.com/introducing-nbench/

### Go

　注目している言語の一つ go言語で試した結果。
  0.09ns = 9.0E-8 ms
  かなり早い事になる。

> C:\Work\Develop\CsvParserBenchmarks\Go>go test -bench . -benchmem
> 2018/08/03 15:53:58 Start
> 2018/08/03 15:53:58 Finish 124234
> goos: windows
> goarch: amd64
> BenchmarkReadCsv-2      2018/08/03 15:53:58 Start
> 2018/08/03 15:53:58 Finish 124234
> 2000000000               0.09 ns/op            0 B/op          0 allocs/op
> PASS
> ok      _/C_/Work/Develop/CsvParserBenchmarks/Go        2.043s


