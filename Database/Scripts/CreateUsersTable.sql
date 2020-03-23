IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Users')
BEGIN
	CREATE TABLE [dbo].[Users]
	(
		u_id INT IDENTITY(1, 1) NOT NULL,
		u_firstName NVARCHAR(50) NOT NULL,
		u_middleName NVARCHAR(50),
		u_lastName NVARCHAR(50),
		u_email NVARCHAR(100) NOT NULL,
		u_phoneNumber NVARCHAR(50),
		u_address1 NVARCHAR(50) NOT NULL,
		u_address2 NVARCHAR(50),
		u_ciid INT NOT NULL,
		u_stid INT,
		u_coid INT NOT NULL,
		u_zip NVARCHAR(50) NOT NULL,
		u_userName NVARCHAR(50) NOT NULL,
		u_createDate DATETIME NOT NULL,
		u_updateDate DATETIME
	)
END
GO
IF OBJECT_ID('[dbo].[Users]', 'PK') IS NULL
BEGIN
    ALTER TABLE [dbo].[Users] 
    ADD CONSTRAINT PK_USERS PRIMARY KEY CLUSTERED (u_id)
END
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_USERS_CITIES]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
BEGIN
	ALTER TABLE [dbo].[Users]
	ADD CONSTRAINT FK_USERS_CITIES FOREIGN KEY (u_ciid) REFERENCES [dbo].[Cities] (ci_id)
END
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_USERS_STATES]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
BEGIN
	ALTER TABLE [dbo].[Users]
	ADD CONSTRAINT FK_USERS_STATES FOREIGN KEY (u_stid) REFERENCES [dbo].[States] (st_id)
END
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_USERS_COUNTRIES]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
BEGIN
	ALTER TABLE [dbo].[Users]
	ADD CONSTRAINT FK_USERS_COUNTRIES FOREIGN KEY (u_coid) REFERENCES [dbo].[Countries] (co_id)
END
GO