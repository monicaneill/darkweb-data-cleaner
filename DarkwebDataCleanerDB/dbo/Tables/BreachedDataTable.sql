CREATE TABLE [dbo].[BreachedDataTable]
(
    BreachRecordId INT PRIMARY KEY, 
    Username NVARCHAR(255),
    FirstName NVARCHAR(255),
    FamilyName NVARCHAR(255),
    Password NVARCHAR(255),
    Hash NVARCHAR(255),
    Salt NVARCHAR(255),
    Email NVARCHAR(255),
    Gender NVARCHAR(50),
    Dob DATE,
    Address NVARCHAR(500),
    Ip NVARCHAR(50),
    SecretQuestionOne NVARCHAR(255),
    SecretAnswerOne NVARCHAR(255),
    SecretQuestionTwo NVARCHAR(255),
    SecretAnswerTwo NVARCHAR(255),
    SecretQuestionThree NVARCHAR(255),
    SecretAnswerThree NVARCHAR(255)
);