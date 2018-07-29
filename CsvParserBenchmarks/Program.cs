using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;

namespace CsvParserBenchmarks
{
    class Program
    {
        /// <summary>
        /// プログラムのメインエントリです。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<CsvParserBenchmark>();
        }
    }
}
