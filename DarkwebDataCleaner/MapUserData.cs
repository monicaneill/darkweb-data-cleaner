using DarkwebDataCleaner.Data.Models;

namespace DarkwebDataCleaner
{
    public class MapUserData
    {
        public List<BreachedDataUser> TransformData(List<User> users)
        {
            var transformedUsers = users.Select(user => new BreachedDataUser
            {
                BreachRecordId = user.UserId,  //Assuming these are mapped one to one , wasn't sure if needed to be new unique PK
                Username = user.UserName,
                FirstName = user.RealName.Split(' ')[0],
                FamilyName = user.RealName.Split(' ').Last(),
                Password = user.Password,
                Hash = user.PasswordHash,
                Salt = "SomeGeneratedSalt", // know this isn't meant to be re-used but need to think about auto-generating probably use a builder method and pass through AutoFixture for random salt value
                Email = user.EmailAddress,
                Gender = user.Gender,
                Dob = user.BirthDate,
                Address = user.Location,
                Ip = user.MemberIp,
                SecretQuestionOne = user.SecretQuestion,
                SecretAnswerOne = user.SecretAnswer,
                SecretQuestionTwo = user.SecretQuestion,
                SecretAnswerTwo = user.SecretAnswer,
                SecretQuestionThree = user.SecretQuestion,
                SecretAnswerThree = user.SecretAnswer

            }).ToList();

            return transformedUsers;
        }
    }
}