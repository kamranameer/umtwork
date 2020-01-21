CREATE TABLE [dbo].[Users] (
    [LoginID]  INT IDENTITY (1, 1) NOT NULL,
    [UserName] VARCHAR (50) NULL,
    [Password] VARCHAR (50) NULL,
    [Role]     VARCHAR (50) NULL
);

