﻿/*************************************************************
** File:    000026_Create_CommitmentGroup.sql
** Name:	[dbo].[CommitmentGroup]
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

/****** Object:  Table [dbo].[RCAccountBalance]    Script Date: 10/4/2014 12:38:40 PM ******/

CREATE TABLE [dbo].[RCAccountBalance](
	[RCAccountBalanceID] [uniqueidentifier] NOT NULL,
	[AccountID] [uniqueidentifier] NOT NULL,
	[Amount] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RCAccountBalanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
