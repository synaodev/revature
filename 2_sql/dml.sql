USE pizzaboxdb;
GO

--SELECT
SELECT NAME 
FROM Crusts 
WHERE Price > 0 
GROUP BY NAME, Price 
HAVING Price > 1.50
ORDER BY NAME DESC;

--Order of Execution
-- FROM 
-- 