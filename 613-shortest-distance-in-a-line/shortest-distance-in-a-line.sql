/* Write your T-SQL query statement below */

SELECT MIN(ABS(p.x -  k.x)) as shortest 
FROM Point p
CROSS JOIN Point k
WHERE p.x <> k.x



