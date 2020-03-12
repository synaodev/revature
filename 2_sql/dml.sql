USE AdventureWorks2017;
GO

-- SELECT SUM(t.counting)
-- FROM (
-- 	SELECT count(lastname) AS [counting]
-- 	FROM Person.Person
-- 	GROUP BY lastname
-- 	HAVING count(*) > 1
-- ) AS t;

-- SELECT FirstName, LastName, MiddleName
-- FROM Person.Person
-- WHERE LastName = 'adams' AND MiddleName LIKE '[a-z]_%'; 
-- wildcard %
-- exactly _
-- within []

------- subquery
-- SELECT PP.FirstName, PP.LastName, PA.AddressLine1, PA.City
-- FROM Person.Address as PA
-- INNER JOIN Person.BusinessEntityAddress AS PBEA ON PBEA.AddressID = PA.AddressID
-- LEFT JOIN (
-- 	SELECT BusinessEntityID, FirstName, LastName
-- 	FROM Person.Person
-- 	WHERE LastName = 'adams'
-- ) AS PP ON PP.BusinessEntityID = PBEA.BusinessEntityID;

WITH Persons AS (
	SELECT BusinessEntityID, FirstName, LastName
	FROM Person.Person
	WHERE LastName = 'adams'
)

SELECT Persons.FirstName, Persons.LastName, PA.AddressLine1, PA.City
FROM Person.Address AS PA
INNER JOIN Person.BusinessEntityAddress AS PBEA ON PBEA.AddressID = PA.AddressID
LEFT JOIN Persons ON Persons.BusinessEntityID = PBEA.BusinessEntityID;