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

            while (isRunning)
            {
                for (int firstIndex = 0; firstIndex < numbers.Count - 1; firstIndex++)
                {
                    for (int secondIndex = 1; secondIndex < numbers.Count; secondIndex++)
                    {
                        var sum = numbers[firstIndex] + numbers[secondIndex];
                        if (sum == 2020)
                        {
                            Console.WriteLine($"{numbers[firstIndex]} * {numbers[secondIndex]} = {numbers[firstIndex] * numbers[secondIndex]}");
                            isRunning = false;
                            break;
                        }

                    }
                }
            }
        }
    }
}
