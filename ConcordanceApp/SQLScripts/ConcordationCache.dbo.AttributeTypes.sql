IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[AttributeTypes]')) 
   ALTER TABLE [dbo].[AttributeTypes] 
   ENABLE  CHANGE_TRACKING
GO
