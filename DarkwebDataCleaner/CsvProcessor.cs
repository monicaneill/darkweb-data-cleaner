using CsvHelper;
using CsvHelper.Configuration;
using DarkwebDataCleaner;
using DarkwebDataCleaner.Data.Models;
using System.Globalization;

public class CsvProcessor
{
    private readonly string inputCsvPath;
    private readonly string outputCsvPath;

    public CsvProcessor(string inputCsvPath, string outputCsvPath)
    {
        this.inputCsvPath = inputCsvPath;
        this.outputCsvPath = outputCsvPath;
    }

    public void ProcessCsv()
    {
        var users = ReadUsersFromCsv();
        var mapUserData = new MapUserData();
        var transformedUsers = mapUserData.TransformData(users);
        WriteToCsv(transformedUsers, outputCsvPath);
    }

    public List<User> ReadUsersFromCsv()
    {
        using (var reader = new StreamReader(inputCsvPath))
        using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            var users = csv.GetRecords<User>().ToList();
            return users;
        }
    }

    public void WriteToCsv(List<BreachedDataUser> transformedUsers, string outputCsvPath)
    {
        using (var writer = new StreamWriter(outputCsvPath))
        using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            csv.WriteRecords(transformedUsers);
        }
    }
}