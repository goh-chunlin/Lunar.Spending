-- =============================================

CREATE PROCEDURE [dbo].[AddSpending]
    -- Add the parameters for the stored procedure here
	@Description VARCHAR(255),
	@Currency VARCHAR(3),
	@Amount DECIMAL(19,4)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

	DECLARE @TransactionId INT = 0
	DECLARE @TransactionStatusCode INT = 1
	DECLARE @MessageCode INT = 3

    -- Insert statements for procedure here
    INSERT INTO Spendings 
	([Description], [Currency], [Amount], [CreatedAt])
	SELECT 
	@Description, @Currency, @Amount, GETDATE()

	SELECT @TransactionId = SCOPE_IDENTITY()

	SELECT @TransactionId AS [Id],
	@TransactionStatusCode,
	[dbo].[fnControlCodeMessageGetById](@TransactionStatusCode) AS [TransactionStatus],
	@MessageCode,
	[dbo].[fnControlCodeMessageGetById](@MessageCode) AS [Message]

END