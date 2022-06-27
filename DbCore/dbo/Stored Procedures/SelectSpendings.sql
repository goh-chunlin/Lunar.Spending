-- =============================================

CREATE PROCEDURE [dbo].[SelectSpendings]
	@RequiredCurrency VARCHAR(3)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

	DECLARE @SQL NVARCHAR(MAX)

	SET @SQL = '
		SELECT [Id], 
			[Description], 
			[Currency],
			[Amount],
			''' + @RequiredCurrency + ''' AS [ConvertedCurrency], 
			[Amount] * [dbo].[fnGetExchangeRate]([Currency], ''' + @RequiredCurrency + ''') AS [ConvertedAmount], 
			[CreatedAt]
		FROM Spendings
		ORDER BY CreatedAt DESC'

	PRINT @SQL  
	EXEC sp_executesql @SQL 
END