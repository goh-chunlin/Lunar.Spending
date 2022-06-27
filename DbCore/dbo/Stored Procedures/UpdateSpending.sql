-- =============================================

CREATE PROCEDURE [dbo].[UpdateSpending]
    -- Add the parameters for the stored procedure here
	@SpendingId INT,
	@Description VARCHAR(255),
	@Currency VARCHAR(3),
	@Amount DECIMAL(19,4)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

	DECLARE @TransactionId INT
	DECLARE @TransactionStatusCode INT = 2
	DECLARE @MessageCode INT = 6

    -- Insert statements for procedure here

	IF EXISTS(SELECT 1 FROM [dbo].[Spendings] WHERE [Id] = @SpendingId)
	BEGIN
		BEGIN TRY
			BEGIN  TRAN

				UPDATE [dbo].[Spendings] 
				SET 
					[Description] = @Description,
					[Currency] = @Currency,
					[Amount] = @Amount
				WHERE [Id] = @SpendingId

				SELECT @TransactionId = @SpendingId

				INSERT INTO [dbo].[AuditLogs]
				([Log], [CreatedAt])
				SELECT 
				CONCAT('Updated [dbo].[Spendings] record ', @SpendingId, '.'), GETDATE()

				SET @TransactionStatusCode = 1
				SET @MessageCode = 5 

			COMMIT TRAN
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH

	END

	SELECT @TransactionId AS [Id],
	[dbo].[fnControlCodeMessageGetById](@TransactionStatusCode) AS [TransactionStatus],
	[dbo].[fnControlCodeMessageGetById](@MessageCode) AS [Message]

END