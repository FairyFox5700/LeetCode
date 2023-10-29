/* Write your T-SQL query statement below */
(SELECT employee_id
from Employees 
EXCEPT 
SELECT employee_id
from Salaries)
UNION
(SELECT employee_id
from Salaries
EXCEPT 
SELECT employee_id
from  Employees  )