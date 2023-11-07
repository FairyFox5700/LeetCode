
WITH base as (select requester_id  as id
FROM RequestAccepted 
UNION ALL
SELECT accepter_id  as id
FROM RequestAccepted) 
SELECT TOP 1 id, COUNT (*) as num
FROM base
GROUP BY  id
ORDER BY  COUNT (*) DESC
