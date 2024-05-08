/* Write your T-SQL query statement below */
SELECT  
    FORMAT(t.trans_date, 'yyyy-MM') AS month,
    country,
    COUNT(t.id) AS trans_count,
    SUM(CASE WHEN state = 'approved' THEN 1 ELSE 0 END) AS approved_count, 
    SUM(amount) AS trans_total_amount,
    SUM(CASE WHEN state = 'approved' THEN amount ELSE 0 END) AS approved_total_amount
FROM 
    Transactions t
GROUP BY 
    FORMAT(t.trans_date, 'yyyy-MM'),
    country;
