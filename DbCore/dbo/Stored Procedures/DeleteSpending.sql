-- =============================================

CREATE PROCEDURE [dbo].[DeleteSpending]
    -- Add the parameters for the stored procedure here
	@SpendingId INT
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

	DECLARE @TransactionId INT
	DECLARE @TransactionStatusCode INT = 2
	DECLARE @MessageCode INT = 8

    -- Insert statements for procedure here

	IF EXISTS(SELECT 1 FROM [dbo].[Spendings] WHERE [Id] = @SpendingId)
	BEGIN
		DELETE FROM [dbo].[Spendings] 
		WHERE [Id] = @SpendingId

		SET @TransactionStatusCode = 1
		SET @MessageCode = 7
	END

	SELECT @TransactionId = SCOPE_IDENTITY()

	SELECT @TransactionId AS [Id],
	[dbo].[fnControlCodeMessageGetById](@TransactionStatusCode) AS [TransactionStatus],
	[dbo].[fnControlCodeMessageGetById](@MessageCode) AS [Message]

END