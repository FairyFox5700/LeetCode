/* Write your T-SQL query statement below */

DECLARE @count  INT  = (SELECT COUNT(*) FROM Seat);
SELECT  CASE 
    WHEN id % 2= 0 THEN  id-1
    WHEN id = @count  THEN id
    ELSE id+1 
    end as id,
    student
    from Seat
    order by id