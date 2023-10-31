/* Write your T-SQL query statement below */
SELECT   u.user_id as buyer_id , MIN(u.join_date) as join_date ,SUM( CASE WHEN DATEPART (year, order_date) = '2019' THEN 1
ELSE 0
END)  as  orders_in_2019
FROM Orders o
RIGHT JOIN Users u
on u.user_id = o.buyer_id
GROUP BY   u.user_id
ORDER BY 
  u.user_id