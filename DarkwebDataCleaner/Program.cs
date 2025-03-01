using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace DarkwebDataCleaner;

class Program
{
    static void Main(string[] args)
    {
        const string inputCsvPath = "Data/users.csv";  
        const string outputCsvPath = "breached_users.csv"; 

        var csvProcessor = new CsvProcessor(inputCsvPath, outputCsvPath);
        csvProcessor.ProcessCsv();

        if (File.Exists(outputCsvPath))
        {
            Console.WriteLine($"CSV successfully created at: {Path.GetFullPath(outputCsvPath)}");
        }
        else
        {
            Console.WriteLine("Failed to create CSV.");
        }
    }
}
