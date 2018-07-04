--Question: https://www.hackerrank.com/challenges/placements/problem

select s.Name from students s 
    inner join friends f on s.id = f.id
    inner join packages fS on fS.ID = f.friend_id
    inner join packages sS on sS.ID = s.ID
where sS.Salary < fS.Salary
order by fs.Salary