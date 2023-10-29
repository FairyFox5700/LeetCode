/* Write your T-SQL query statement below */
SELECT user_id , 
UPPER(SUBSTRING(name, 0, 2) )+ LOWER(SUBSTRING(name, 2, LEN(name)))  name
FROM Users
ORDER BY user_id