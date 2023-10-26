/* Write your T-SQL query statement below */

with a as (SELECT DISTINCT * FROM  Activities)

SELECT 
a.sell_date ,COUNT(a.product) num_sold,
STRING_AGG(a.product, ',') WITHIN GROUP (ORDER BY a.product) as products
from a
group by sell_date
order by sell_date
