use coffee
-- phantom problem T2 - initial iso level set to repeatable read
-- in the second select we will see the "phantom", i.e. the record which shouldn't be there, because it will be inserted from T1 when the delay finishes
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
SELECT * FROM CoffeeShops
WAITFOR DELAY '00:00:05'
SELECT * FROM CoffeeShops
COMMIT TRAN

-- solution: set isolation level of T2 to serializable
-- Because now when we are at serializabile level we need xlock to read/write, the phantom won't "appear" 
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
SELECT * FROM CoffeeShops
WAITFOR DELAY '00:00:05'
SELECT * FROM CoffeeShops
COMMIT TRAN