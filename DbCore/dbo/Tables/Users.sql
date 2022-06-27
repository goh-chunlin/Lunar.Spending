CREATE TABLE [dbo].[Users] (
    [Id]        INT                IDENTITY (1, 1) NOT NULL,
    [Username]  NVARCHAR (MAX)     NOT NULL,
    [Password]  NVARCHAR (MAX)     NOT NULL,
    [IsActive]  BIT                NOT NULL,
    [CreatedAt] DATETIMEOFFSET (7) NOT NULL,
    [UpdatedAt] DATETIMEOFFSET (7) NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

