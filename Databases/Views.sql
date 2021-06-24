-- Crystal Report Views

USE Jobs

CREATE VIEW ContractDetails AS 

SELECT c.CustomerNo,c.FirstName,c.LastName,j.ContractNo,con.DaysUntilRenewal,con.RenewalDate,con.RenewAutomatically,
COUNT (j.ContractNo) AS 'Total Contracts',
COUNT (s.StandardJobNo) AS Total,
SUM(s.StandardJobNo * s.StandardPrice) AS 'Total Cost'

FROM Customer c
JOIN Contract con ON c.CustomerNo = con.CustomerNo
LEFT JOIN Job j ON con.ContractNo = j.ContractNo
JOIN StandardJob s ON j.StandardJobNo = s.StandardJobNo
GROUP BY c.CustomerNo,c.FirstName,c.LastName,j.ContractNo,con.DaysUntilRenewal,con.RenewalDate,con.RenewAutomatically



CREATE VIEW JobDetails AS 

SELECT j.JobNo, j.StandardJobNo, j.ContractNo, j.TradesPersonNo, j.VisitDate, j.Duration, j.FollowUpRequired, j.FollowUpJobNo, j.Notes,
up.PartNo,up.UnitsUsed,
p.PartName AS 'Parts Used',p.UnitCost,
COUNT (p.PartNo) AS 'Total Parts Used',
SUM (up.UnitsUsed * p.UnitCost) AS 'Parts Total (£)'

FROM Job j
JOIN UsedParts up ON j.JobNo = up.JobNo
JOIN Part p ON up.PartNo = p.PartNo
GROUP BY j.JobNo, j.StandardJobNo, j.ContractNo, j.TradesPersonNo, j.VisitDate, j.Duration, j.FollowUpRequired, j.FollowUpJobNo, j.Notes,
up.PartNo,up.UnitsUsed,p.PartName, p.UnitCost
