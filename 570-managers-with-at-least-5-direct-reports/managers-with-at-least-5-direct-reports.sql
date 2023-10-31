/* Write your T-SQL query statement below */
WITH CTE as (SELECT e.managerId as managerId, COUNT (e.managerId) cnt
FROM Employee e
GROUP BY e.managerId
HAVING COUNT (e.managerId) >=5)
SELECT e.name 
FROM Employee e
JOIN CTE  c
ON c.managerId = e.id