/* Write your T-SQL query statement below */
select  activity_date as day, count(DISTINCT user_id )as active_users
from Activity
group by  activity_date
HAVING  DATEDIFF(day,activity_date,'2019-07-27') < 30  AND DATEDIFF(day, activity_date,'2019-07-27')>=0
