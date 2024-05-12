DROP VIEW [ASR];

DECLARE @sql NVARCHAR(MAX);
DECLARE @courseID VARCHAR(10);

-- Cursor to iterate over distinct course names
DECLARE CIDCursor CURSOR FOR
SELECT CID FROM CourseTable;
DECLARE @courseName NVARCHAR(50);

-- Variable to store the dynamic SQL
SET @sql = 'CREATE VIEW ASR AS
SELECT
	STUDS.StuId as [StudentID],
	LName as Lastname,
	FName as Firstname,
	';

-- Counter to keep track of the loop
DECLARE @counter INT = 0;

OPEN CIDCursor;
FETCH NEXT FROM CIDCursor INTO @courseID;

WHILE @@FETCH_STATUS = 0
BEGIN
	SET @courseName = (SELECT CName FROM CourseTable WHERE CID = @courseID);
    SET @counter = @counter + 1;
    SET @sql = @sql + 'AVG(CASE WHEN CID = ''' + @courseID + ''' THEN Grade END) AS [' + @courseID + '],
	';
    FETCH NEXT FROM CIDCursor INTO @courseID;
END;

CLOSE CIDCursor;
DEALLOCATE CIDCursor;

SET @sql = @sql + 'AVG(Grade) as [Average],
CASE
	WHEN AVG(Grade) >= 9 THEN ''Excellent''
	WHEN AVG(Grade) >= 8 THEN ''Very Good''
	WHEN AVG(Grade) >= 7 THEN ''Good''
	WHEN AVG(Grade) >= 5 THEN ''Average''
	WHEN AVG(Grade) >= 0 THEN ''Fail''
END AS Result
';

-- Remove the trailing comma and space from the SQL statement
--SET @sql = LEFT(@sql, LEN(@sql) - 1);

-- Add the FROM clause
SET @sql = @sql + 'FROM (SELECT StuID, LName, FName FROM QLSVDB) AS STUDS LEFT JOIN Grade ON STUDS.StuId = Grade.StuID
GROUP BY STUDS.StuId, LName, FName';

-- Execute the dynamic SQL to create the view
EXEC sp_executesql @sql;

select * from ASR