/* Write your T-SQL query statement below */
SELECT m.employee_id, m.name, COUNT(e.employee_id ) as reports_count,  round(AVG(e.age*1.00), 0) as average_age
FROM Employees e
JOIN Employees m
ON e.reports_to = m.employee_id
GROUP BY m.employee_id, m.name
ORDER BY m.employee_id
