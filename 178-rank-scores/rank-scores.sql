/* Write your T-SQL query statement below */
SELECT score, dense_rank() OVER (ORDER BY score DESC) rank
FROM Scores
order by score DESC