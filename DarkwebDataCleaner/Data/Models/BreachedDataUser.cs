namespace DarkwebDataCleaner.Data.Models
{
    public class BreachedDataUser
    {
        public int BreachRecordId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string Password { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Ip { get; set; }
        public string SecretQuestionOne { get; set; }
        public string SecretAnswerOne { get; set; }
        public string SecretQuestionTwo { get; set; }
        public string SecretAnswerTwo { get; set; }
        public string SecretQuestionThree { get; set; }
        public string SecretAnswerThree { get; set; }
    }
}
