IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Expressions]')) 
   ALTER TABLE [dbo].[Expressions] 
   DISABLE  CHANGE_TRACKING
GO
