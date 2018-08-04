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

>       10	 171999880 ns/op	45734149 B/op	  248498 allocs/op

171999880 ns/op = 172ms

かなり早い事になる。
