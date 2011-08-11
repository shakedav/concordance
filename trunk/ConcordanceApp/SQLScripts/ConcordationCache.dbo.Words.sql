IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Words]')) 
   ALTER TABLE [dbo].[Words] 
   ENABLE  CHANGE_TRACKING
GO
