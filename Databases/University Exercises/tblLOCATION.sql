CREATE TABLE cis24609650.LOCATION
(
LocationID			CHAR(10)		NOT NULL,
LocationInfo		CHAR(50)		NOT NULL,
LSOACode			CHAR(10)		NOT NULL,
LSOAName			CHAR(30)		NOT NULL,
Longitude			DECIMAL(9,6)	NOT NULL,
Latitude			DECIMAL(8,6)	NOT NULL,

PRIMARY KEY(LocationID)
)

DROP TABLE cis24609650.LOCATION

INSERT INTO cis24609650.LOCATION(LocationID,LocationInfo,LSOACode,LSOAName,Longitude,Latitude) VALUES
('LOC1000001','On or near Longbridge Road',	'E01000009','Barking and Dagenham 016B',	0.084145,	51.541333),
('LOC1000002','On or near Stone Hill Drive',	'E01012608','Wyre 004G',					-2.465978,	53.767257),
('LOC1000003','On or near Kelsall Avenue',	'E01012609','West Lancashire 005C',			-2.464039,	53.766168),
('LOC1000004','On or near Fountains Avenue',	'E01012608','South Ribble 003A',			-2.462042,	53.762509),
('LOC1000005','On or near Tintern Crescent',	'E01013807','South Lakeland 004C',			-2.465978,	53.767257),
('LOC1000006','On or near Hazelwood Close',	'E01013805','South Cambridgeshire 002D',	-2.461766,	53.762222),
('LOC1000007','On or near Sunny Bower Road',	'E01013601','Rossendale 010A',				-2.465978,	53.767257),
('LOC1000008','On or near Philips Road',		'E01014903','Fylde 008F',					-2.46275,	53.763441),
('LOC1000009','On or near Challenge Way',	'E01014502','Hyndburn 001A',				-2.46309,	53.768149),
('LOC1000010','On or near Peridot Close',	'E01014206','Lancaster 011D',				-2.46309,	53.768149)


