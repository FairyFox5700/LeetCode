/* Write your T-SQL query statement below */
DECLARE @user_count INT;
SELECT @user_count = COUNT(1) FROM Users;

SELECT r.contest_id, ROUND(COUNT(r.user_id) * 100.00 / NULLIF(@user_count, 0), 2) AS percentage
FROM Register r
GROUP BY r.contest_id
ORDER BY percentage DESC, r.contest_id ASC;
