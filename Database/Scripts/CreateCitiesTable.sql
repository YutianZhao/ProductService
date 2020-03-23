IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Cities')
BEGIN
	CREATE TABLE [dbo].[Cities]
	(
		ci_id INT IDENTITY(1, 1) NOT NULL,
		ci_stid INT,
		ci_coid INT,
		ci_cityName NVARCHAR(50) NOT NULL,
	)
END
GO
IF OBJECT_ID('[dbo].[Cities]', 'PK') IS NULL
BEGIN
    ALTER TABLE [dbo].[Cities] 
    ADD CONSTRAINT PK_CITIES PRIMARY KEY CLUSTERED (ci_id)
END
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CITIES_STATES]') AND parent_object_id = OBJECT_ID(N'[dbo].[Cities]'))
BEGIN
	ALTER TABLE [dbo].[Cities]
	ADD CONSTRAINT FK_CITIES_STATES FOREIGN KEY (ci_stid) REFERENCES [dbo].[States] (st_id)
END
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CITIES_COUNTRIES]') AND parent_object_id = OBJECT_ID(N'[dbo].[Cities]'))
BEGIN
	ALTER TABLE [dbo].[Cities]
	ADD CONSTRAINT FK_CITIES_COUNTRIES FOREIGN KEY (ci_coid) REFERENCES [dbo].[Countries] (co_id)
END
GO