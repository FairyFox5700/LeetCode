/* Write your T-SQL query statement below */
SELECT  DISTINCT(v.customer_id), COUNT(v.customer_id) as count_no_trans
FROM Transactions t
right join Visits v
on v.visit_id  = t.visit_id
where t.visit_id is null
GROUP BY v.customer_id