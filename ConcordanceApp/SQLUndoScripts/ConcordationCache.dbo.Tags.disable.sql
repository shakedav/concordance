IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Tags]')) 
   ALTER TABLE [dbo].[Tags] 
   DISABLE  CHANGE_TRACKING
GO
