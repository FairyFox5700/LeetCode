/* Write your T-SQL query statement below 
SELECT  machine_id, ROUND(SUM ( 
  CASE
  WHEN activity_type = 'start' THEN -1*timestamp
  ELSE timestamp
  END
) / COUNT(DISTINCT process_id), 3) as processing_time 
FROM Activity
GROUP BY machine_id*/

SELECT a.machine_id, ROUND(AVG(b.timestamp - a.timestamp), 3) as  processing_time
FROM Activity a
JOIN Activity b
ON a.machine_id = b.machine_id
AND a.process_id = b.process_id
AND a.activity_type =  'start'
AND b.activity_type =  'end'
GROUP BY a.machine_id