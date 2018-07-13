--https://leetcode.com/problems/consecutive-numbers/description/

WITH temp as
(SELECT NUM
, LEAD(NUM, 1) OVER (ORDER BY ID) as lead
, LAG(NUM, 1) OVER (ORDER BY ID) as lag
 from logs
)
select distinct num as ConsecutiveNums  from temp t where t.num = t.lead and t.num = t.lag