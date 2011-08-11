IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[AttributeTypes]')) 
   ALTER TABLE [dbo].[AttributeTypes] 
   DISABLE  CHANGE_TRACKING
GO
