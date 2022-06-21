SELECT e.Name  Employee FROM Employee e
JOIN Employee m
ON m.id = e.managerId
AND e.salary > m.salary