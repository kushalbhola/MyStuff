/* Write your T-SQL query statement below */
select Name as Employee from Employee e 
where e.Salary > (select m.Salary from Employee m where e.managerID = m.ID)

SELECT a.name AS "Employee" FROM employee a, employee b
    WHERE a.managerid = b.id AND a.salary > b.salary;