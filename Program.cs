using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using System.Linq;

namespace AdventDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileReader = new StreamReader("AdventDay1Data.csv");

            var csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture);

            csvReader.Configuration.HasHeaderRecord = false;

            var numbers = csvReader.GetRecords<int>().ToList();

            fileReader.Close();

            var isRunning = true;

            // while (isRunning)
            // {
            for (int firstIndex = 0; firstIndex < numbers.Count - 2; firstIndex++)
            {
                for (int secondIndex = 1; secondIndex < numbers.Count - 1; secondIndex++)
                {
                    for (int thirdIndex = 2; thirdIndex < numbers.Count; thirdIndex++)
                    {
                        var sum = numbers[firstIndex] + numbers[secondIndex] + numbers[thirdIndex];
                        if (sum == 2020)
                        {
                            Console.WriteLine($"{numbers[firstIndex]} * {numbers[secondIndex]} * {numbers[thirdIndex]}= {numbers[firstIndex] * numbers[secondIndex] * numbers[thirdIndex]}");
                            goto LoopEnd;
                            // break;
                        }
                    }


                }
            }
        LoopEnd:
            Console.WriteLine("Finished");
            // }
        }
    }
}
