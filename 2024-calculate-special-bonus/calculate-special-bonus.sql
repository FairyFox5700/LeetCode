/* Write your T-SQL query statement below */
SELECT employee_id, (CASE
WHEN SUBSTRING(name, 0, 2) != 'M' AND employee_id%2 !=0 THEN salary
ELSE 0
END) as
 bonus
FROM Employees
ORDER BY employee_id
