/* Write your T-SQL query statement below */

DECLARE @count INT = (SELECT COUNT( product_key) FROM Product) ;
SELECT customer_id 
FROM Customer
GROUP BY customer_id
HAVING COUNT (DISTINCT product_key)  = @count;