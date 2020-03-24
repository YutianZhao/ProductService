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
	SELECT 
		u.u_id,
		u.u_firstName,
		u.u_middleName,
		u.u_lastName,
		u.u_email,
		u.u_phoneNumber,
		u.u_address1,
		u.u_address2,
		ci.ci_cityName,
		st.st_stateName,
		co.co_countryName,
		u.u_zip,
		u.u_userName,
		u.u_createDate,
		u.u_updateDate
	FROM dbo.Users u
	INNER JOIN [dbo].[Cities] ci on u.u_ciid = ci.ci_id
	INNER JOIN [dbo].[States] st on u.u_stid = st.st_id
	INNER JOIN [dbo].[Countries] co on u.u_coid = co.co_id
	WHERE u.u_id = @userId
	OR @userId IS NULL
END
GO