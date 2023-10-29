/* Write your T-SQL query statement below */
SELECT user_id, name, mail
FROM Users
WHERE mail LIKE '[a-zA-Z]%@leetcode.com' AND SUBSTRING(mail, 0, LEN(mail) - LEN('@leetcode.com')) NOT LIKE '%[^0-9a-zA-Z_.-]%'
