-- =============================================
-- Author:      Goh Chun Lin
-- Create Date: 24 May 2022
-- Description: Get the message/content of a defined code
-- =============================================
CREATE FUNCTION [fnControlCodeMessageGetById]
(
    -- Add the parameters for the function here
    @CodeId INT
)
RETURNS NVARCHAR(MAX)
AS
BEGIN
    -- Declare the return variable here
    DECLARE @ResultVar NVARCHAR(MAX)

    -- Add the T-SQL statements to compute the return value here
    SELECT @ResultVar = [Message]
	FROM ControlCodes
	WHERE Id = @CodeId

    -- Return the result of the function
    RETURN @ResultVar
END