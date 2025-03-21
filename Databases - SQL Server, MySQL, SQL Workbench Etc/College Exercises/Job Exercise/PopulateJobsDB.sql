 

-- Create GeographicalAreas data
INSERT INTO GeographicalArea (AreaCode, AreaName) VALUES 
('AVO', 'Avon'),
('BED', 'Bedfordshire'),
('BER', 'Berkshire'),
('BOR', 'Borders'),
('BUC', 'Buckinghamshire'),
('CAM', 'CambrNogeshire'),
('CEN', 'Central London'),
('CHE', 'Cheshire'),
('CLE', 'Cleveland'),
('CLW', 'Clwyd'),
('COR', 'Cornwall'),
('CAN', 'County Antrim'),
('CAR', 'County Armagh'),
('CDO', 'County Down'),
('CFE', 'County Fermanagh'),
('CDE', 'County Londonderry'),
('CTY', 'County Tyrone'),
('CUM', 'Cumbria'),
('DER', 'Derbyshire'),
('DEV', 'Devon'),
('DOR', 'Dorset'),
('DUM', 'Dumfries and Galloway'),
('DUR', 'Durham'),
('DYF', 'Dyfed'),
('EAS', 'East Sussex'),
('ESS', 'Essex'),
('FIF', 'Fife'),
('GLO', 'Gloucestershire'),
('GRA', 'Grampian'),
('HAM', 'Hampshire'),
('HER', 'Herefordshire'),
('HRT', 'Hertfordshire'),
('HIG', 'Highlands and Islands'),
('HUM', 'HumbersNoe'),
('ISL', 'Isle of Wight'),
('KEN', 'Kent'),
('LAN', 'Lancashire'),
('LEI', 'Leicestershire'),
('LIN', 'Lincolnshire'),
('LOT', 'Lothian'),
('MNo', 'MNo Glamorgan'),
('NRF', 'Norfolk'),
('NYO', 'North Yorkshire'),
('NRT', 'Northamptonshire'),
('NSC', 'Northern Scotland'),
('NHM', 'Northumberland'),
('NOT', 'Nottinghamshire'),
('OXF', 'Oxfordshire'),
('POW', 'Powys'),
('RUT', 'Rutland'),
('SHR', 'Shropshire'),
('SOM', 'Somerset'),
('SGL', 'South Glamorgan'),
('SYO', 'South Yorkshire'),
('SSC', 'Southern Scotland'),
('STA', 'Staffordshire'),
('STR', 'Strathclyde'),
('SUF', 'Suffolk'),
('SUR', 'Surrey'),
('TAY', 'TaysNoe'),
('WAL', 'Wales'),
('WAR', 'Warwickshire'),
('WGL', 'West Glamorgan'),
('WMI', 'West MNolands'),
('WSU', 'West Sussex'),
('WYO', 'West Yorkshire'),
('WIL', 'Wiltshire'),
('WOR', 'Worcestershire')


-- Create Customers data
INSERT INTO Customer (CustomerNo, FirstName, LastName, BusinessName, Street, Town, AreaCode, Postcode, CreatedDate)
VALUES
 ('CU900001', 'Arden', 'Best', null, '52B Oxford Road', 'Manchester', 'LAN', 'M1 7DU', '2008-01-15'),
 ('CU900002', 'Dee', 'Marlow', null, '31A High Street', 'MaNostone', 'KEN', 'ME14 1JF', '2008-01-14'),
 ('CU900003', 'Alan', 'George', null, 'Flat C Alfred House', 'Newcastle under Lyme', 'STA', 'ST5 1RW', '2008-01-21'),
 ('CU900004', 'Noel', 'Pitts', null, '221 Spon End', 'Coventry', 'WAR', 'CV1 3HE', '2007-11-30'),
 ('CU900005', 'Antoine', 'Munoz', 'Blue-Green Ltd', '23 Villa Street', 'Nottingham', 'NOT', 'NG9 2NY', '2008-01-16'),
 ('CU900006', 'Olivia', 'Kong', null, '34A Jury Street', 'Warwick', 'WAR', 'CV34 4EH', '2007-09-15'),
 ('CU900007', 'Karl', 'Moten', null, 'Outer Green Street', 'Holsworthy', 'DEV', 'EX22 6BL', '2008-01-03'),
 ('CU900008', 'Emma', 'Ledoux', null, '1024 Salisbury Road', 'Blandford Forum', 'DOR', 'DT11 7LP', '2008-02-02'),
 ('CU900009', 'Cory', 'Harvey', null, '604 Wootton Road', 'King''s Lynn', 'NRF', 'PE30 3AR', '2008-01-16'),
 ('CU900010', 'Dita', 'Sewell', null, '15 Harrogate Road', 'Leeds', 'WYO', 'LS7 4LA', '2007-12-18'),
 ('CU900011', 'Tricia', 'Slack', null, '53A Chell Street','Stoke-on-Trent', 'STA', 'ST1 6AZ', '2008-03-09'),
 ('CU900012', 'Gail', 'Lynn', null, '1 Short Lane', 'Abingdon', 'OXF', 'OX14', '2008-05-09'),
 ('CU900013', 'Rudy', 'Charles', null, '84B Chapel Street', 'Manchester', 'LAN', 'M3 5BZ', '2008-06-21'),
 ('CU900014', 'Renato', 'Mintz', 'Marlborough House', 'Unit 9 Magdalen Road Business Park', 'Oxford', 'OXF', 'OX4 1RB', '2007-09-11'),
 ('CU900015', 'Ronald', 'McHugh', null, '1 Brighton Close', 'Warminster', 'WIL', 'BA12 7DS', '2008-03-16'),
 ('CU900016', 'Kelley', 'Daigle', null, '22B Pontefract Road', 'Leeds', 'WYO', 'LS10 1S', '2007-08-27'),
 ('CU900017', 'Gary', 'Rhea', null, '767 Salisbury Road', 'Cardiff', 'WAL', 'CF24 4AD', '2008-01-02'),
 ('CU900018', 'Sinead', 'Paul', null, '1747 St Mary''s Road', 'Sheffield', 'SYO', 'S2 4AW', '2008-02-02'),
 ('CU900019', 'Rita', 'Vegas', 'Red-Purple plc', '128 Pendleton Way', 'Salford', 'LAN', 'M6 5FW', '2008-01-31'),
 ('CU900020', 'Ethan', 'Volz', null, '96B Colman Road', 'Norwich', 'NRF', 'NR4 7EH', '2007-12-08')
 

 -- Create TradesPerson data
INSERT INTO TradesPerson (TradesPersonNo, TradesPersonName, HourlyRate, OvertimeRate)
VALUES 
('TP5001', 'Donny Boyles', 19.75, 29.63),
('TP5002', 'Titus Hinton', 19.65, 29.48),
('TP5003', 'Joey Ohara', 18.50, 27.75),
('TP5004', 'Merlin Givens', 21.00, 31.50),
('TP5005', 'Randy Fulcher', 22.50, 33.75),
('TP5006', 'Fred Burke', 16.30, 24.45),
('TP5007', 'Luther Langlois', 17.00, 25.50),
('TP5008', 'Clarisa Fajardo', 19.75, 29.63),
('TP5009', 'Tamika Grove', 18.60, 27.90),
('TP5010', 'Richard Bayne', 19.75, 29.63),
('TP5011', 'Siu Nelms', 22.15, 33.23),
('TP5012', 'Berry Harter', 25.00, 37.50),
('TP5013', 'Allan Keeton', 17.20, 25.80),
('TP5014', 'Benjamin Logue', 19.75, 29.63),
('TP5015', 'Daniel Spring', 16.45, 24.68),
('TP5016', 'Wilma Lambert', 17.00, 25.50),
('TP5017', 'Tyrone Jackson', 21.99, 32.99),
('TP5018', 'Tammara Barnhart', 18.90, 28.35),
('TP5019', 'Wade Busby', 24.00, 36.00),
('TP5020', 'Stephen Chatman', 20.00, 30.00),
('TP5021', 'Lucy Eaves', 20.00, 30.00),
('TP5022', 'Bert Amaral', 20.00, 30.00),
('TP5023', 'Ross Christenson', 20.00, 30.00),
('TP5024', 'Winford Manns', 20.00, 30.00),
('TP5025', 'Sam Polk', 19.75, 29.63)


-- Create Contracts data
INSERT INTO Contract (ContractNo, CustomerNo, RenewalDate, RenewAutomatically)
VALUES
('Z0000001', 'CU900001', '20191208', 1),
('Z0000002', 'CU900002', '20190215', 0),
('Z0000003', 'CU900003', '20190114', 0),
('Z0000004', 'CU900004', '20190321', 1),
('Z0000005', 'CU900005', '20191214', 0),
('Z0000006', 'CU900006', '20190429', 1),
('Z0000007', 'CU900007', '20190915', 1),
('Z0000008', 'CU900008', '20200113', 0),
('Z0000009', 'CU900009', '20190415', 1),
('Z0000010', 'CU900010', '20190622', 1),
('Z0000011', 'CU900011', '20191218', null),
('Z0000012', 'CU900012', '20190309', 1),
('Z0000013', 'CU900013', '20190509', 0),
('Z0000014', 'CU900014', '20190621', 0),
('Z0000015', 'CU900015', '20190411', 1),
('Z0000016', 'CU900016', '20190426', 1),
('Z0000017', 'CU900017', '20190501', 0),
('Z0000018', 'CU900018', '20190512', 1),
('Z0000019', 'CU900019', '20190202', 1),
('Z0000020', 'CU900020', '20200131', 1),
('Z0000021', 'CU900020', '20200201', 1)


-- Create Skills data
INSERT INTO Skills (SkillCode, SkillName)
VALUES
('GAS', 'CORGI Registered Gas Installer'),
('ELC', 'Electrician'),
('PLM', 'Plumber'),
('DRN', 'Drainage Specialist')


-- Create StandardJobs data
INSERT INTO StandardJob (StandardJobNo, JobName, JobDescription, StandardPrice)
VALUES 
(100, 'Radiator Leak', 'Repair leaking radiator valve, unit or pipework.', 59.99),
(101, 'Central Heating Boiler Failure', 'Invesitigate boiler failure, make required repairs and perform a safety check.', 249.99),
(102, 'Electrical Socket Failure', 'Replace electrical socket and check wiring safety.', 79.99),
(103, 'Electrical Ring Main Failure', 'Investigate electrical ring main, repair and check wiring safety.', 179.99),
(104, 'Blocked Drain', 'Clear drain and make appropriate repairs.', 90.00),
(105, 'Blocked Lavatory', 'Clear lavatory and make appropriate repairs.', 89.99),
(106, 'Dripping Tap', 'Replace washers, repair or replace tap.', 79.99),
(107, 'Leaking Water Tank', 'Repair or replace water tank, valves or pipework.', 109.99),
(108, 'Leaking Lavatory', 'Repair or replace lavatory valves or pipework.', 39.99),
(109, 'Light Switch Failure', 'Replace electrical socket and check wiring safety.', 39.99)



-- Create Part data
INSERT INTO Part (PartNo, PartName, UnitCost)
VALUES 
('15COPIPE', '15mm Copper Pipe', 1.52),
('22COPIPE', '22mm Copper Pipe', 2.97),
('10MICCOP', '10mm Microbore Copper Tube', 1.17),
('25STPTAP', '25x25mm Stop Tap', 5.99),
('15PYSTAP', '15x25mm Poly Stop Tap', 3.44),
('15ISOVLV', '15mm Isolating Valve', 0.56),
('22ISOVLV', '22mm Isolating Valve', 1.28),
('15ISHVLV', '15mm Isolating Valve with Handle', 1.04),
('22SRVVLV', '22mm Service Valve', 3.27),
('22ISOVCH', '22mm Full Bore Chrome Isolating Valve', 3.19),
('15CHKVLV', '15mm Single Check Valve', 1.27),
('15CHKVLD', '15mm Double Check Valve', 2.40),
('15STOPCK', '15mm Stop Cock', 1.76),
('22STOPCK', '22mm Stop Cock', 5.03),
('15GATVLV', '15x15mm Gate Valve', 1.84),
('22GATVLV', '22x22mm Gate Valve', 2.56),
('28GATVLV', '28mm Gate Valve', 4.03),
('15FBLBVL', '15mm Full Bore Lever Ball Valve', 2.40),
('22FBLBVL', '22mm Full Bore Lever Ball Valve', 4.00),
('15DRNCCK', '15mm Drain Cock', 0.48),
('15TRMMIX', '15mm Thermostatic Mixing Valve', 33.62),
('22TRMMIX', '22mm Thermostatic Mixing Valve', 50.40),
('15COELBO', '15mm Copper Pipe Elbow', 0.77),
('22COELBO', '22mm Copper Pipe Elbow', 0.69),
('28COELBO', '28mm Copper Pipe Elbow', 0.74),
('10COPTEE', '10mm Copper Pipe Tee', 1.62),
('15COPTEE', '15mm Copper Pipe Tee', 0.49),
('22COPTEE', '22mm Copper Pipe Tee', 1.58),
('28COPTEE', '28mm Copper Pipe Tee', 2.05),
('15FXTP30', '15mm x 3m Flexible Tap Connector', 1.36),
('15FXTP90', '15mm x 9m Flexible Tap Connector', 5.92),
('22FXTP20', '22mm x 2m Flexible Tap Connector (Cold Water)', 3.83),
('15PIPREP', '15mm Push Fit Pipe Repair Kit', 3.03),
('4GWTANK', '4 Gallon Cold Water Tank', 15.20),
('25WTANK', '25 Gallon Cold Water Tank', 39.99),
('50WTANK', '50 Gallon Cold Water Tank', 63.99),
('CHCLEANR', '1 Litre Central Heating Cleaner', 5.12),
('CHINHIBT', '1 Litre Central Heating Inhibitor', 5.12),
('CHLKSEAL', '1 Litre Central Heating Leak Sealer', 8.01),
('SHX5PUMP', 'Supaheata X5 Circulating Pump', 31.99),
('PUMPVBAL', 'Pump Valve Ball', 2.24),
('PUMPVGAT', 'Pump Valve Gate', 2.40),
('SHTHERMO', 'Supaheata Room Thermostat', 6.39),
('SHDTHERM', 'Supaheata Digital Room Thermostat', 14.41),
('SHX5BOIL', 'Supaheata X5 Combination Boiler', 571.19),
('SHX8BOIL', 'Supaheata X8 Condensing Boiler', 719.99),
('SHFLUEKT', 'Supaheata Flue Kit', 51.19),
('SLCONSUN', 'Supaleccy 40A Garage Consumer Unit', 25.16),
('SLCU5WAY', 'Supaleccy 5 Way Insulated Consumer Unit', 12.41),
('SLCU8WAY', 'Supaleccy 8 Way Insulated Consumer Unit', 15.04),
('SLCUSL12', 'Supaleccy 12 Way Load Consumer Unit', 35.96),
('SL13ASOK', 'Supaleccy 13 Amp Socket', 0.24),
('LSWTCHSN', 'Supaleccy Single Light Switch', 0.21),
('LSWTCHDB', 'Supaleccy Double Light Switch', 0.38)


-- Create RequiredSkills data
INSERT INTO RequiredSkills (StandardJobNo, SkillCode)
VALUES 
(100, 'PLM'),
(102, 'GAS'),
(102, 'PLM'),
(103, 'ELC'),
(104, 'ELC'),
(105, 'DRN'),
(106, 'DRN'),
(107, 'PLM'),
(108, 'PLM'),
(109, 'ELC')


-- Create TradesPersonSkills data
INSERT INTO TradesPersonSkills (TradesPersonNo, SkillCode)
VALUES 
('TP5001', 'GAS'),
('TP5001', 'PLM'),
('TP5002', 'PLM'),
('TP5003', 'ELC'),
('TP5004', 'ELC'),
('TP5005', 'PLM'),
('TP5006', 'GAS'),
('TP5006', 'PLM'),
('TP5007', 'PLM'),
('TP5008', 'ELC'),
('TP5009', 'PLM'),
('TP5010', 'PLM'),
('TP5010', 'DRN'),
('TP5011', 'PLM'),
('TP5011', 'GAS'),
('TP5012', 'ELC'),
('TP5013', 'GAS'),
('TP5013', 'PLM'),
('TP5014', 'ELC'),
('TP5015', 'ELC'),
('TP5016', 'PLM'),
('TP5017', 'GAS'),
('TP5017', 'PLM'),
('TP5018', 'PLM'),
('TP5019', 'ELC'),
('TP5020', 'GAS'),
('TP5020', 'PLM'),
('TP5021', 'ELC'),
('TP5022', 'GAS'),
('TP5022', 'PLM'),
('TP5023', 'DRN'),
('TP5024', 'GAS'),
('TP5024', 'PLM'),
('TP5025', 'DRN')


-- Create Job data
INSERT INTO Job (JobNo, StandardJobNo, ContractNo, TradesPersonNo, VisitDate, Duration, FollowUpRequired, FollowUpJobNo, Notes)
VALUES 
('J1000000', 103, 'Z0000001', 'TP5004', '2008-03-04', 2.5, 0, 'J1000003', 'TradesPerson required additional part'),
('J1000001', 101, 'Z0000005', 'TP5022', '2001-12-02', 1.25, 0, null, null),
('J1000002', 109, 'Z0000011', 'TP5008', '2008-04-07', 0.5, 0, null, null),
('J1000003', 103, 'Z0000001', 'TP5004', '2008-03-02', 2, 1, null, null)


-- Create UsedPart data
INSERT INTO UsedParts (JobNo, PartNo, UnitsUsed)
VALUES
('J1000000', 'SL13ASOK', 1),
('J1000001', '15COPIPE', 3),
('J1000001', '15COELBO', 1),
('J1000001', '15PIPREP', 1),
('J1000002', 'LSWTCHDB', 2)


-- Create TradesPersonStock data
INSERT INTO TradesPersonStock (TradesPersonNo, PartNo, UnitsHeld)
VALUES
('TP5001', '15COPIPE', 18.00),
('TP5001', '22COPIPE', 15.00),
('TP5001', '10MICCOP', 6.50),
('TP5001', '25STPTAP', 3.00),
('TP5001', '15ISOVLV', 3.00),
('TP5001', '22ISOVLV', 2.00),
('TP5001', '15ISHVLV', 1.00),
('TP5001', '22SRVVLV', 4.00),
('TP5001', '22ISOVCH', 2.00),
('TP5001', '15CHKVLV', 1.00),
('TP5001', '15CHKVLD', 2.00),
('TP5001', '15STOPCK', 4.00),
('TP5001', '22STOPCK', 3.00),
('TP5001', '15GATVLV', 7.00),
('TP5001', '22GATVLV', 2.00),
('TP5001', '28GATVLV', 5.00),
('TP5001', '15FBLBVL', 3.00),
('TP5001', '22FBLBVL', 10.00),
('TP5001', '15DRNCCK', 1.00),
('TP5001', '15TRMMIX', 3.00),
('TP5001', '22TRMMIX', 5.00),
('TP5001', '15COELBO', 2.00),
('TP5001', '22COELBO', 7.00),
('TP5001', '28COELBO', 8.00),
('TP5001', '10COPTEE', 1.00),
('TP5001', '15COPTEE', 12.00),
('TP5001', '22COPTEE', 25.00),
('TP5001', '28COPTEE', 14.00),
('TP5001', '15FXTP30', 1.00),
('TP5001', '15FXTP90', 4.00),
('TP5001', '22FXTP20', 2.00),
('TP5001', 'CHCLEANR', 2.00),
('TP5001', 'CHINHIBT', 3.00),
('TP5001', 'CHLKSEAL', 5.00),
('TP5001', 'SHX5PUMP', 2.00),
('TP5001', 'PUMPVBAL', 4.00),
('TP5001', 'PUMPVGAT', 3.00),
('TP5001', 'SHTHERMO', 1.00),
('TP5001', 'SHDTHERM', 1.00),
('TP5001', 'SHFLUEKT', 2.00),
('TP5002', '15COPIPE', 7.00),
('TP5002', '22COPIPE', 9.00),
('TP5002', '10MICCOP', 4.75),
('TP5002', '25STPTAP', 1.00),
('TP5002', '15ISOVLV', 5.00),
('TP5002', '22ISOVLV', 3.00),
('TP5002', '15ISHVLV', 6.00),
('TP5002', '22SRVVLV', 8.00),
('TP5002', '22ISOVCH', 4.00),
('TP5002', '15CHKVLV', 2.00),
('TP5002', '15CHKVLD', 7.00),
('TP5002', '15STOPCK', 9.00),
('TP5002', '22STOPCK', 4.00),
('TP5002', '15GATVLV', 1.00),
('TP5002', '22GATVLV', 4.00),
('TP5002', '28GATVLV', 5.00),
('TP5002', '15FBLBVL', 3.00),
('TP5002', '22FBLBVL', 6.00),
('TP5002', '15DRNCCK', 7.00),
('TP5002', '15TRMMIX', 8.00),
('TP5002', '22TRMMIX', 7.00),
('TP5002', '15COELBO', 5.00),
('TP5002', '22COELBO', 5.00),
('TP5002', '28COELBO', 4.00),
('TP5002', '10COPTEE', 3.00),
('TP5002', '15COPTEE', 14.00),
('TP5002', '22COPTEE', 15.00),
('TP5002', '28COPTEE', 4.00),
('TP5002', '15FXTP30', 2.00),
('TP5002', '15FXTP90', 2.00),
('TP5002', '22FXTP20', 4.00),
('TP5002', 'CHCLEANR', 3.00),
('TP5002', 'CHINHIBT', 1.00),
('TP5002', 'CHLKSEAL', 1.00),
('TP5003', 'SLCONSUN', 2.00),
('TP5003', 'SLCU5WAY', 1.00),
('TP5003', 'SLCUSL12', 3.00),
('TP5004', 'SLCONSUN', 3.00),
('TP5004', 'SLCU5WAY', 2.00),
('TP5004', 'SLCUSL12', 4.00),
('TP5005', '15COPIPE', 9.00),
('TP5005', '22COPIPE', 11.00),
('TP5005', '10MICCOP', 6.75),
('TP5005', '25STPTAP', 3.00),
('TP5005', '15ISOVLV', 7.00),
('TP5005', '22ISOVLV', 5.00),
('TP5005', '15ISHVLV', 8.00),
('TP5005', '22SRVVLV', 10.00),
('TP5005', '22ISOVCH', 6.00),
('TP5005', '15CHKVLV', 4.00),
('TP5005', '15CHKVLD', 9.00),
('TP5005', '15STOPCK', 11.00),
('TP5005', '22STOPCK', 6.00),
('TP5005', '15GATVLV', 3.00),
('TP5005', '22GATVLV', 6.00),
('TP5005', '28GATVLV', 7.00),
('TP5005', '15FBLBVL', 5.00),
('TP5005', '22FBLBVL', 8.00),
('TP5005', '15DRNCCK', 9.00),
('TP5005', '15TRMMIX', 10.00),
('TP5005', '22TRMMIX', 9.00),
('TP5005', '15COELBO', 7.00),
('TP5005', '22COELBO', 7.00),
('TP5005', '28COELBO', 6.00),
('TP5005', '10COPTEE', 5.00),
('TP5005', '15COPTEE', 16.00),
('TP5005', '22COPTEE', 17.00),
('TP5005', '28COPTEE', 6.00),
('TP5005', '15FXTP30', 4.00),
('TP5005', '15FXTP90', 4.00),
('TP5005', '22FXTP20', 6.00),
('TP5005', 'CHCLEANR', 5.00),
('TP5005', 'CHINHIBT', 3.00),
('TP5005', 'CHLKSEAL', 3.00),
('TP5006', '15COPIPE', 19.00),
('TP5006', '22COPIPE', 16.00),
('TP5006', '10MICCOP', 7.50),
('TP5006', '25STPTAP', 4.00),
('TP5006', '15ISOVLV', 4.00),
('TP5006', '22ISOVLV', 3.00),
('TP5006', '15ISHVLV', 2.00),
('TP5006', '22SRVVLV', 5.00),
('TP5006', '22ISOVCH', 3.00),
('TP5006', '15CHKVLV', 2.00),
('TP5006', '15CHKVLD', 3.00),
('TP5006', '15STOPCK', 5.00),
('TP5006', '22STOPCK', 4.00),
('TP5006', '15GATVLV', 8.00),
('TP5006', '22GATVLV', 3.00),
('TP5006', '28GATVLV', 6.00),
('TP5006', '15FBLBVL', 4.00),
('TP5006', '22FBLBVL', 11.00),
('TP5006', '15DRNCCK', 2.00),
('TP5006', '15TRMMIX', 4.00),
('TP5006', '22TRMMIX', 6.00),
('TP5006', '15COELBO', 3.00),
('TP5006', '22COELBO', 8.00),
('TP5006', '28COELBO', 9.00),
('TP5006', '10COPTEE', 2.00),
('TP5006', '15COPTEE', 13.00),
('TP5006', '22COPTEE', 26.00),
('TP5006', '28COPTEE', 15.00),
('TP5006', '15FXTP30', 2.00),
('TP5006', '15FXTP90', 5.00),
('TP5006', '22FXTP20', 3.00),
('TP5006', 'CHCLEANR', 3.00),
('TP5006', 'CHINHIBT', 4.00),
('TP5006', 'CHLKSEAL', 6.00),
('TP5006', 'SHX5PUMP', 3.00),
('TP5006', 'PUMPVBAL', 5.00),
('TP5006', 'PUMPVGAT', 4.00),
('TP5006', 'SHTHERMO', 2.00),
('TP5006', 'SHDTHERM', 2.00),
('TP5006', 'SHFLUEKT', 3.00),
('TP5007', '15COPIPE', 8.00),
('TP5007', '22COPIPE', 10.00),
('TP5007', '10MICCOP', 5.75),
('TP5007', '25STPTAP', 2.00),
('TP5007', '15ISOVLV', 6.00),
('TP5007', '22ISOVLV', 4.00),
('TP5007', '15ISHVLV', 7.00),
('TP5007', '22SRVVLV', 9.00),
('TP5007', '22ISOVCH', 5.00),
('TP5007', '15CHKVLV', 3.00),
('TP5007', '15CHKVLD', 8.00),
('TP5007', '15STOPCK', 10.00),
('TP5007', '22STOPCK', 5.00),
('TP5007', '15GATVLV', 2.00),
('TP5007', '22GATVLV', 5.00),
('TP5007', '28GATVLV', 6.00),
('TP5007', '15FBLBVL', 4.00),
('TP5007', '22FBLBVL', 7.00),
('TP5007', '15DRNCCK', 8.00),
('TP5007', '15TRMMIX', 9.00),
('TP5007', '22TRMMIX', 8.00),
('TP5007', '15COELBO', 6.00),
('TP5007', '22COELBO', 6.00),
('TP5007', '28COELBO', 5.00),
('TP5007', '10COPTEE', 4.00),
('TP5007', '15COPTEE', 15.00),
('TP5007', '22COPTEE', 16.00),
('TP5007', '28COPTEE', 5.00),
('TP5007', '15FXTP30', 3.00),
('TP5007', '15FXTP90', 3.00),
('TP5007', '22FXTP20', 5.00),
('TP5007', 'CHCLEANR', 4.00),
('TP5007', 'CHINHIBT', 2.00),
('TP5007', 'CHLKSEAL', 2.00),
('TP5008', 'SLCONSUN', 4.00),
('TP5008', 'SLCU5WAY', 3.00),
('TP5008', 'SLCUSL12', 5.00),
('TP5009', '15COPIPE', 10.00),
('TP5009', '22COPIPE', 12.00),
('TP5009', '10MICCOP', 7.75),
('TP5009', '25STPTAP', 4.00),
('TP5009', '15ISOVLV', 8.00),
('TP5009', '22ISOVLV', 6.00),
('TP5009', '15ISHVLV', 9.00),
('TP5009', '22SRVVLV', 11.00),
('TP5009', '22ISOVCH', 7.00),
('TP5009', '15CHKVLV', 5.00),
('TP5009', '15CHKVLD', 10.00),
('TP5009', '15STOPCK', 12.00),
('TP5009', '22STOPCK', 7.00),
('TP5009', '15GATVLV', 4.00),
('TP5009', '22GATVLV', 7.00),
('TP5009', '28GATVLV', 8.00),
('TP5009', '15FBLBVL', 6.00),
('TP5009', '22FBLBVL', 9.00),
('TP5009', '15DRNCCK', 10.00),
('TP5009', '15TRMMIX', 11.00),
('TP5009', '22TRMMIX', 10.00),
('TP5009', '15COELBO', 8.00),
('TP5009', '22COELBO', 8.00),
('TP5009', '28COELBO', 7.00),
('TP5009', '10COPTEE', 6.00),
('TP5009', '15COPTEE', 17.00),
('TP5009', '22COPTEE', 18.00),
('TP5009', '28COPTEE', 7.00),
('TP5009', '15FXTP30', 5.00),
('TP5009', '15FXTP90', 5.00),
('TP5009', '22FXTP20', 7.00),
('TP5009', 'CHCLEANR', 6.00),
('TP5009', 'CHINHIBT', 4.00),
('TP5009', 'CHLKSEAL', 4.00),
('TP5010', '15COPIPE', 11.00),
('TP5010', '22COPIPE', 13.00),
('TP5010', '10MICCOP', 8.75),
('TP5010', '25STPTAP', 5.00),
('TP5010', '15ISOVLV', 9.00),
('TP5010', '22ISOVLV', 7.00),
('TP5010', '15ISHVLV', 10.00),
('TP5010', '22SRVVLV', 12.00),
('TP5010', '22ISOVCH', 8.00),
('TP5010', '15CHKVLV', 6.00),
('TP5010', '15CHKVLD', 11.00),
('TP5010', '15STOPCK', 13.00),
('TP5010', '22STOPCK', 8.00),
('TP5010', '15GATVLV', 5.00),
('TP5010', '22GATVLV', 8.00),
('TP5010', '28GATVLV', 9.00),
('TP5010', '15FBLBVL', 7.00),
('TP5010', '22FBLBVL', 10.00),
('TP5010', '15DRNCCK', 11.00),
('TP5010', '15TRMMIX', 12.00),
('TP5010', '22TRMMIX', 11.00),
('TP5010', '15COELBO', 9.00),
('TP5010', '22COELBO', 9.00),
('TP5010', '28COELBO', 8.00),
('TP5010', '10COPTEE', 7.00),
('TP5010', '15COPTEE', 18.00),
('TP5010', '22COPTEE', 19.00),
('TP5010', '28COPTEE', 8.00),
('TP5010', '15FXTP30', 6.00),
('TP5010', '15FXTP90', 6.00),
('TP5010', '22FXTP20', 8.00),
('TP5010', 'CHCLEANR', 7.00),
('TP5010', 'CHINHIBT', 5.00),
('TP5010', 'CHLKSEAL', 5.00),
('TP5011', '15COPIPE', 20.00),
('TP5011', '22COPIPE', 17.00),
('TP5011', '10MICCOP', 8.50),
('TP5011', '25STPTAP', 5.00),
('TP5011', '15ISOVLV', 5.00),
('TP5011', '22ISOVLV', 4.00),
('TP5011', '15ISHVLV', 3.00),
('TP5011', '22SRVVLV', 6.00),
('TP5011', '22ISOVCH', 4.00),
('TP5011', '15CHKVLV', 3.00),
('TP5011', '15CHKVLD', 4.00),
('TP5011', '15STOPCK', 6.00),
('TP5011', '22STOPCK', 5.00),
('TP5011', '15GATVLV', 9.00),
('TP5011', '22GATVLV', 4.00),
('TP5011', '28GATVLV', 7.00),
('TP5011', '15FBLBVL', 5.00),
('TP5011', '22FBLBVL', 12.00),
('TP5011', '15DRNCCK', 3.00),
('TP5011', '15TRMMIX', 5.00),
('TP5011', '22TRMMIX', 7.00),
('TP5011', '15COELBO', 4.00),
('TP5011', '22COELBO', 9.00),
('TP5011', '28COELBO', 10.00),
('TP5011', '10COPTEE', 3.00),
('TP5011', '15COPTEE', 14.00),
('TP5011', '22COPTEE', 27.00),
('TP5011', '28COPTEE', 16.00),
('TP5011', '15FXTP30', 3.00),
('TP5011', '15FXTP90', 6.00),
('TP5011', '22FXTP20', 4.00),
('TP5011', 'CHCLEANR', 4.00),
('TP5011', 'CHINHIBT', 5.00),
('TP5011', 'CHLKSEAL', 7.00),
('TP5011', 'SHX5PUMP', 4.00),
('TP5011', 'PUMPVBAL', 6.00),
('TP5011', 'PUMPVGAT', 5.00),
('TP5011', 'SHTHERMO', 3.00),
('TP5011', 'SHDTHERM', 3.00),
('TP5011', 'SHFLUEKT', 4.00),
('TP5012', 'SLCONSUN', 5.00),
('TP5012', 'SLCU5WAY', 4.00),
('TP5012', 'SLCUSL12', 6.00),
('TP5013', '15COPIPE', 21.00),
('TP5013', '22COPIPE', 18.00),
('TP5013', '10MICCOP', 9.50),
('TP5013', '25STPTAP', 6.00),
('TP5013', '15ISOVLV', 6.00),
('TP5013', '22ISOVLV', 5.00),
('TP5013', '15ISHVLV', 4.00),
('TP5013', '22SRVVLV', 7.00),
('TP5013', '22ISOVCH', 5.00),
('TP5013', '15CHKVLV', 4.00),
('TP5013', '15CHKVLD', 5.00),
('TP5013', '15STOPCK', 7.00),
('TP5013', '22STOPCK', 6.00),
('TP5013', '15GATVLV', 10.00),
('TP5013', '22GATVLV', 5.00),
('TP5013', '28GATVLV', 8.00),
('TP5013', '15FBLBVL', 6.00),
('TP5013', '22FBLBVL', 13.00),
('TP5013', '15DRNCCK', 4.00),
('TP5013', '15TRMMIX', 6.00),
('TP5013', '22TRMMIX', 8.00),
('TP5013', '15COELBO', 5.00),
('TP5013', '22COELBO', 10.00),
('TP5013', '28COELBO', 11.00),
('TP5013', '10COPTEE', 4.00),
('TP5013', '15COPTEE', 15.00),
('TP5013', '22COPTEE', 28.00),
('TP5013', '28COPTEE', 17.00),
('TP5013', '15FXTP30', 4.00),
('TP5013', '15FXTP90', 7.00),
('TP5013', '22FXTP20', 5.00),
('TP5013', 'CHCLEANR', 5.00),
('TP5013', 'CHINHIBT', 6.00),
('TP5013', 'CHLKSEAL', 8.00),
('TP5013', 'SHX5PUMP', 5.00),
('TP5013', 'PUMPVBAL', 7.00),
('TP5013', 'PUMPVGAT', 6.00),
('TP5013', 'SHTHERMO', 4.00),
('TP5013', 'SHDTHERM', 4.00),
('TP5013', 'SHFLUEKT', 5.00),
('TP5014', 'SLCONSUN', 6.00),
('TP5014', 'SLCU5WAY', 5.00),
('TP5014', 'SLCUSL12', 7.00),
('TP5015', 'SLCONSUN', 7.00),
('TP5015', 'SLCU5WAY', 6.00),
('TP5015', 'SLCUSL12', 8.00),
('TP5016', '15COPIPE', 11.00),
('TP5016', '22COPIPE', 13.00),
('TP5016', '10MICCOP', 8.75),
('TP5016', '25STPTAP', 5.00),
('TP5016', '15ISOVLV', 9.00),
('TP5016', '22ISOVLV', 7.00),
('TP5016', '15ISHVLV', 10.00),
('TP5016', '22SRVVLV', 12.00),
('TP5016', '22ISOVCH', 8.00),
('TP5016', '15CHKVLV', 6.00),
('TP5016', '15CHKVLD', 11.00),
('TP5016', '15STOPCK', 13.00),
('TP5016', '22STOPCK', 8.00),
('TP5016', '15GATVLV', 5.00),
('TP5016', '22GATVLV', 8.00),
('TP5016', '28GATVLV', 9.00),
('TP5016', '15FBLBVL', 7.00),
('TP5016', '22FBLBVL', 10.00),
('TP5016', '15DRNCCK', 11.00),
('TP5016', '15TRMMIX', 12.00),
('TP5016', '22TRMMIX', 11.00),
('TP5016', '15COELBO', 9.00),
('TP5016', '22COELBO', 9.00),
('TP5016', '28COELBO', 8.00),
('TP5016', '10COPTEE', 7.00),
('TP5016', '15COPTEE', 18.00),
('TP5016', '22COPTEE', 19.00),
('TP5016', '28COPTEE', 8.00),
('TP5016', '15FXTP30', 6.00),
('TP5016', '15FXTP90', 6.00),
('TP5016', '22FXTP20', 8.00),
('TP5016', 'CHCLEANR', 7.00),
('TP5016', 'CHINHIBT', 5.00),
('TP5016', 'CHLKSEAL', 5.00),
('TP5017', '15COPIPE', 22.00),
('TP5017', '22COPIPE', 19.00),
('TP5017', '10MICCOP', 10.50),
('TP5017', '25STPTAP', 7.00),
('TP5017', '15ISOVLV', 7.00),
('TP5017', '22ISOVLV', 6.00),
('TP5017', '15ISHVLV', 5.00),
('TP5017', '22SRVVLV', 8.00),
('TP5017', '22ISOVCH', 6.00),
('TP5017', '15CHKVLV', 5.00),
('TP5017', '15CHKVLD', 6.00),
('TP5017', '15STOPCK', 8.00),
('TP5017', '22STOPCK', 7.00),
('TP5017', '15GATVLV', 11.00),
('TP5017', '22GATVLV', 6.00),
('TP5017', '28GATVLV', 9.00),
('TP5017', '15FBLBVL', 7.00),
('TP5017', '22FBLBVL', 14.00),
('TP5017', '15DRNCCK', 5.00),
('TP5017', '15TRMMIX', 7.00),
('TP5017', '22TRMMIX', 9.00),
('TP5017', '15COELBO', 6.00),
('TP5017', '22COELBO', 11.00),
('TP5017', '28COELBO', 12.00),
('TP5017', '10COPTEE', 5.00),
('TP5017', '15COPTEE', 16.00),
('TP5017', '22COPTEE', 29.00),
('TP5017', '28COPTEE', 18.00),
('TP5017', '15FXTP30', 5.00),
('TP5017', '15FXTP90', 8.00),
('TP5017', '22FXTP20', 6.00),
('TP5017', 'CHCLEANR', 6.00),
('TP5017', 'CHINHIBT', 7.00),
('TP5017', 'CHLKSEAL', 9.00),
('TP5017', 'SHX5PUMP', 6.00),
('TP5017', 'PUMPVBAL', 8.00),
('TP5017', 'PUMPVGAT', 7.00),
('TP5017', 'SHTHERMO', 5.00),
('TP5017', 'SHDTHERM', 5.00),
('TP5017', 'SHFLUEKT', 6.00),
('TP5018', '15COPIPE', 12.00),
('TP5018', '22COPIPE', 14.00),
('TP5018', '10MICCOP', 9.75),
('TP5018', '25STPTAP', 6.00),
('TP5018', '15ISOVLV', 10.00),
('TP5018', '22ISOVLV', 8.00),
('TP5018', '15ISHVLV', 11.00),
('TP5018', '22SRVVLV', 13.00),
('TP5018', '22ISOVCH', 9.00),
('TP5018', '15CHKVLV', 7.00),
('TP5018', '15CHKVLD', 12.00),
('TP5018', '15STOPCK', 14.00),
('TP5018', '22STOPCK', 9.00),
('TP5018', '15GATVLV', 6.00),
('TP5018', '22GATVLV', 9.00),
('TP5018', '28GATVLV', 10.00),
('TP5018', '15FBLBVL', 8.00),
('TP5018', '22FBLBVL', 11.00),
('TP5018', '15DRNCCK', 12.00),
('TP5018', '15TRMMIX', 13.00),
('TP5018', '22TRMMIX', 12.00),
('TP5018', '15COELBO', 10.00),
('TP5018', '22COELBO', 10.00),
('TP5018', '28COELBO', 9.00),
('TP5018', '10COPTEE', 8.00),
('TP5018', '15COPTEE', 19.00),
('TP5018', '22COPTEE', 20.00),
('TP5018', '28COPTEE', 9.00),
('TP5018', '15FXTP30', 7.00),
('TP5018', '15FXTP90', 7.00),
('TP5018', '22FXTP20', 9.00),
('TP5018', 'CHCLEANR', 8.00),
('TP5018', 'CHINHIBT', 6.00),
('TP5018', 'CHLKSEAL', 6.00),
('TP5019', 'SLCONSUN', 8.00),
('TP5019', 'SLCU5WAY', 7.00),
('TP5019', 'SLCUSL12', 9.00),
('TP5020', '15COPIPE', 23.00),
('TP5020', '22COPIPE', 20.00),
('TP5020', '10MICCOP', 11.50),
('TP5020', '25STPTAP', 8.00),
('TP5020', '15ISOVLV', 8.00),
('TP5020', '22ISOVLV', 7.00),
('TP5020', '15ISHVLV', 6.00),
('TP5020', '22SRVVLV', 9.00),
('TP5020', '22ISOVCH', 7.00),
('TP5020', '15CHKVLV', 6.00),
('TP5020', '15CHKVLD', 7.00),
('TP5020', '15STOPCK', 9.00),
('TP5020', '22STOPCK', 8.00),
('TP5020', '15GATVLV', 12.00),
('TP5020', '22GATVLV', 7.00),
('TP5020', '28GATVLV', 10.00),
('TP5020', '15FBLBVL', 8.00),
('TP5020', '22FBLBVL', 15.00),
('TP5020', '15DRNCCK', 6.00),
('TP5020', '15TRMMIX', 8.00),
('TP5020', '22TRMMIX', 10.00),
('TP5020', '15COELBO', 7.00),
('TP5020', '22COELBO', 12.00),
('TP5020', '28COELBO', 13.00),
('TP5020', '10COPTEE', 6.00),
('TP5020', '15COPTEE', 17.00),
('TP5020', '22COPTEE', 30.00),
('TP5020', '28COPTEE', 19.00),
('TP5020', '15FXTP30', 6.00),
('TP5020', '15FXTP90', 9.00),
('TP5020', '22FXTP20', 7.00),
('TP5020', 'CHCLEANR', 7.00),
('TP5020', 'CHINHIBT', 8.00),
('TP5020', 'CHLKSEAL', 10.00),
('TP5020', 'SHX5PUMP', 7.00),
('TP5020', 'PUMPVBAL', 9.00),
('TP5020', 'PUMPVGAT', 8.00),
('TP5020', 'SHTHERMO', 6.00),
('TP5020', 'SHDTHERM', 6.00),
('TP5020', 'SHFLUEKT', 7.00),
('TP5021', 'SLCONSUN', 8.00),
('TP5021', 'SLCU5WAY', 7.00),
('TP5021', 'SLCUSL12', 9.00),
('TP5022', '15COPIPE', 24.00),
('TP5022', '22COPIPE', 21.00),
('TP5022', '10MICCOP', 12.50),
('TP5022', '25STPTAP', 9.00),
('TP5022', '15ISOVLV', 9.00),
('TP5022', '22ISOVLV', 8.00),
('TP5022', '15ISHVLV', 7.00),
('TP5022', '22SRVVLV', 10.00),
('TP5022', '22ISOVCH', 8.00),
('TP5022', '15CHKVLV', 7.00),
('TP5022', '15CHKVLD', 8.00),
('TP5022', '15STOPCK', 10.00),
('TP5022', '22STOPCK', 9.00),
('TP5022', '15GATVLV', 13.00),
('TP5022', '22GATVLV', 8.00),
('TP5022', '28GATVLV', 11.00),
('TP5022', '15FBLBVL', 9.00),
('TP5022', '22FBLBVL', 16.00),
('TP5022', '15DRNCCK', 7.00),
('TP5022', '15TRMMIX', 9.00),
('TP5022', '22TRMMIX', 11.00),
('TP5022', '15COELBO', 8.00),
('TP5022', '22COELBO', 13.00),
('TP5022', '28COELBO', 14.00),
('TP5022', '10COPTEE', 7.00),
('TP5022', '15COPTEE', 18.00),
('TP5022', '22COPTEE', 31.00),
('TP5022', '28COPTEE', 20.00),
('TP5022', '15FXTP30', 7.00),
('TP5022', '15FXTP90', 10.00),
('TP5022', '22FXTP20', 8.00),
('TP5022', 'CHCLEANR', 8.00),
('TP5022', 'CHINHIBT', 9.00),
('TP5022', 'CHLKSEAL', 11.00),
('TP5022', 'SHX5PUMP', 8.00),
('TP5022', 'PUMPVBAL', 10.00),
('TP5022', 'PUMPVGAT', 9.00),
('TP5022', 'SHTHERMO', 7.00),
('TP5022', 'SHDTHERM', 7.00),
('TP5022', 'SHFLUEKT', 8.00),
('TP5024', '15COPIPE', 25.00),
('TP5024', '22COPIPE', 22.00),
('TP5024', '10MICCOP', 13.50),
('TP5024', '25STPTAP', 10.00),
('TP5024', '15ISOVLV', 10.00),
('TP5024', '22ISOVLV', 9.00),
('TP5024', '15ISHVLV', 8.00),
('TP5024', '22SRVVLV', 11.00),
('TP5024', '22ISOVCH', 9.00),
('TP5024', '15CHKVLV', 8.00),
('TP5024', '15CHKVLD', 9.00),
('TP5024', '15STOPCK', 11.00),
('TP5024', '22STOPCK', 10.00),
('TP5024', '15GATVLV', 14.00),
('TP5024', '22GATVLV', 9.00),
('TP5024', '28GATVLV', 12.00),
('TP5024', '15FBLBVL', 10.00),
('TP5024', '22FBLBVL', 17.00),
('TP5024', '15DRNCCK', 8.00),
('TP5024', '15TRMMIX', 10.00),
('TP5024', '22TRMMIX', 12.00),
('TP5024', '15COELBO', 9.00),
('TP5024', '22COELBO', 14.00),
('TP5024', '28COELBO', 15.00),
('TP5024', '10COPTEE', 8.00),
('TP5024', '15COPTEE', 19.00),
('TP5024', '22COPTEE', 32.00),
('TP5024', '28COPTEE', 21.00),
('TP5024', '15FXTP30', 8.00),
('TP5024', '15FXTP90', 11.00),
('TP5024', '22FXTP20', 9.00),
('TP5024', 'CHCLEANR', 9.00),
('TP5024', 'CHINHIBT', 10.00),
('TP5024', 'CHLKSEAL', 12.00),
('TP5024', 'SHX5PUMP', 9.00),
('TP5024', 'PUMPVBAL', 11.00),
('TP5024', 'PUMPVGAT', 10.00),
('TP5024', 'SHTHERMO', 8.00),
('TP5024', 'SHDTHERM', 8.00),
('TP5024', 'SHFLUEKT', 9.00)



-- Create TradesPersonWorkingAreas data
INSERT INTO TradesPersonWorkingArea (TradesPersonNo, AreaCode) 
VALUES
('TP5001', 'AVO'),
('TP5002', 'BED'),
('TP5002', 'BUC'),
('TP5002', 'CEN'),
('TP5003', 'LEI'),
('TP5003', 'RUT'),
('TP5003', 'NOT'),
('TP5003', 'DER'),
('TP5004', 'NRF'),
('TP5005', 'HAM'),
('TP5005', 'BER'),
('TP5006', 'SUR'),
('TP5007', 'HUM'),
('TP5007', 'LIN'),
('TP5007', 'WYO'),
('TP5008', 'NYO'),
('TP5008', 'SYO'),
('TP5009', 'BOR'),
('TP5010', 'CAM'),
('TP5011', 'CEN'),
('TP5012', 'CHE'),
('TP5012', 'LAN'),
('TP5012', 'STA'),
('TP5012', 'SHR'),
('TP5013', 'DUR'),
('TP5013', 'NYO'),
('TP5013', 'CUM'),
('TP5014', 'ISL'),
('TP5015', 'ESS'),
('TP5015', 'SUF'),
('TP5015', 'CEN'),
('TP5015', 'HRT'),
('TP5015', 'CAM'),
('TP5016', 'DEV'),
('TP5016', 'COR'),
('TP5016', 'DOR'),
('TP5016', 'SOM'),
('TP5017', 'WIL'),
('TP5017', 'DOR'),
('TP5017', 'SOM'),
('TP5017', 'GLO'),
('TP5018', 'HER'),
('TP5018', 'SHR'),
('TP5018', 'WOR'),
('TP5018', 'GLO'),
('TP5019', 'NHM'),
('TP5019', 'NYO'),
('TP5019', 'DUR'),
('TP5020', 'WMI'),
('TP5021', 'EAS'),
('TP5021', 'WSU'),
('TP5021', 'SUR'),
('TP5021', 'KEN'),
('TP5021', 'CEN'),
('TP5022', 'NRT'),
('TP5022', 'OXF'),
('TP5022', 'WAR'),
('TP5022', 'LEI'),
('TP5023', 'LEI'),
('TP5024', 'WAL'),
('TP5025', 'NSC'),
('TP5025', 'SSC')



-- Create Complaints data
INSERT INTO CustomerComplaints VALUES
('CU900005', 'TP5001', '2007-09-01 14:00:23', 'Customer has received an incorrect charge on their direct debit account.'),
('CU900006', 'TP5008', '2007-09-02 09:43:30', 'Customer does not wish to receive direct marketing information.'),
('CU900001', 'TP5004', '2008-03-02 14:00:23', 'TradesPerson did not have appropriate Part and was rude.')

