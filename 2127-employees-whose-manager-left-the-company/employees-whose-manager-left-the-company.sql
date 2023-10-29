/* Write your T-SQL query statement below */
SElect Employee_id 
from Employees 
where salary < 30000  and manager_id is NOT null  AND manager_id NOT IN (SELEct employee_id from  Employees )
ORDER BY Employee_id 