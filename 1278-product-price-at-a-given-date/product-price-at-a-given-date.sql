/* Write your T-SQL query statement below



 */
-- items who has not changes the pice

-- items that had a change
SELECT  product_id , 10 as price
FROM Products
GROUP BY   product_id
HAVING MIN(change_date) > '2019-08-16'
UNION 
SELECT P.product_id, P.new_price AS price 
FROM Products P
JOIN (
    SELECT product_id, MAX(change_date) as max_change_date
    FROM Products
    WHERE change_date <= '2019-08-16'
    GROUP BY product_id
) AS Subquery ON P.product_id = Subquery.product_id AND P.change_date = Subquery.max_change_date
