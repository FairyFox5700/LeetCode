select name from SalesPerson where sales_id NOT IN (select o.sales_id
from Company c
join Orders o
on o.com_id = c.com_id
where c.name = 'RED')