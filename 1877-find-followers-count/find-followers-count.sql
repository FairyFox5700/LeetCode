/* Write your T-SQL query statement below */
SELECT user_id , COUNT(follower_id) as followers_count
FROM Followers
GROUP by user_id