/* Write your T-SQL query statement below */
SELECT name, COALESCE(SUM(distance), 0) as  travelled_distance
FROM Users u 
LEFT JOIN Rides r ON
u.id = r.user_id  
GROUP BY user_id, name
ORDER BY  travelled_distance DESC, name


