IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('[dbo].[usp_GetUsersById]'))
BEGIN
   EXEC('CREATE PROCEDURE [dbo].[usp_GetUsersById] AS BEGIN SET NOCOUNT ON; END')
END
GO

ALTER PROCEDURE [dbo].[usp_GetUsersById]
	@userId INT = NULL
AS
BEGIN
	SET NOCOUNT ON
	SELECT * FROM dbo.Users u
	WHERE u.u_id = @userId
	OR @userId IS NULL
END
GO