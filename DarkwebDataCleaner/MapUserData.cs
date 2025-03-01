using DarkwebDataCleaner.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static DarkwebDataCleaner.MapSecretQuestion;

namespace DarkwebDataCleaner
{
    public class MapUserData
    {
        public List<BreachedDataUser> TransformData(List<User> users)
        {
            var transformedUsers = users.Select(user =>
            {
                var breachedUser = new BreachedDataUser
                {
                    BreachRecordId = user.UserId, //assuming mapped one to one and not needing to be new PK
                    Username = user.UserName,
                    FirstName = user.RealName.Split(' ')[0],
                    FamilyName = user.RealName.Split(' ').Last(),
                    Password = user.Password,
                    Hash = user.PasswordHash,
                    Salt = GenerateSalt(),
                    Email = user.EmailAddress,
                    Gender = user.Gender,
                    Dob = user.BirthDate,
                    Address = user.Location,
                    Ip = user.MemberIp
                };

                SecretQuestionMapper.AssignSecretQuestions(user, breachedUser);

                return breachedUser;
            }).ToList();

            return transformedUsers;
        }

        private string GenerateSalt()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
