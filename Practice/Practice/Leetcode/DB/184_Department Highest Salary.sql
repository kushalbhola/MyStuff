--URL: https://leetcode.com/problems/department-highest-salary/description/
--Method: 1

With cte as 
(
    select d.Name as Department, e.Name as Employee , e.salary as Salary, dense_rank() over (partition by d.Name order by e.salary desc) as rnk 
    from Employee e inner join Department d on e.DepartmentID = d.ID 
)
select Department, Employee, Salary from cte where cte.rnk = 1
--Method: 2

--Just use DimEMployee instead of Employee and DimOrganization as Department

with test as 
(
select do.OrganizationExternalFullName, max(de.CurrentBaseSalary) as maxSalary from DimEmployee de inner join DimOrganization do On de.ApplicationOrganizationID = do.OrganizationApplicationID 
group by do.OrganizationExternalFullName
)
select De.FullName, test.OrganizationExternalFullName, test.maxSalary from DimEmployee de inner join DimOrganization do ON de.ApplicationOrganizationID = do.OrganizationApplicationID
inner join test ON do.OrganizationExternalFullName = test.OrganizationExternalFullName and test.maxSalary = de.CurrentBaseSalary