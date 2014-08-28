
CREATE DATABASE SDBO_App
GO
USE SDBO_App;
GO

/***************************************************************************************/
-- CREATE GROUP ACCOUNT PAYMENT PLANS
/***************************************************************************************/

/* 
Holds all of the group account payment plans
*/
CREATE TABLE dbo.[PaymentPlanAccount]
(
	PaymentPlanAccountID UNIQUEIDENTIFIER PRIMARY KEY,
	[Name] VARCHAR(300) NOT NULL
)

ALTER TABLE dbo.[PaymentPlanAccount]
    ADD CONSTRAINT DF_PaymentPlanAccount_PaymentPlanAccountID DEFAULT NEWSEQUENTIALID() FOR PaymentPlanAccountID

GO

/***************************************************************************************/
-- CREATE GROUP ACCOUNT PAYMENT PLANS FEES
/***************************************************************************************/

CREATE TABLE PaymentPlanAccountFee
(
	PaymentPlanAccountFeeID UNIQUEIDENTIFIER PRIMARY KEY,
	PaymentPlanAccountID UNIQUEIDENTIFIER NOT NULL,
	Section VARCHAR(500), -- holds the payment type options
	Amount DECIMAL
)


ALTER TABLE dbo.[PaymentPlanAccountFee]
    ADD CONSTRAINT DF_PaymentPlanAccountFee_PaymentPlanAccountFeeID DEFAULT NEWSEQUENTIALID() FOR PaymentPlanAccountFeeID
	
GO

ALTER TABLE dbo.[PaymentPlanAccountFee]
	ADD CONSTRAINT FK_PaymentPlanAccountFee_PaymentPlanAccountID FOREIGN KEY (PaymentPlanAccountID) REFERENCES PaymentPlanAccount(PaymentPlanAccountID);
GO


/***************************************************************************************/
-- CREATE GRUOP ACCOUNT TYPES
/***************************************************************************************/

/* 
Holds the group account types
*/
CREATE TABLE dbo.[AccountType]
(
	AccountTypeID UNIQUEIDENTIFIER PRIMARY KEY,
	[Type] VARCHAR(300)
)
GO

ALTER TABLE dbo.[AccountType]
    ADD CONSTRAINT DF_AccountType_AccountTypeID DEFAULT NEWSEQUENTIALID() FOR AccountTypeID

GO

/***************************************************************************************/
-- CREATE GRUOP ACCOUNT TABLE
/***************************************************************************************/

/*
Holds the accountIDs and the account types
*/
CREATE TABLE dbo.[Account]
(
	AccountID UNIQUEIDENTIFIER PRIMARY KEY,
	AccountTypeID UNIQUEIDENTIFIER NOT NULL,
	PaymentPlanAccountID UNIQUEIDENTIFIER NOT NULL,
	Name VARCHAR(500)
)
GO
-- ADD PRIMARY KEY
ALTER TABLE dbo.[Account]
    ADD CONSTRAINT DF_Account_AccountID DEFAULT NEWSEQUENTIALID() FOR AccountID
GO

-- ADD FORIEGN KEY CONSTRAINT -> AccountTypeID
ALTER TABLE dbo.[Account]
	ADD CONSTRAINT FK_Account_AccountTypeID FOREIGN KEY (AccountTypeID) REFERENCES AccountType(AccountTypeID);
GO

-- ADD FORIEGN KEY CONSTRAINT -> AccountTypeID
ALTER TABLE dbo.[Account]
	ADD CONSTRAINT FK_Account_PaymentPlanAccountID FOREIGN KEY (PaymentPlanAccountID) REFERENCES PaymentPlanAccount(PaymentPlanAccountID);
GO

/***************************************************************************************/
-- CREATE Group Account Status Type ID
/***************************************************************************************/

/*
Holds the group account status types
*/
CREATE TABLE dbo.[AccountStatusType]
(
	AccountStatusTypeID UNIQUEIDENTIFIER PRIMARY KEY,
	[Type] VARCHAR(300)
)
GO
ALTER TABLE dbo.[AccountStatusType]
    ADD CONSTRAINT DF_AccountStatusType_AccountStatusTypeID DEFAULT NEWSEQUENTIALID() FOR AccountStatusTypeID

GO

USE [SDBO_App]
GO

INSERT INTO [dbo].[AccountStatusType] ([Type]) VALUES ('Active')
INSERT INTO [dbo].[AccountStatusType] ([Type]) VALUES ('Pending')
INSERT INTO [dbo].[AccountStatusType] ([Type]) VALUES ('Disabled')

GO

/***************************************************************************************/
-- CREATE Group Account MetaData
/***************************************************************************************/

/*
Holds all of the group accounts meta data
*/
CREATE TABLE dbo.[AccountMetaData]
( 
	AccountMetaDataID UNIQUEIDENTIFIER PRIMARY KEY,
	AccountID UNIQUEIDENTIFIER NOT NULL,
	AccountStatusTypeID UNIQUEIDENTIFIER NOT NULL,

	-- add in the metadata of the account
	CustomBranding VARCHAR(MAX)
)

-- ADD PRIMARY KEY
ALTER TABLE dbo.[AccountMetaData]
    ADD CONSTRAINT DF_AccountMetaDataID DEFAULT NEWSEQUENTIALID() FOR AccountMetaDataID
GO

-- ADD FORIEGN KEY CONSTRAINT
ALTER TABLE dbo.[AccountMetaData]
	ADD CONSTRAINT FK_AccountMetaData_AccountID FOREIGN KEY (AccountID) REFERENCES Account(AccountID);
GO

-- GROUP ACCOUNT STATUS TYPE
ALTER TABLE dbo.[AccountMetaData]
	ADD CONSTRAINT FK_AccountMetaData_AccountStatusTypeID FOREIGN KEY (AccountStatusTypeID) REFERENCES AccountStatusType(AccountStatusTypeID);
GO


/***************************************************************************************/
-- Create Group Account Payment Plan & Fees
/***************************************************************************************/

-- Create the payment plan
USE [SDBO_App]
GO

INSERT INTO [dbo].[PaymentPlanAccount] ([Name]) VALUES ('Beta Demo Plan')
GO

-- Insert Fees
USE [SDBO_App]
GO

DECLARE @PaymentPlanID UNIQUEIDENTIFIER = (SELECT TOP 1 PaymentPlanAccountID FROM PaymentPlanAccount WHERE Name = 'Beta Demo Plan')

INSERT INTO [dbo].[PaymentPlanAccountFee] ([PaymentPlanAccountID], [Section] ,[Amount]) VALUES (@PaymentPlanID ,'Signup.Fee' ,0.00)
INSERT INTO [dbo].[PaymentPlanAccountFee] ([PaymentPlanAccountID], [Section] ,[Amount]) VALUES (@PaymentPlanID ,'Monthly.Fee' ,0.00)

GO
/***************************************************************************************/
-- CREATE GRUOP ACCOUNT AND TYPES
/***************************************************************************************/


-- POPULATE Group Account Type

USE [SDBO_App]
GO

INSERT INTO [dbo].[AccountType] ([Type]) VALUES ('Everyone')
INSERT INTO [dbo].[AccountType] ([Type]) VALUES ('University')
INSERT INTO [dbo].[AccountType] ([Type]) VALUES ('Business')

GO

-- TODO:// INSERT GROUP ACCOUNT PAYMENT PLAN ID

-- POPULATE Group Account
USE [SDBO_App]
GO


DECLARE @PaymentPlanID UNIQUEIDENTIFIER = (SELECT TOP 1 PaymentPlanAccountID FROM PaymentPlanAccount WHERE Name = 'Beta Demo Plan')
-- GET THE UNIVERSITY TYPE
DECLARE @UniversityType UNIQUEIDENTIFIER = (SELECT TOP 1 AccountTypeID FROM [dbo].[AccountType] WHERE [Type] = 'University')
INSERT INTO [dbo].[Account] ([AccountTypeID],[PaymentPlanAccountID], [Name]) VALUES (@UniversityType, @PaymentPlanID, 'DePaul University')


GO

/***************************************************************************************/
-- CREATE Group Account Meta Data
/***************************************************************************************/
USE [SDBO_App]
GO

DECLARE @AccountID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountID FROM dbo.Account WHERE Name = 'DePaul University' )
DECLARE @AccountStatusTypeID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountStatusTypeID FROM dbo.AccountStatusType WHERE [Type] = 'Active' )

INSERT INTO [dbo].[AccountMetaData]
           ([AccountID]
           ,[AccountStatusTypeID]
		   ,[CustomBranding])
     VALUES
           (@AccountID
           ,@AccountStatusTypeID
		   -- depaul university image
		   ,'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'
		   )
GO


/***************************************************************************************/
-- 
/***************************************************************************************/
/*
Holds all of the group level configuration settings
*/
CREATE TABLE dbo.[AccountConfiguration]
(
	AccountConfigurationID UNIQUEIDENTIFIER PRIMARY KEY,
	Section VARCHAR(300) NOT NULL,
	Name VARCHAR(300) NOT NULL,
	Value VARCHAR(500) NOT NULL
)

GO
-- ADD PRIMARY KEY
ALTER TABLE dbo.[AccountConfiguration]
    ADD CONSTRAINT DF_AccountConfiguration_AccountConfigurationID DEFAULT NEWSEQUENTIALID() FOR AccountConfigurationID
GO

-- INERT SOME DEFAULT CONFIGURATIONS
USE [SDBO_App]
GO

INSERT INTO [dbo].[AccountConfiguration] ([Section] ,[Name] ,[Value]) VALUES ('Landing.Page', 'DisplayBranding', 'True')

GO





/***************************************************************************************/
-- Group Account Settings Type
/***************************************************************************************/
/* 
Holds the group account types
*/
CREATE TABLE dbo.[AccountSettingsType]
(
	AccountSettingsTypeID UNIQUEIDENTIFIER PRIMARY KEY,
	[Type] VARCHAR(300)
)
GO

ALTER TABLE dbo.[AccountSettingsType]
    ADD CONSTRAINT DF_AccountSettingsType_AccountSettingsTypeID DEFAULT NEWSEQUENTIALID() FOR AccountSettingsTypeID

GO

-- POPULATE
USE [SDBO_App]
GO

INSERT INTO [dbo].[AccountSettingsType] ([Type]) VALUES ('CheckBox')
INSERT INTO [dbo].[AccountSettingsType] ([Type]) VALUES ('Email')
INSERT INTO [dbo].[AccountSettingsType] ([Type]) VALUES ('Text')
INSERT INTO [dbo].[AccountSettingsType] ([Type]) VALUES ('TextArea')
INSERT INTO [dbo].[AccountSettingsType] ([Type]) VALUES ('Password')

GO



/***************************************************************************************/
-- Group Account Settings, global... if not set then default to the default value
/***************************************************************************************/
/*
Holds all of the group level account settings, based off of sections
*/
CREATE TABLE dbo.[AccountSettings]
(
	AccountSettingsID UNIQUEIDENTIFIER PRIMARY KEY,
	AccountSettingsTypeID UNIQUEIDENTIFIER NOT NULL,
	Section VARCHAR(300) NOT NULL,
	Name VARCHAR(300) NOT NULL,
	DefaultValue VARCHAR(500) NOT NULL
)

GO

-- ADD PRIMARY KEY
ALTER TABLE dbo.[AccountSettings]
    ADD CONSTRAINT DF_AccountSettings_AccountSettingsID DEFAULT NEWSEQUENTIALID() FOR AccountSettingsID
GO

-- ADD FORIEGN KEY CONSTRAINT
ALTER TABLE dbo.[AccountSettings]
	ADD CONSTRAINT FK_AccountSettings_AccountSettingsTypeID FOREIGN KEY (AccountSettingsTypeID) REFERENCES AccountSettingsType(AccountSettingsTypeID);
GO



USE [SDBO_App]
GO


-- POPULATE

DECLARE @AccountSettingsTypeID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountSettingsTypeID FROM AccountSettingsType WHERE [Type] = 'CheckBox')

INSERT INTO [dbo].[AccountSettings]
           ([AccountSettingsTypeID], [Section], [Name], [DefaultValue])
     VALUES
           (@AccountSettingsTypeID
           ,'Account.Settings'
           ,'Enable Notifications'
           ,'True')
GO

DECLARE @AccountSettingsTypeID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountSettingsTypeID FROM AccountSettingsType WHERE [Type] = 'CheckBox')
INSERT INTO [dbo].[AccountSettings]
           ([AccountSettingsTypeID], [Section], [Name], [DefaultValue])
     VALUES
           (@AccountSettingsTypeID
           ,'Account.Settings.Notifications'
           ,'Notify recipients upon account creation'
           ,'True')
GO

--- 



/***************************************************************************************/
-- Group Account Group Account Settings Link
/***************************************************************************************/

/*
Holds all of the group level account settings, based off of sections
*/
CREATE TABLE dbo.[AccountAccountSettingsLink]
(
	AccountAccountSettingsLinkID UNIQUEIDENTIFIER PRIMARY KEY,
	AccountID UNIQUEIDENTIFIER NOT NULL,
	AccountSettingsID UNIQUEIDENTIFIER NOT NULL,
	AccountSettingsTypeID UNIQUEIDENTIFIER NOT NULL,
	Value VARCHAR(500)
)

GO

-- ADD PRIMARY KEY
ALTER TABLE dbo.[AccountAccountSettingsLink]
    ADD CONSTRAINT DF_AccountAccountSettingsLink_AccountAccountSettingsLinkID DEFAULT NEWSEQUENTIALID() FOR AccountAccountSettingsLinkID
GO

-- ADD FORIEGN KEY CONSTRAINT
ALTER TABLE dbo.[AccountAccountSettingsLink]
	ADD CONSTRAINT FK_AccountAccountSettingsLink_AccountID FOREIGN KEY (AccountID) REFERENCES Account(AccountID);
GO

ALTER TABLE dbo.[AccountAccountSettingsLink]
	ADD CONSTRAINT FK_AccountAccountSettingsLink_AccountSettingsID FOREIGN KEY (AccountSettingsID) REFERENCES AccountSettings(AccountSettingsID);
GO

ALTER TABLE dbo.[AccountAccountSettingsLink]
	ADD CONSTRAINT FK_AccountAccountSettingsLink_AccountSettingsTypeID FOREIGN KEY (AccountSettingsTypeID) REFERENCES AccountSettingsType(AccountSettingsTypeID);
GO

---Populate
USE [SDBO_App]
GO

DECLARE @AccountID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountID FROM Account WHERE Name = 'DePaul University')
DECLARE @AccountSettingsID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountSettingsID FROM AccountSettings WHERE Section = 'Account.Settings' AND Name = 'Enable Notifications')
DECLARE @AccountSettingsTypeID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountSettingsTypeID FROM AccountSettings WHERE Section = 'Account.Settings' AND Name = 'Enable Notifications')


INSERT INTO [dbo].[AccountAccountSettingsLink]
           ([AccountID]
           ,[AccountSettingsID]
           ,[AccountSettingsTypeID]
           ,[Value])
     VALUES
           (@AccountID
           ,@AccountSettingsID
           ,@AccountSettingsTypeID
           ,'True')
GO


USE [SDBO_App]
GO

DECLARE @AccountID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountID FROM Account WHERE Name = 'DePaul University')
DECLARE @AccountSettingsID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountSettingsID FROM AccountSettings WHERE Section = 'Account.Settings.Notifications' AND Name = 'Notify recipients upon account creation')
DECLARE @AccountSettingsTypeID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountSettingsTypeID FROM AccountSettings WHERE Section = 'Account.Settings.Notifications' AND Name = 'Notify recipients upon account creation')


INSERT INTO [dbo].[AccountAccountSettingsLink]
           ([AccountID]
           ,[AccountSettingsID]
           ,[AccountSettingsTypeID]
           ,[Value])
     VALUES
           (@AccountID
           ,@AccountSettingsID
           ,@AccountSettingsTypeID
           ,'True')
GO

/***************************************************************************************/






/***************************************************************************************/
-- Group Account Roles
/***************************************************************************************/
/*
Holds all of the group level account settings, based off of sections
*/
CREATE TABLE dbo.[AccountRole]
(
	AccountRoleID UNIQUEIDENTIFIER PRIMARY KEY,
	[Role] VARCHAR(500)
)

GO

-- ADD PRIMARY KEY
ALTER TABLE dbo.[AccountRole]
    ADD CONSTRAINT DF_AccountRole_AccountRoleID DEFAULT NEWSEQUENTIALID() FOR AccountRoleID
GO

-- Populate
USE [SDBO_App]
GO

INSERT INTO [dbo].[AccountRole] ([Role]) VALUES ('Administrator')
INSERT INTO [dbo].[AccountRole] ([Role]) VALUES ('User')
GO



/***************************************************************************************/








SELECT * FROM dbo.Account;
SELECT * FROM dbo.AccountMetaData;
SELECT * FROM dbo.AccountStatusType;
SELECT * FROM dbo.AccountType;
SELECT * FROM dbo.PaymentPlanAccount;
SELECT * FROM dbo.PaymentPlanAccountFee;

SELECT * FROM dbo.Account ga
LEFT JOIN dbo.AccountMetaData gamd ON ga.AccountID = gamd.AccountID

-- Get the group name and the payment plan name
SELECT ga.Name, ppga.Name FROM dbo.Account ga
LEFT JOIN PaymentPlanAccount ppga ON ga.[PaymentPlanAccountID] = ppga.PaymentPlanAccountID

-- Get the group name and the payment plan name and payment options associated with this plan
SELECT 
	ga.Name,
	ppga.Name, 
	ppgaf.Section,
	ppgaf.Amount 
	FROM dbo.Account ga
LEFT JOIN PaymentPlanAccount ppga ON ga.[PaymentPlanAccountID] = ppga.PaymentPlanAccountID
LEFT JOIN PaymentPlanAccountFee ppgaf ON ppga.PaymentPlanAccountID = ppgaf.PaymentPlanAccountID


-- Get Types of account, and payment plans

SELECT 
	ga.Name,
	gat.[Type] as 'Account Type',
	ppga.Name, 
	ppgaf.Section,
	ppgaf.Amount 
	FROM dbo.Account ga
LEFT JOIN [dbo].[AccountType] gat ON ga.AccountTypeID = gat.AccountTypeID
LEFT JOIN PaymentPlanAccount ppga ON ga.[PaymentPlanAccountID] = ppga.PaymentPlanAccountID
LEFT JOIN PaymentPlanAccountFee ppgaf ON ppga.PaymentPlanAccountID = ppgaf.PaymentPlanAccountID

-- Get Types of account, and payment plans, and status

SELECT 
	ga.Name,
	gat.[Type] as 'Account Type',
	ppga.Name, 
	ppgaf.Section,
	ppgaf.Amount 
	FROM dbo.Account ga
LEFT JOIN [dbo].[AccountType] gat ON ga.AccountTypeID = gat.AccountTypeID
LEFT JOIN PaymentPlanAccount ppga ON ga.[PaymentPlanAccountID] = ppga.PaymentPlanAccountID
LEFT JOIN PaymentPlanAccountFee ppgaf ON ppga.PaymentPlanAccountID = ppgaf.PaymentPlanAccountID



-- GET Monthly Fee
SELECT 
	ga.Name,
	ppga.Name, 
	ppgaf.Section,
	ppgaf.Amount 
	FROM dbo.Account ga
LEFT JOIN PaymentPlanAccount ppga ON ga.[PaymentPlanAccountID] = ppga.PaymentPlanAccountID
LEFT JOIN PaymentPlanAccountFee ppgaf ON ppga.PaymentPlanAccountID = ppgaf.PaymentPlanAccountID
WHERE ppgaf.Section = 'Monthly.Fee'

-- GET signup fee
SELECT 
	ga.Name,
	ppga.Name, 
	ppgaf.Section,
	ppgaf.Amount 
	FROM dbo.Account ga
LEFT JOIN PaymentPlanAccount ppga ON ga.[PaymentPlanAccountID] = ppga.PaymentPlanAccountID
LEFT JOIN PaymentPlanAccountFee ppgaf ON ppga.PaymentPlanAccountID = ppgaf.PaymentPlanAccountID
WHERE ppgaf.Section = 'Signup.Fee'


-- get custom branding
SELECT ga.Name, gamd.CustomBranding FROM Account ga
LEFT JOIN AccountMetaData gamd ON ga.AccountID = gamd.AccountID



/***************************************************************************/
-- settings queries
/***************************************************************************/


SELECT * FROM AccountSettings;

-- Get group account settings and type, with default value
SELECT gas.Name, gast.[Type], gas.DefaultValue FROM AccountSettings gas
LEFT JOIN AccountSettingsType gast ON gas.AccountSettingsTypeID = gast.AccountSettingsTypeID

-- Get account settings for the current group account
-- This Query gets all of the account settings for the current account id
SELECT gas.Name, 
	   gast.[Type], 
	   ISNULL(gagasl.Value, gas.DefaultValue) AS 'Value'
	   FROM AccountSettings gas
LEFT JOIN AccountSettingsType gast ON gas.AccountSettingsTypeID = gast.AccountSettingsTypeID
LEFT JOIN AccountAccountSettingsLink gagasl ON gas.AccountSettingsID = gagasl.AccountSettingsID
WHERE gagasl.AccountID = (SELECT TOP 1 AccountID FROM Account WHERE Name = 'DePaul University')







