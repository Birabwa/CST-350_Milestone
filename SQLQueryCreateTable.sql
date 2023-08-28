CREATE TABLE [dbo].[Register] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Firstname] NVARCHAR (40) NOT NULL,
    [Lastname]  NVARCHAR (40) NOT NULL,
    [Sex]       NVARCHAR (40) NOT NULL,
    [Age]       NVARCHAR (3)  NOT NULL,
    [State]     NVARCHAR (40) NOT NULL,
    [Email]     NVARCHAR (40) NOT NULL,
    [Username]  NVARCHAR (40) NOT NULL,
    [Password]  NVARCHAR (40) NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
);

