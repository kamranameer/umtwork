CREATE TABLE [dbo].[Packages] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [PkgName]        VARCHAR (50) NULL,
    [PkgDestination] VARCHAR (50) NULL,
    [PkgStatus]      VARCHAR (50) NULL,
    [trackinno]      VARCHAR (50) NULL,
    [PkgDate]        VARCHAR (50) NULL,
    [PkgReceiver]    VARCHAR (50) NULL,
    [PkgSender]      VARCHAR (50) NULL,
    [PkgReceiverAdd] VARCHAR (50) NULL,
    [PkgSenderAdd]   VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

