USE [WIPR_170124]
-- Create a new table called ... in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.AccInfo', 'U') IS NOT NULL
DROP TABLE dbo.AccInfo
GO
-- Create the table in the specified schema
CREATE TABLE dbo.AccInfo
(
   Username     [NVARCHAR](50)  NOT NULL   PRIMARY KEY, -- primary key column
   Password		[NVARCHAR](50)  NOT NULL,
);
GO