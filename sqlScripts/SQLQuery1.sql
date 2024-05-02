 -- If we perform CRUD operations, CDC will capture the changes and insert them into the change table

-- Select data from the change data capture (CDC) change table for the 'dbo_APPT_M' table
select * from cdc.dbo_APPT_M_CT

-- Add a new column 'flag' to the change data capture (CDC) change table 'dbo_APPT_M_CT'
alter table cdc.dbo_APPT_M_CT add flag bit 

-- Select data from the change_tables system table to view configured change tables in the CDC system
select * from cdc.change_tables

-- Select data from the original table 'APPT_STATUS'
select * from APPT_STATUS

-- Alter 'APPT_STATUS' table and add a new column 'IsChangesDicated'
alter table APPT_STATUS add IsChangesDicated bit null

-- Delete a record from the 'APPT_STATUS' table using its unique identifier
delete from APPT_STATUS where STATUS_GUID = 'E5157EB4-9D29-41B8-A76E-A321C128831B'

-- Select database name and whether CDC is enabled for each database
Select name, is_cdc_enabled from sys.databases