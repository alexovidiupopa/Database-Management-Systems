-- non repeatable reads concurrency issue 
use library

begin tran 
waitfor delay '00:00:07'
update Libraries set location='cluj' where name = 'carturesti'
commit tran


update Libraries set location='brasov' where name = 'carturesti'
insert into Libraries(name, location) values ('carturesti','brasov')