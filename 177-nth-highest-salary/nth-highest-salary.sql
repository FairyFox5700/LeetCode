CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    DECLARE @Result INT;

    WITH rankedSalaries AS (
        SELECT id, dense_rank() OVER (ORDER BY salary DESC) AS rank
        FROM Employee
    )
    SELECT @Result = salary
    FROM Employee e
    JOIN rankedSalaries rd ON rd.id = e.id
    WHERE rd.rank = @N;

    RETURN @Result;
END;
