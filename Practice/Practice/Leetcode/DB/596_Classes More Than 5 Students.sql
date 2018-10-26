--The question highlights the use of distinct in the aggregate, this behavior is default in oracle
select class from courses group by class having count(distinct student) >=5