CREATE TABLE [dbo].[People] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [FIO]      VARCHAR (50) NULL,
    [Birthday] VARCHAR (50) NULL,
    [Email]    VARCHAR (50) NULL,
    [Phone]    VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
