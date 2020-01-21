CREATE TABLE [dbo].[Users](
    [LoginID] [int] IDENTITY(1,1) NOT NULL,
    [UserName] [varchar](50) NULL,
    [Password] [varchar](50) NULL,
    [Role] [varchar](50) NULL)