CREATE TABLE Users (
    UserId INT PRIMARY KEY,
    UserName NVARCHAR(255),
    EmailAddress NVARCHAR(255),
    DateRegistered DATETIME,
    LastLogin DATETIME,
    RealName NVARCHAR(255),
    Password NVARCHAR(255),
    PasswordHash NVARCHAR(255),
    Gender NVARCHAR(10),
    BirthDate DATE,
    Location NVARCHAR(255),
    ShowOnline BIT,
    MemberIp NVARCHAR(50),
    SecretQuestion NVARCHAR(255),
    SecretAnswer NVARCHAR(255)
);