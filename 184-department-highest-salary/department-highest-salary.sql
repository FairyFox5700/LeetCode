/* Write your T-SQL query statement below 
SELECT d.name as Department, e.name as Employee , e.salary as Salary
FROM Department d
JOIN Employee e
ON e.departmentId  = d.id
*/

WITH CTE AS (
SELECT id, name,  departmentId ,salary, rank() OVER(PARTITION BY departmentid ORDER BY salary DESC) r
FROM Employee
)
SELECT d.name as Department, c.name as  Employee, c.salary  as Salary 
FROM Department d
JOIN CTE c
On c.departmentId = d.id
WHERE c.r = 1