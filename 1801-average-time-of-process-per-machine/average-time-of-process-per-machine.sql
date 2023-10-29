/* Write your T-SQL query statement below 
SELECT machine_id, processing_time 
FROM Activity
GROUP BY machine_id*/

SELECT  machine_id, ROUND(SUM ( 
  CASE
  WHEN activity_type = 'start' THEN -1*timestamp
  ELSE timestamp
  END
) / COUNT(DISTINCT process_id), 3) as processing_time 
FROM Activity
GROUP BY machine_id