USE JOBS

BEGIN TRAN 
BEGIN TRY

--DECLARE @Tablename VARCHAR (25)
-- @Tablename = 'before the first'

INSERT INTO Customer VALUES 
('CU900021', 'Sean', 'Carlin', 'Spar', 'Strand RD', 'Derry', 'City', 'BT48 6OI','20190502')
SET @Tablename = 'After the first'


INSERT INTO Contract VALUES
('Z0000022', 'CU900021', '2020-03-10', 1)
SET @Tablename = 'After the second'

INSERT INTO Job VALUES
('J1000005', 102, 'Z0000022', 'TP5005','2009-02-08',2.00,0,null,null),
('J1000006', 103, 'Z0000020', 'TP5004','2009-02-08',1.50,0,null,null)
SET @Tablename = 'After the Third'


SELECT j.JobNo, j.StandardJobNo, j.ContractNo, j.TradesPersonNo, 
JobCost = sj.StandardPrice,
LabourCost = ROUND (SUM(tp.HourlyRate * j.Duration),2)

FROM Job j

JOIN StandardJob AS sj ON j.StandardJobNo = sj.StandardJobNo
JOIN TradesPerson AS tp ON j.TradesPersonNo = tp.TradesPersonNo
GROUP BY j.JobNo, j.StandardJobNo, j.ContractNo, j.TradesPersonNo,sj.StandardPrice

COMMIT TRAN
END TRY
BEGIN CATCH

PRINT 'An Error Occured ' + @TableName + ' Table Insert, Row Not Inserted.'
PRINT 'Error Number: ' + CONVERT (VARCHAR, ERROR_NUMBER())
PRINT 'Error Message: ' + ERROR_MESSAGE()

ROLLBACK TRAN
END CATCH
