CREATE TYPE [dbo].[MyTableType] AS TABLE(
    [Id] int NOT NULL,
    [Name] [nvarchar](128) NULL
)


CREATE PROCEDURE [dbo].[InsertTable]
    @myTableType MyTableType readonly
AS
BEGIN
    insert into [dbo].Records select * from @myTableType 
END

https://stackoverflow.com/questions/9075159/how-to-insert-a-data-table-into-sql-server-database-table