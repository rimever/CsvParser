/*
https://qiita.com/kesuzuki/items/202cc58db3fd1763c095

GOROOT、GOPATHの設定を忘れずに
例) GOROOT=c:\tools\go
    GOPATH=c:\tools\go
    PATH=c:\tools\go\bin

最初にパッケージのダウンロードとインストール
c:\>go version
go version go1.4.2 windows/amd64

go get golang.org/x/text/encoding/japanese
go get golang.org/x/text/transform

go run csv.go "入力ファイル.csv" "出力ファイル名.csv"
go build csv.go
*/
package main

import (
	"testing"
	//"fmt"
	"flag"
	"os"
	"encoding/csv"
	"golang.org/x/text/transform"
	"golang.org/x/text/encoding/japanese"
	"log"
	"io"
)



//BenchmarkReadCsv
//Csv読込のベンチマークを行うための関数です。
func BenchmarkReadCsv(b *testing.B) {
	for i := 0; i < b.N; i++ {
		ReadCsvTest()
	}
}

func ReadCsvTest() {
	flag.Parse()
	//読み込みファイル準備
	readFilePath, err := os.Open("KEN_ALL.CSV")
	failOnError(err)
	defer readFilePath.Close()
	reader := csv.NewReader(transform.NewReader(readFilePath, japanese.ShiftJIS.NewDecoder()))
	//  reader := csv.NewReader(transform.NewReader(readFilePath, japanese.EUCJP.NewDecoder()))
	//  reader := csv.NewReader(readFilePath) //utf8
	reader.LazyQuotes = false
	// ダブルクオートを厳密にチェックしない
	reader.Comma = ','
	log.Printf("Start")
	rowCount := 0
	for {
		record, err := reader.Read() // 1行読み出す
		if err == io.EOF {
			break
		} else {
			failOnError(err)
		}
		if len(record[0]) > 0 {

		}
		//		writer.Write(new_record) // 1行書き出す
		//log.Printf("%#v", record)
		rowCount++
	}
	//	writer.Flush()
	log.Printf("Finish %#v", rowCount)
}

