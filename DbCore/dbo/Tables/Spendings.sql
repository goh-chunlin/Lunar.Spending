CREATE TABLE [dbo].[Spendings] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (255)   NOT NULL,
    [Amount]      DECIMAL (19, 4) NOT NULL,
    [CreatedAt]   DATETIME        NOT NULL,
    [Currency]    VARCHAR (3)     NOT NULL,
    CONSTRAINT [PK_Spendings] PRIMARY KEY CLUSTERED ([Id] ASC)
);



