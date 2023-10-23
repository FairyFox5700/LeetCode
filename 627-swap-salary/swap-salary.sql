/* Write your T-SQL query statement below */
update salary set sex = (CASE sex 
when  'm' then 'f'
else 'm'
end );