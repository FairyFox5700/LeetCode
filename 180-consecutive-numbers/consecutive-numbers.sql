/* Write your T-SQL query statement below */

WITH CTE AS (
  SELECT num,
  LEAD (num, 1) OVER ( ORDER BY id) as one_numbers_ahead,
  LEAD (num, 2) OVER ( ORDER BY id) as two_numbers_ahead
  FROM Logs
)

SELECT DISTINCT num as ConsecutiveNums 
FROM CTE
WHERE num = one_numbers_ahead AND one_numbers_ahead = two_numbers_ahead
