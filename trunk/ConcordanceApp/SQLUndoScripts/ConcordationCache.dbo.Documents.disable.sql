IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Documents]')) 
   ALTER TABLE [dbo].[Documents] 
   DISABLE  CHANGE_TRACKING
GO
