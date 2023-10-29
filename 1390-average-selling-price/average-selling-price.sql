/* Write your T-SQL query statement below */
SELECT p.product_id, COALESCE(ROUND(SUM (us.units * price ) *1.00 / (SUM (us.units)), 2), 0)  average_price 
FROM Prices p
LEFT JOIN UnitsSold us
ON us.product_id = p.product_id
AND us.purchase_date BETWEEN p.start_date and p.end_date 
GROUP BY p.product_id