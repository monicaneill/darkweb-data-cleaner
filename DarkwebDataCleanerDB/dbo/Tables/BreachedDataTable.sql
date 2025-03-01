CREATE TABLE [dbo].[BreachedDataTable]
(
	breach_record_id INT PRIMARY KEY, 
    username NVARCHAR(255),
    first_name NVARCHAR(255),
    family_name NVARCHAR(255),
    password NVARCHAR(255),
    hash NVARCHAR(255),
    salt NVARCHAR(255),
    email NVARCHAR(255),
    gender NVARCHAR(50),
    dob DATE,
    address NVARCHAR(500),
    ip NVARCHAR(50),
    secret_question_one NVARCHAR(255),
    secret_answer_one NVARCHAR(255),
    secret_question_two NVARCHAR(255),
    secret_answer_two NVARCHAR(255),
    secret_question_three NVARCHAR(255),
    secret_answer_three NVARCHAR(255)
)
