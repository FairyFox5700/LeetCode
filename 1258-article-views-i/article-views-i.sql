/* Write your T-SQL query statement below */
select DISTINCT author_id as id
from Views
where author_id   = viewer_id 
