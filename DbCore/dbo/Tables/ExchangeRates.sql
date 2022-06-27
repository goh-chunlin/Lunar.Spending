CREATE TABLE [dbo].[ExchangeRates] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [FromCurrency] VARCHAR (3)     NOT NULL,
    [ToCurrency]   VARCHAR (3)     NOT NULL,
    [Rate]         DECIMAL (19, 9) NOT NULL,
    [IsActive]     BIT             NOT NULL,
    [CreatedAt]    DATETIME        NOT NULL,
    [UpdatedAt]    DATETIME        NOT NULL,
    CONSTRAINT [PK_ExchangeRates] PRIMARY KEY CLUSTERED ([Id] ASC)
);

