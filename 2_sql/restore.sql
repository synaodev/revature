USE MASTER;
GO

RESTORE FILELISTONLY
FROM DISK = 'AdventureWorks2017.bak';

RESTORE DATABASE AdventureWorks2017
FROM DISK = 'AdventureWorks2017.bak'
WITH
MOVE 'AdventureWorks2017' TO '/var/opt/mssql/data/aw2017.mdf'
,MOVE 'AdventureWorks2017_log' TO '/var/opt/mssql/data/aw2017_log.ldf';
