SELECT e.Name AS name, b.bonus AS bonus
FROM Employee e
LEFT JOIN Bonus b ON e.empId = b.empId
WHERE b.bonus < 1000 or b.bonus is null;
