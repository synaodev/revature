USE AdventureWorks2017;
GO

-- SELECT * 
-- FROM Person.Person
-- WHERE FirstName = 'John' OR LastName = 'John';

-- SELECT LastName 
-- FROM Person.Person
-- WHERE LastName = 'Johnson'
-- GROUP BY LastName;

SELECT SUM(Counting)
FROM (
	SELECT COUNT(LastName) AS [Counting]
	FROM Person.Person
	GROUP BY LastName
	HAVING COUNT(*) > 1
);