
WITH CTE AS (
    SELECT player_id, MIN(event_date) AS min_event_date
    FROM Activity
    GROUP BY player_id
)
SELECT a.player_id, a.device_id
FROM Activity a
JOIN CTE c ON c.player_id = a.player_id  AND c.min_event_date = a.event_date;

