SELECT c.name as Customers FROM Customers c
LEFT JOIN Orders o
on c.Id = o.customerId
WHERE o.Id IS NULL
