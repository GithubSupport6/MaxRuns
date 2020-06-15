using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Максимальные_повторы.RAM;
using Максимальные_повторы.RAM.Structures;

namespace Максимальные_повторы
{
    class Program
    {
        static List<int> D = new List<int>() { 2, 3, 5 };

        static public List<int> GetS(string w, int t)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < w.Length; i++)
            {
                if (D.Contains(i % t))
                    res.Add(i);
            }
            return res;
        }

        public class Book
        {
            public string Name { get; set; }
            public string Text { get; set; }
        }


        public void GetData(string path)
        {
            //string pathCsvFile = @"E:\VSProjects\Максимальные повторы\Максимальные повторы\Data\BX-Books.csv";

            //using (StreamReader streamReader = new StreamReader(pathCsvFile))
            //{
            //    using (CsvReader csvReader = new CsvReader(streamReader))
            //    {
            //        // указываем используемый разделитель
            //        csvReader.Configuration.Delimiter = ",";
            //        // получаем строки
            //        IEnumerable<Book> books =
            //            csvReader.GetRecords<Book>();
            //    }
            //}
        }

        static void Main(string[] args)
        {
            
            
            //nloglogn.Run();
            //Console.WriteLine(nloglogn.Run("abcabcabcabcabcabcabcabc"));

            CoarseLCEAlgorithm algorithm = new CoarseLCEAlgorithm();
            algorithm.SetString("aaabaaab");
            Console.WriteLine(algorithm.LCE(0, 4));
            Bannai bannai = new Bannai();
            bannai.algorithm = algorithm;
            //bannai.Run("abaab");

            var nloglogn = new NLogLog();
            //nloglogn.SetString("aaabaaab");
            //Console.WriteLine(nloglogn.LCE(0, 4));

            MainLorenz mainLorenz = new MainLorenz();
            mainLorenz.Run("aaabaaab");

            var startTime = System.Diagnostics.Stopwatch.StartNew();
            string s = "abbbbaafewfe";
            for (int i = 0; i < 1000000; i++)
            {
                mainLorenz.Run("abbbbaafewfe");
            }
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            Console.WriteLine(resultTime);

            Console.ReadKey();
        }
    }
}
