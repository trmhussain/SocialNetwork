﻿/*************************************************************
** File:    000025_Update_UpdatedDate_CommitmentGroupStatusType.sql
** Name:	[dbo].[AccountGroupAccountLink_Update_UpdatedDate]
** Desc:	Database Trigger, Updates the UpdatedDate Column On Update
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

/****** Object:  Trigger [dbo].[CommitmentNoteType_Update_UpdatedDate]    Script Date: 10/1/2014 9:39:19 PM ******/

CREATE TRIGGER [dbo].[CommitmentNoteType_Update_UpdatedDate]
ON [dbo].[CommitmentNoteType]
FOR UPDATE 
AS 
BEGIN 
    IF NOT UPDATE(UpdatedDate) 
        UPDATE dbo.CommitmentNoteType SET UpdatedDate=GETUTCDATE() 
        WHERE CommitmentNoteTypeID IN (SELECT CommitmentNoteTypeID FROM INSERTED) 
END 


GO
