-- =============================================
-- Author:      Goh Chun Lin
-- Create Date: 24 May 2022
-- Description: Get the exchange rate between two currencies
-- =============================================
CREATE FUNCTION fnGetExchangeRate
(
    -- Add the parameters for the function here
    @FromCurrency VARCHAR(3) = '',
	@ToCurrency VARCHAR(3) = ''
)
RETURNS DECIMAL(19,9)
AS
BEGIN
    -- Declare the return variable here
    DECLARE @ExchangeRate DECIMAL(19, 9) = 0

    -- Add the T-SQL statements to compute the return value here
    SELECT @ExchangeRate = Rate
	FROM [dbo].[ExchangeRates]
	WHERE [IsActive] = 1 AND [FromCurrency] = @FromCurrency AND [ToCurrency] = @ToCurrency

    -- Return the result of the function
    RETURN @ExchangeRate
END