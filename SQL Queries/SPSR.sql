-- Student personal score result
CREATE VIEW [SPSR] AS
SELECT
	ShortSV.StuId as [SID],
	Lname,
	Fname,
	ShortCou.CID,
	CName,
	Sem,
	Grade,
	CASE
		WHEN AVG(Grade) >= 9 THEN 'Excellent'
		WHEN AVG(Grade) >= 8 THEN 'Very Good'
		WHEN AVG(Grade) >= 7 THEN 'Good'
		WHEN AVG(Grade) >= 5 THEN 'Average'
		WHEN AVG(Grade) >= 0 THEN 'Fail'
	END as Result
FROM (
		(SELECT StuID, LName, FName FROM QLSVDB) AS ShortSV
		JOIN (SELECT StuID, CID, Sem, Grade FROM Grade) AS ShortGra 
		ON ShortSV.StuId = ShortGra.StuID
	) JOIN (SELECT CID, CName FROM CourseTable) AS ShortCou
	ON ShortGra.CID = ShortCou.CID
GROUP BY ShortSV.StuId, Lname, Fname, ShortCou.CID, CName, Sem, Grade