INSERT INTO ChessTitle(tid, title_name) VALUES (4, 'Casual')
BEGIN TRAN
WAITFOR DELAY '00:00:05'
UPDATE ChessTitle SET title_name='Pro' WHERE tid=4
COMMIT TRAN


--DELETE FROM ChessTitle WHERE tid=4
