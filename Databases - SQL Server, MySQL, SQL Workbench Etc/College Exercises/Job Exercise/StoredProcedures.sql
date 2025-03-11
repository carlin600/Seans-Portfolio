--JOBS DATABASE SYSTEM
DROP PROCEDURE spNewContract
USE Jobs

--1.	Using the database Jobs, script and test the following stored procedures.  Ensure appropriate validation is included:
--•	Return Job details based on input of a Contract No.
CREATE PROCEDURE spViewContract
@ContractNo VARCHAR(8)
AS
BEGIN TRY
IF(LEN(@ContractNo) < 1 OR LEN(@ContractNo) > 8)
	RAISERROR('Contract Number must be between 1 & 8!',11,1)
IF NOT EXISTS(SELECT * FROM Contract WHERE ContractNo = @ContractNo)
	RAISERROR ('Contract Number does not exist!', 11,1)

SELECT j.JobNo, j.StandardJobNo, j.ContractNo, j.TradesPersonNo, j.VisitDate, j.Duration,j.FollowUpRequired,j.FollowUpJobNo,j.Notes

FROM Job j
JOIN Contract c ON j.ContractNo = c.ContractNo

WHERE @ContractNo = c.ContractNo
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage VARCHAR(100)
	SELECT @ErrorMessage = ERROR_MESSAGE()
	PRINT @ErrorMessage
END CATCH

EXEC spViewContract @ContractNo = Z0000001





--•	Return a list of skilled tradespeople based on the input of a Skill Code.
CREATE PROCEDURE spViewSkills
@SkillCode CHAR(3)
AS
BEGIN TRY
IF(LEN(@SkillCode) < 1 OR LEN(@SkillCode) > 3)
	RAISERROR('Skill Code must be between 1 & 3!',11,1)
IF NOT EXISTS(SELECT * FROM Skills WHERE SkillCode = @SkillCode)
	RAISERROR ('Skill Code does not exist!', 11,1)
SELECT t.TradesPersonNo, t.TradesPersonName, t.HourlyRate, t.OverTimeRate,
s.SkillCode,s.SkillName

FROM TradesPerson t

JOIN TradesPersonSkills tp ON t.TradesPersonNo = tp.TradesPersonNo
JOIN Skills s ON tp.SkillCode = s.SkillCode

WHERE @SkillCode = s.SkillCode
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage VARCHAR(100)
	SELECT @ErrorMessage = ERROR_MESSAGE()
	PRINT @ErrorMessage
END CATCH

EXEC spViewSkills @SkillCode = GAS





--•	Return a list of all trades people who are electricians.
CREATE PROCEDURE spViewElectricians
@SkillCode CHAR(3)
AS
BEGIN TRY
IF(LEN(@SkillCode) < 1 OR LEN(@SkillCode) > 3)
	RAISERROR('Skill Code must be between 1 & 3!',11,1)
IF NOT EXISTS(SELECT * FROM Skills WHERE SkillCode = @SkillCode)
	RAISERROR ('Skill Code does not exist!', 11,1)
SELECT t.TradesPersonNo, t.TradesPersonName,
s.SkillCode,s.SkillName

FROM TradesPerson t

JOIN TradesPersonSkills tp ON t.TradesPersonNo = tp.TradesPersonNo
JOIN Skills s ON tp.SkillCode = s.SkillCode

WHERE @SkillCode = s.SkillCode
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage VARCHAR(100)
	SELECT @ErrorMessage = ERROR_MESSAGE()
	PRINT @ErrorMessage
END CATCH

EXEC spViewElectricians @SkillCode = ELC






--•	Delete Part No SLCU8WAY.
CREATE PROCEDURE spDeletePart
@PartNo CHAR(8)
AS
BEGIN TRY
IF NOT EXISTS(SELECT * FROM Part WHERE PartNo = @PartNo)
	RAISERROR ('Part No does not exist!', 11,1)
IF(LEN(@PartNo) < 1 OR LEN(@PartNo) > 8)
	RAISERROR('Part Number must be between 1 & 8!',11,1)
DELETE FROM Part 
WHERE PartNo = @PartNo
END TRY

BEGIN CATCH
	DECLARE @ErrorMessage VARCHAR(100)
	SELECT @ErrorMessage = ERROR_MESSAGE()
	PRINT @ErrorMessage
END CATCH

EXEC spDeletePart @PartNo = 'SLCU8WAY'







--•	Insert a new job for a designated Contract.
CREATE PROCEDURE spNewJob
@JobNo VARCHAR(8),
@VisitDate DATETIME,
@Duration DECIMAL(4,2), @FollowUpRequired BIT, @FollowUpJobNo VARCHAR(8), 
@Notes VARCHAR(250)
AS
BEGIN TRY
IF(LEN(@Notes) < 1 OR LEN(@Notes) > 250)
	RAISERROR('Notes must be between 1 & 250!',11,1)

	 -- substring function, declare int, lift 5025 



  --@ContractNo VARCHAR(8), @StandardJobNo INT --@JobNo VARCHAR(8)
--SELECT @JobNo = CONVERT (VARCHAR(8),(SELECT TOP 1 JobNo FROM Job ORDER BY JobNo DESC) + 1)


--(INT, (SELECT TOP 1 TradesPersonNo FROM TradesPerson ORDER BY TradesPersonNo DESC)
DECLARE @TradesPersonNo VARCHAR(6)
SELECT @TradesPersonNo = CONVERT (INT,( SUBSTRING ('TP5001',3,4)+ 1) + ('TP' + @TradesPersonNo) )
--so damn close!

--SELECT @ContractNo = CONVERT (VARCHAR,(SELECT TOP 1 ContractNo FROM Contract ORDER BY ContractNo DESC) + 1)
--SELECT @StandardJobNo = CONVERT (INT,(SELECT TOP 1 StandardJobNo FROM StandardJob ORDER BY StandardJobNo DESC) + 1)



INSERT INTO Job VALUES
(@JobNo,@TradesPersonNo,@ContractNo,@StandardJobNo, @VisitDate, @Duration, @FollowUpRequired, @FollowUpJobNo, @Notes)
END TRY 

BEGIN CATCH 
	DECLARE @ErrorMessage VARCHAR(100)
	SELECT @ErrorMessage = ERROR_MESSAGE()
	PRINT @ErrorMessage
END CATCH
-- USE SUBSTRING


EXEC spNewJob
@JobNo = 'J1000004', @VisitDate = '2019-04-10', @Duration = 22.45, @FollowUpRequired = false, @FollowUpJobNo = NULL, @Notes = 'SeanCarlin Testing his assignment validation'

--see teresa






--•	Insert a new Contract for a designated Customer and update the Job details to reflect that there are now 2 jobs for the new Contract.
CREATE PROCEDURE spNewContract
@ContractNo VARCHAR(8), /*@CustomerNo VARCHAR(8),*/
@RenewalDate smalldatetime, @RenewAutomatically BIT
AS 
BEGIN

INSERT INTO Contract VALUES
(@ContractNo, /*@CustomerNo,*/ @RenewalDate, @RenewAutomatically)

--UPDATE Contract
--SET ContractNo = @ContractNo, CustomerNo = @CustomerNo, RenewalDate = @RenewalDate, RenewAutomatically = @RenewAutomatically 
END

EXEC spNewContract @ContractNo = 1111, /*@CustomerNo = J1000002,*/ @RenewalDate = '20190411', @RenewAutomatically = 'FALSE'

----------------- couldnt get update to work



--•	Return a list of Contracts that are up for renewal within the next 30 days.
CREATE PROCEDURE spSoonRenewals
AS
BEGIN TRY
SELECT C.ContractNo, C.CustomerNo, C.RenewalDate, C.RenewAutomatically, C.DaysUntilRenewal
FROM Contract C
WHERE C.DaysUntilRenewal < 30
END TRY

BEGIN CATCH 
	DECLARE @ErrorMessage VARCHAR(100)
	SELECT @ErrorMessage = ERROR_MESSAGE()
	PRINT @ErrorMessage
END CATCH

EXEC spSoonRenewals 



--•	Return a list of Skills, along with the total number of tradespeople with that skill.  
---In addition, provide a list of the tradespeople, grouped by skill code.

CREATE PROCEDURE spDisplaySkills
AS
BEGIN TRY

SELECT s.SkillCode, s.SkillName,
COUNT (t.TradesPersonNo) AS 'Total With this Skill'

FROM Skills s
JOIN TradesPersonSkills tp ON s.SkillCode = tp.SkillCode
JOIN TradesPerson t ON tp.TradesPersonNo = t.TradesPersonNo
GROUP BY  s.SkillCode, s.SkillName


SELECT t.TradesPersonName, s.SkillName, s.SkillCode
FROM Skills s
JOIN TradesPersonSkills tp ON s.SkillCode = tp.SkillCode
JOIN TradesPerson t ON tp.TradesPersonNo = t.TradesPersonNo
GROUP BY s.SkillCode,  t.TradesPersonName, s.SkillName
END TRY 

BEGIN CATCH
	DECLARE @ErrorMessage VARCHAR(100)
	SELECT @ErrorMessage = ERROR_MESSAGE()
	PRINT @ErrorMessage
END CATCH

EXEC spDisplaySkills









--•	Return the Customer details and number of jobs (if any) for a designated Contract.
CREATE PROCEDURE spDesignatedContract
@ContractNo VARCHAR(8) 
AS
BEGIN TRY
SELECT c.CustomerNo,c.FirstName,c.LastName,c.BusinessName,c.Street,c.Town,c.AreaCode,c.Postcode,c.CreatedDate,c.Age,
COUNT (j.JobNo) AS 'Total Jobs',
j.ContractNo

FROM Customer c
JOIN Contract con ON c.CustomerNo = con.CustomerNo
LEFT JOIN Job j ON con.ContractNo = j.ContractNo

WHERE j.ContractNo = @ContractNo
GROUP BY c.CustomerNo,c.FirstName,c.LastName,c.BusinessName,c.Street,c.Town,c.AreaCode,c.Postcode,c.CreatedDate,c.Age,j.ContractNo
END TRY

BEGIN CATCH 
	DECLARE @ErrorMessage VARCHAR(100)
	SELECT @ErrorMessage = ERROR_MESSAGE()
	PRINT @ErrorMessage
END CATCH


EXEC spDesignatedContract @ContractNo = 'Z0000005'







--•	Return a count of all Contracts held by Customers, along with number of jobs (if any) for a designated Contract, 
---sorted by Customer No and Contract No.  
---The Customer name and Contract details also be included, along with a total amount for each Contract. <- what????

CREATE PROCEDURE spContractDetails
AS
BEGIN TRY

SELECT c.CustomerNo,c.FirstName,c.LastName,j.ContractNo,con.DaysUntilRenewal,con.RenewalDate,con.RenewAutomatically,
COUNT (j.ContractNo) AS 'Total Contracts'

FROM Customer c
JOIN Contract con ON c.CustomerNo = con.CustomerNo
LEFT JOIN Job j ON con.ContractNo = j.ContractNo
GROUP BY c.CustomerNo,c.FirstName,c.LastName,j.ContractNo,con.DaysUntilRenewal,con.RenewalDate,con.RenewAutomatically
ORDER BY c.CustomerNo,J.ContractNo


SELECT c.FirstName,c.LastName,j.ContractNo,
COUNT (s.StandardJobNo) AS Total,
SUM(s.StandardJobNo * s.StandardPrice) AS 'Total Cost'

FROM Customer c
JOIN Contract con ON c.CustomerNo = con.CustomerNo
LEFT JOIN Job j ON con.ContractNo = j.ContractNo
JOIN StandardJob s ON j.StandardJobNo = s.StandardJobNo

GROUP BY c.FirstName,c.LastName,j.ContractNo

END TRY

BEGIN CATCH 
	DECLARE @ErrorMessage VARCHAR(100)
	SELECT @ErrorMessage = ERROR_MESSAGE()
	PRINT @ErrorMessage
END CATCH

EXEC spContractDetails
