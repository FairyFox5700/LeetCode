SELECT weather.id AS 'Id'
FROM weather
JOIN weather w
ON DATEDIFF(day,  w.recordDate, weather.recordDate) = 1 
AND weather.Temperature > w.Temperature;