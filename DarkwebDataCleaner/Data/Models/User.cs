namespace DarkwebDataCleaner.Data.Models;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public DateTime DateRegistered { get; set; }
    public DateTime LastLogin { get; set; }
    public string RealName { get; set; }
    public string Password { get; set; }
    public string PasswordHash { get; set; }
    public string EmailAddress { get; set; }
    public string Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string Location { get; set; }
    public byte ShowOnline { get; set; }
    public string MemberIp { get; set; }
    public string SecretQuestion { get; set; }
    public string SecretAnswer { get; set; }
}