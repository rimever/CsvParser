# CsvParser
Csvのパーサーライブラリの比較検証のためのリポジトリです。



## 比較結果

下記リンクのcsvファイルでBenchmarkDotNetで試した場合。

http://www.post.japanpost.jp/zipcode/dl/kogaki/zip/ken_all.zip


|              Method |       Mean |    Error |   StdDev |     Median |
|-------------------- |-----------:|---------:|---------:|-----------:|
|       CsvHelper |   481.0 ms | 36.95 ms | 109.0 ms |   409.9 ms |
| TextFieldParser | 2,841.7 ms | 56.42 ms | 116.5 ms | 2,848.2 ms |

## おまけ

NBenchも試そうと思ったが使い方がよくわからず、あまり流行っていないっぽく見送り。

http://www.aaronstannard.com/introducing-nbench/
