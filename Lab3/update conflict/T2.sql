-- t2 update conflict
SET TRANSACTION ISOLATION LEVEL SNAPSHOT 
BEGIN TRAN
SELECT * FROM ChessTitle WHERE tid=10
-- here the value 'Retired' is returned
WAITFOR DELAY '00:00:10'
SELECT * FROM ChessTitle WHERE tid=1

UPDATE ChessTitle SET title_name='Beginner' WHERE tid=10
--process will block
--error 3960 will be issued
COMMIT TRAN