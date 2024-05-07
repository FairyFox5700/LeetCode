/* Write your T-SQL query statement below */
SELECT DISTINCT(c.seat_id)
FROM Cinema c
JOIN Cinema t
ON ABS(c.seat_id - t.seat_id) = 1  
AND c.free = 1 AND t.free = 1

