using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;

public class User
{
    [Name("user_id")]
    public int UserId { get; set; }

    [Name("user_name")]
    public string UserName { get; set; }

    [Name("date_registered")]
    public DateTime DateRegistered { get; set; }

    [Name("last_login")]
    public DateTime LastLogin { get; set; }

    [Name("real_name")]
    public string RealName { get; set; }

    [Name("password")]
    public string Password { get; set; }

    [Name("password_hash")]
    public string PasswordHash { get; set; }

    [Name("email_address")]
    public string EmailAddress { get; set; }

    [Name("gender")]
    public string Gender { get; set; }

    [Name("birthdate")]
    public DateTime BirthDate { get; set; }

    [Name("location")]
    public string Location { get; set; }

    [Name("show_online")]
    public byte ShowOnline { get; set; }

    [Name("member_ip")]
    public string MemberIp { get; set; }

    [Name("secret_question")]
    public string SecretQuestion { get; set; }

    [Name("secret_answer")]
    public string SecretAnswer { get; set; }
}
