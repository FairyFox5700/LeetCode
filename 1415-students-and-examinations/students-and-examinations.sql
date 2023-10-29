/* Write your T-SQL query statement below */
SELECT s.student_id, s.student_name  , sb.subject_name, COALESCE(k.attended_exams, 0) AS attended_exams
FROM Students s
CROSS JOIN
Subjects sb
LEFT JOIN 
(
    SELECT e.student_id, sb.subject_name, COUNT(e.subject_name) AS attended_exams
    FROM Examinations e
    INNER JOIN Subjects sb ON sb.subject_name = e.subject_name
    GROUP BY e.student_id, sb.subject_name
) k
ON s.student_id = k.student_id
AND k.subject_name = sb.subject_name
ORDER BY s.student_id, sb.subject_name;