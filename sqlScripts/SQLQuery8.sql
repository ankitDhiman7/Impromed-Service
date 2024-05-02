DECLARE @tableName NVARCHAR(MAX)
DECLARE @enableCDCQuery NVARCHAR(MAX)

DECLARE tableCursor CURSOR FOR
SELECT name
FROM sys.tables
WHERE is_ms_shipped = 0 -- Exclude system tables

OPEN tableCursor
FETCH NEXT FROM tableCursor INTO @tableName

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Generate the query to enable CDC for the current table
    SET @enableCDCQuery = 'EXEC sys.sp_cdc_enable_table ' +
                            '@source_schema = N''dbo'', ' +
                            '@source_name = N''' + @tableName + ''', ' +
                            '@role_name = NULL;'

    -- Execute the query to enable CDC for the current table
    EXEC sp_executesql @enableCDCQuery

    FETCH NEXT FROM tableCursor INTO @tableName
END

CLOSE tableCursor
DEALLOCATE tableCursor

EXEC sys.sp_cdc_help_change_data_capture
    @source_schema ='dbo',
    @source_name = 'APPT_M'
go

select * from cdc.change_tables




DECLARE @tableName NVARCHAR(MAX)
DECLARE @disableCDCQuery NVARCHAR(MAX)

DECLARE tableCursor CURSOR FOR
SELECT name
FROM sys.tables
WHERE is_ms_shipped = 0 -- Exclude system tables
AND name <> 'APPT_M' -- Exclude the APPT_M table

OPEN tableCursor
FETCH NEXT FROM tableCursor INTO @tableName

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Generate the query to disable CDC for the current table
    SET @disableCDCQuery = 'EXEC sys.sp_cdc_disable_table ' +
                            '@source_schema = N''dbo'', ' +
                            '@source_name = N''' + @tableName + ''', ' +
                            '@capture_instance = NULL' 
    
    -- Specify NULL for optional parameter

    -- Execute the query to disable CDC for the current table
    EXEC sp_executesql @disableCDCQuery

    FETCH NEXT FROM tableCursor INTO @tableName
END

CLOSE tableCursor
DEALLOCATE tableCursor

