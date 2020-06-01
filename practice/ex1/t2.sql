use library

set transaction isolation level read committed 
begin tran 
select * from Libraries 
waitfor delay '00:00:15'
select * from Libraries 
commit tran 


--solution : set iso level to repeatable read 
set transaction isolation level repeatable read 
begin tran 
select * from Libraries 
waitfor delay '00:00:15'
select * from Libraries 
commit tran 

