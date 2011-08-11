IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Relations]')) 
   ALTER TABLE [dbo].[Relations] 
   DISABLE  CHANGE_TRACKING
GO
