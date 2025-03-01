using DarkwebDataCleaner.Data.Models;

namespace DarkwebDataCleaner
{
    public class MapSecretQuestion
    {
        public class SecretQuestionMapper
        {
            private static readonly Dictionary<string, int> QuestionMap = new Dictionary<string, int>
        {
            { "What was the name of your elementary school?", 1 },
            { "What was your first pet's name?", 2 },
            { "What is your favorite book?", 3 } //assuming don't need to worry about variation in capitalisation, punctuation etc
        };

            public static void AssignSecretQuestions(User user, BreachedDataUser breachedUser)
            {
                switch (GetQuestionNumber(user.SecretQuestion))
                {
                    case 1:
                        breachedUser.SecretQuestionOne = user.SecretQuestion;
                        breachedUser.SecretAnswerOne = user.SecretAnswer;
                        break;
                    case 2:
                        breachedUser.SecretQuestionTwo = user.SecretQuestion;
                        breachedUser.SecretAnswerTwo = user.SecretAnswer;
                        break;
                    case 3:
                        breachedUser.SecretQuestionThree = user.SecretQuestion;
                        breachedUser.SecretAnswerThree = user.SecretAnswer;
                        break;
                }
            }

            private static int GetQuestionNumber(string question)
            {
                return QuestionMap.TryGetValue(question, out int number) ? number : 0;
            }
        }
    }
}