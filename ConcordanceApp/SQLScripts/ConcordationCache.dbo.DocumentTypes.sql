IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[DocumentTypes]')) 
   ALTER TABLE [dbo].[DocumentTypes] 
   ENABLE  CHANGE_TRACKING
GO
