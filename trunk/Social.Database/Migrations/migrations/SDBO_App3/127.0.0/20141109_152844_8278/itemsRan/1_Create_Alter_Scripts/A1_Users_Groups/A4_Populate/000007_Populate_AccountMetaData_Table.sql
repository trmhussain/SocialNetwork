﻿/*************************************************************
** File:    000007_Populate_AccountMetaData_Table.sql
** Name:	
** Desc:	
**
**
**
**
**
** Auth:	Justin Jarczyk
** Date:	8/29/2014
**************************
** Change History
**************************
** PR		Date			Author				Description	
** --		--------		-------				------------------------------------
** 1		8/29/2014		Justin Jarczyk		Created Script
**
**
**************************************************************/
USE {{DatabaseName}}
GO

DECLARE @AccountID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountID FROM dbo.Account WHERE Email = 'administration@relsocial.com' )
DECLARE @AccountStatusTypeID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountStatusTypeID FROM dbo.AccountStatusType WHERE [Type] = 'Active' )

INSERT INTO [dbo].[AccountMetaData]
           ([AccountID]
           ,[AccountStatusTypeID]
		   ,[ProfileImage])
     VALUES
           (@AccountID
           ,@AccountStatusTypeID
		   --profile image
		   ,'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'
		   )
GO

DECLARE @AccountID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountID FROM dbo.Account WHERE Email = 'service@relsocial.com' )
DECLARE @AccountStatusTypeID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountStatusTypeID FROM dbo.AccountStatusType WHERE [Type] = 'Active' )

INSERT INTO [dbo].[AccountMetaData]
           ([AccountID]
           ,[AccountStatusTypeID]
		   ,[ProfileImage])
     VALUES
           (@AccountID
           ,@AccountStatusTypeID
		   --profile image
		   ,'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'
		   )
GO

DECLARE @AccountID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountID FROM dbo.Account WHERE Email = 'master@relsocial.com' )
DECLARE @AccountStatusTypeID UNIQUEIDENTIFIER = (SELECT TOP 1 AccountStatusTypeID FROM dbo.AccountStatusType WHERE [Type] = 'Active' )

INSERT INTO [dbo].[AccountMetaData]
           ([AccountID]
           ,[AccountStatusTypeID]
		   ,[ProfileImage])
     VALUES
           (@AccountID
           ,@AccountStatusTypeID
		   --profile image
		   ,'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'
		   )
GO