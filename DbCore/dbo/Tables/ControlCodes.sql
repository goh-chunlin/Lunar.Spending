CREATE TABLE [dbo].[ControlCodes] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Category]  VARCHAR (50)   NOT NULL,
    [Message]   NVARCHAR (MAX) NULL,
    [IsActive]  BIT            NOT NULL,
    [CreatedAt] DATETIME       NOT NULL,
    [UpdatedAt] DATETIME       NOT NULL,
    CONSTRAINT [PK_ControlCodes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

