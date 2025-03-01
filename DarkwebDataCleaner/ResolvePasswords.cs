using DarkwebDataCleaner.Data.Models;

namespace DarkwebDataCleaner
{
    //public class ResolvePasswords
    //{
    //    public static void AssignPasswordsFromRainbowTable(
    //        List<User> users,
    //        List<RainbowTable> rainbowTable)
    //    {
    //        var rainbowDict = rainbowTable.ToDictionary(entry => entry.Hash, entry => entry.Password);

    //        foreach (var user in users)
    //        {
    //            if (string.IsNullOrWhiteSpace(user.Password))
    //            {
    //                user.Password = rainbowDict[user.Password];
    //            }
    //        }
    //    }
    //}

    //Basically what I was beginning to put in place and wanting to do here was where the password was empty then
    //check if matching password hashes in the list of both objects and when hash == hash then assign 
    //user.Password as rainbowtable Password
}
