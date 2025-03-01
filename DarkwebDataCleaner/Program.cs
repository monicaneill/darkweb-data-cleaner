using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using DarkwebDataCleaner.Data.Models;

namespace DarkwebDataCleaner;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "Data/Models/users.csv";

        // Open the file and read the data.
        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));

        // Read the rows
        var records = csv.GetRecords<User>().ToList();

        foreach (var user in records)
        {
            Console.WriteLine($"User ID: {user.UserId}, " +
                              $"User Name: {user.UserName}, " +
                              $"Date Registered: {user.DateRegistered}, " +
                              $"Last Login: {user.LastLogin}, " +
                              $"Real Name: {user.RealName}, " +
                              $"Password: {user.Password}, " +
                              $"Password Hash: {user.PasswordHash}, " +
                              $"Email Address: {user.EmailAddress}, " +
                              $"Gender: {user.Gender}, " +
                              $"Birth Date: {user.BirthDate}, " +
                              $"Location: {user.Location}, " +
                              $"Show Online: {user.ShowOnline}, " +
                              $"Member IP: {user.MemberIp}, " +
                              $"Secret Question: {user.SecretQuestion}, " +
                              $"Secret Answer: {user.SecretAnswer}");
        }
    }
}