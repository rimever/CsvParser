using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using NUnit.Framework;

namespace CsvHelperPractice
{
    [TestFixture]
    public class NotMappingLoadTest
    {
        /// <summary>
        /// ルートディレクトリ
        /// </summary>
        public static string RootDirectory => Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase
            , @"..\..");
        /// <summary>
        /// 計測用のインデックスのパス
        /// </summary>
        /// <returns></returns>
        private static string CsvLibraryPath()
        {
            return Path.Combine(RootDirectory, "Csv", "KEN_ALL.CSV");
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void LoadToArray()
        {

            var csvFilePath = CsvLibraryPath();
            Assert.IsTrue(File.Exists(csvFilePath));
            var encoding = Encoding.GetEncoding("Shift-JIS");
            using (var reader = new CsvReader(new StreamReader(csvFilePath, encoding))
            {
                Configuration = { HasHeaderRecord = false}
            })
            {
                while (reader.Read())
                {
                    Console.WriteLine(string.Join(",", reader.Context.Record));
                }
            }
        }
        [Test]
        public void WriteNotMapping()
        {
            string path = Path.Combine(RootDirectory, "Csv", "writer.csv");
            List<List<string>> lists = new List<List<string>>
            {
                new List<string>() {"a" + Environment.NewLine + "b", "c", "d"}, new List<string>() {"e", "f", "g"}
            };
            using (var writer = new CsvWriter(new StreamWriter(path,false,Encoding.UTF8))
            {
                Configuration =
                {
                    ShouldQuote = (s, context) => true
                }
            })
            {
                foreach (var list in lists)
                {
                    writer.Context.Record.Clear();
                    writer.Context.Record.AddRange(list);
                    // Quoteがうまく働かない
                    writer.NextRecord();
                }
            }
        }
       /// <summary>
       /// 
       /// </summary>
       [Test]
        public void LoadToDictionary()
        {

            var csvFilePath =Path.Combine(RootDirectory, "Csv", "mushrooms.csv");
            Assert.IsTrue(File.Exists(csvFilePath));
            var encoding = Encoding.GetEncoding("Shift-JIS");
            using (var reader = new CsvReader(new StreamReader(csvFilePath, encoding))
            {
                Configuration = { HasHeaderRecord = false}
            })
            {
                while (reader.Read())
                {
                    
                var dictionary = reader.GetRecord<dynamic>() as IDictionary<string, object>;
                var stringBuilder = new StringBuilder();
                foreach (var pair in dictionary)
                {
                    stringBuilder.Append($"{pair.Key}->{pair.Value},");
                }
                Console.WriteLine(stringBuilder.ToString());
                }
            }
        }
    }
}
