IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Expressions]')) 
   ALTER TABLE [dbo].[Expressions] 
   ENABLE  CHANGE_TRACKING
GO
