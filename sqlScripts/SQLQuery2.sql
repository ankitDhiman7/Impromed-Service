-- Enable change data capture at the database level
EXEC sys.sp_cdc_enable_db;

-- Enable change data capture for the specified table
EXEC sys.sp_cdc_enable_table   
    @source_schema = N'dbo',  
    @source_name   = N'APPT_M',  
    @role_name     = NULL;  

-- Get information about change data capture for the specified table
EXEC sys.sp_cdc_help_change_data_capture
    @source_schema ='dbo',
    @source_name = 'APPT_M'
go
