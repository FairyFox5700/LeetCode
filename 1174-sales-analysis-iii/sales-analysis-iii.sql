SELECT
    p.product_id,
    p.product_name
FROM Sales s
INNER JOIN Product p ON s.product_id = p.product_id
GROUP BY
    p.product_id,
    p.product_name
HAVING
    SUM(CASE WHEN sale_date BETWEEN '2019-01-01' AND '2019-03-31' THEN 0 ELSE 1 END) = 0