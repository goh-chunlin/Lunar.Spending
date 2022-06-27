CREATE TABLE [dbo].[AuditLogs] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Log]       NVARCHAR (MAX) NULL,
    [CreatedAt] DATETIME       NOT NULL,
    CONSTRAINT [PK_CAuditLogs] PRIMARY KEY CLUSTERED ([Id] ASC)
);

