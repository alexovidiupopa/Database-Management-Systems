-- T2 non repeatable reads
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
BEGIN TRAN
SELECT * FROM ChessTitle
WAITFOR DELAY '00:00:15'
SELECT * FROM ChessTitle
COMMIT TRAN

-- solution: iso level -> repeatable read
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
SELECT * FROM ChessTitle
WAITFOR DELAY '00:00:15'
SELECT * FROM ChessTitle
COMMIT TRAN