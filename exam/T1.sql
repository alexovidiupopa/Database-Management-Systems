-- phantom read t1 - just insert an entry after a delay
use coffee

BEGIN TRAN 
WAITFOR DELAY '00:00:04'
INSERT INTO CoffeeShops (name, address) values ('alin', 'str. lunga nr.4')
COMMIT TRAN
