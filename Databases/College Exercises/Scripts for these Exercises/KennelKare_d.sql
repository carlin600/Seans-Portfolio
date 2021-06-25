create database KennelKare    
--go


use KennelKare
go



if OBJECT_ID ('payment') is not null
	drop table payment
go

if OBJECT_ID ('bookingDetail') is not null
	drop table booking
go

if OBJECT_ID ('booking') is not null
	drop table booking
go

if OBJECT_ID ('kennel') is not null
	drop table kennel
go

if OBJECT_ID ('dog') is not null
	drop table dog
go
 
if OBJECT_ID ('customer') is not null
	drop table customer
go

if OBJECT_ID ('breed') is not null
	drop table breed
go


if OBJECT_ID ('method') is not null
	drop table method
go

if OBJECT_ID ('size') is not null
	drop table size
go


create table Method 
(
	MethodNo		int identity(1,1)	not null,
	MethodDesc		varchar(10)		not null,
	
	constraint pkMethodNo primary key (MethodNo),
	constraint unqMethodDesc unique (MethodDesc)
)
go


create table Size 
(
	SizeNo		int 		not null,
	ChargePerDay	money		not null,	

	constraint pkSize primary key (SizeNo),
	constraint chkSizeCharge check (ChargePerDay between 2.50 and 10.00)
)
go


create table Kennel 
(
	KennelNo		int identity(1,1)	not null,
	SizeK			int			not null,
	
	constraint pkKennelNo primary key (KennelNo),
	constraint fkKennelSize	foreign key (SizeK) references Size (SizeNo)
)
go


create table Breed 
(
	BreedNo			int  identity(100,1)	not null,
	BreedName			varchar(50)			not null,
	SizeB				int 				not null,

	constraint pkBreedNo primary key (BreedNo),
	constraint unqBreedName unique (BreedName),
	constraint fkBreedSize	foreign key (SizeB) references Size (SizeNo)
)
go	

create table Customer
(
	CustomerNo		int	identity(1000,1)	not null,
	Title			varchar(4)			not null,
	Surname			varchar(20)			not null,
	Forename		varchar(20)			not null,
	Street			varchar(30)			not null,
	Town			varchar(30)			null,
	County			varchar(30)			null,
	PostCode		varchar(8)			null,
	TelNo			varchar(14)			null,
	
	constraint pkCustNo primary key (CustomerNo),

	constraint chkTitle check (Title in('MR','MRS','MISS','Ms'))
	
)
go

create table Dog
(
	DogNo		int	identity(200,1)	not null,
	Name		varchar(15)			not null,
	BreedNo		int				not null,
	DOB		date				not null,
	Gender		char				not null,
	Colour		varchar(20)			not null,
	CustomerNo	int				not null,

	
	constraint pkDogNo primary key (DogNo),
	constraint fkBreedNo foreign key(BreedNo) references Breed(BreedNo),

	constraint chkDOB check (DOB >= dateAdd(Year, -17, getDate())and DOB < getDate()),
	constraint chkGender check(Gender in('M','F')),
	constraint fkcustomerNo	foreign key (CustomerNo) references Customer(CustomerNo)
)

go


create table Booking 
(
	BookingNo		int	identity(10000,1)	not null,
	CustomerNo		int					not null,
	DateBooked		datetime			not null,
	DateStart		datetime			not null,
	NoDays			int				not null,
	
	constraint pkBookingNo primary key (BookingNo),
	constraint fkCustomerNo2 foreign key (CustomerNo) references Customer (CustomerNo),

	constraint chkDOB2 check (DateStart >= DateBooked )
)
go

create table BookingDetail 
(
	BookingNo		int	 			not null,
	DogNo			int				not null,
	KennelNo		int				not null,

	constraint pkBookingDet primary key (BookingNo, DogNo),
	constraint fkBookingNo foreign key (BookingNo) references Booking (BookingNo),
	constraint fkDogNo foreign key (DogNo) references Dog (DogNo),
	constraint fkKennelNo foreign key (KennelNo) references Kennel (KennelNo),
)
go


create table Payment 
(
	PaymentNo		int	identity(1,1)	not null,
	BookingNo		int				not null,
	MethodNo		int				not null,
	Amount			money				not null,
	DatePaid		date				not null,
	
	
	constraint pkPaymentNo primary key (PaymentNo),
	constraint fkBookingNo2 foreign key (BookingNo) references Booking (BookingNo),
	constraint fkMethodNo foreign key (MethodNo) references Method (MethodNo),
)

go



 --populating customer table
insert into customer (title, surname, forename, street, town, county, postCode, telNo) values 
('Mr', 'Morrison', 'Brenden', '159 Main Street','Eglinton','Co Derry','BT47 4TB', '02871261548'),   
('Miss', 'Rankin', 'Kathy', '56 Greenhaven','Drumahoe','Co Derry','BT48 3SY', '02871346562'),  
('Mr', 'Carlin', 'Patrick', '98 Larch Road','Greysteel','Co Derry','BT47 4TB', '02871249876'), 
('Mr', 'Cunning', 'Tom', '115 NewLine Road','Newbuildings','Co Derry','BT47 4TB', '02871375921'), 
('Mr', 'Wilson', 'Robert', '45 Hollyfoot Hill','Ballykelly','Co Derry','BT47 4TB', '07561020748'), 
('Mr', 'Lynch', 'Conan', '126 Dungiven Road','Derry','Co Derry','BT47 4TB', '02871361782'),
('Mrs', 'Collins', 'Joanne', '62 Limavady Road','Derry','Co Derry','BT47 4TB', '02871267183'),
('Mr', 'Gallagher', 'Adam', '76 Church Brae','Derry','Co Derry','BT47 4TB', '02871348527'),
('Mrs', 'Costello', 'Niamh', '34 Strand Road','Derry','Co Derry','BT47 4TB', '07865255486'), 
('Mr', 'Doherty', 'Kevin', '624 Glenshane Road','Claudy','Co Derry','BT47 4TB', '07759631458'),
('Miss', 'Heaney', 'Amanda', '22 Dungiven Road','Limavady','Co Derry','BT47 4TB', '07566584748'), 
('Mr', 'Evans', 'Rory', '70 Rosewood Avenue','Derry','Co Derry','BT47 4TB', '02871346582'),
('Mr', 'Coyle', 'Stephen', '32 Culmore Road','Derry','Co Derry','BT47 4TB', '07756914238'), 
('Mr', 'Murray', 'Mark', '4b Enfield Street','Derry','Co Derry','BT47 4TB', '07925688149'), 
('Mr', 'Donaghy', 'Martin', '582 Duncrun Road','Limavady','Co Derry','BT47 4TB', '02877741596'), 
('Miss', 'Jenkins', 'Hannah', '94 Carrickbeg Avenue','Eglinton','Co Derry','BT47 4TB', '02871362894'), 
('Mrs', 'Matthews', 'Louise', '241 Clagan Road','Claudy','Co Derry','BT47 4TB', '07774698315'), 
('Miss', 'Cartin', 'Charlene', '200 Rallagh Road','Dungiven','Co Derry','BT47 4TB', '07892579143'), 
('Mr', 'Holmes', 'Kieran', '34 Spencer Road','Waterside','Co Derry','BT47 4TB', '07985020748') 

select * from customer

 --populating size table
insert into size (sizeNo, chargePerDay) values 
(1, 5.00),   
(2, 6.50),  
(3, 8.00), 
(4, 10.00)

select * from size

 --populating breed table
insert into breed (breedName, sizeB) values 
('Labrador', 3),   
('Alaskan Malamute', 3),  
('St Bernard', 4), 
('Poodle', 1), 
('Border Collie', 2), 
('Shih Tzu', 1),
('Alsatian', 3),
('Bulldog', 2),
('German Shepherd', 3), 
('Jack Russell', 1),
('Boxer', 2),
('Pug', 1)

select * from breed

 --populating dog table
insert into dog (name, breedNo, dob, gender, colour, customerNo) values 
('Akira', 101, '20100815', 'F','Black & White', 1000),   
('Aurora', 101, '20140321', 'F','Grey',1000),  
('Mischa', 105, '20100214', 'F','White',1000), 
('Charlie', 110, '20110913', 'M','Brown',1002), 
('Diesel', 108, '20120630', 'M','Brown & Black',1002), 
('Fluffy', 103, '20130311', 'F','White',1001),
('Max', 104, '20140815', 'M','Black',1004),
('Bob', 104, '20140815', 'M','Black',1004),
('Storm', 107, '20121107', 'M','White',1003), 
('Darcy', 100, '20080422', 'F','Golden',1005),
('Roxy', 110, '20110505', 'F','Tan',1006), 
('Ayras', 109, '20060327', 'F','Brown & White',1007),
('King', 106, '20111209', 'M','Brown & Black',1008), 
('Duke', 102, '20120113', 'M','Tan & White',1009), 
('Diego', 111, '20131118', 'M','White',1009),
('Milo', 101, '20100815', 'M','Black & White', 1000)

select * from dog


 --populating kennel table
insert into kennel (sizeK) values 
(3),   
(3),  
(3), 
(4), 
(2), 
(2),
(1),
(3),
(4)

select * from kennel



 --populating booking
insert into booking(customerNo, dateBooked, dateStart, noDays) values 
(1000, '20141017', '20141022', 4),   
(1009, '20141020', '20141025', 2),  
(1004, '20141104', '20141111', 7), 
(1001, '20141116', '20141201', 3), 
(1000, '20141117', '20141122', 4), 
(1008, '20141208', '20141214', 2),
(1003, '20141210', '20141211', 3),
(1005, '20150108', '20150113', 7),
(1000, '20150117', '20150122', 4),
(1001, '20150210', '20150222', 4)

select * from booking




 --populating bookingDetail
insert into bookingDetail(bookingNo, dogNo, kennelNo) values 
(10000, 200, 1),   
(10000, 201, 2),  
(10001, 213, 4), 
(10002, 206, 5), 
(10002, 207, 6), 
(10003, 204, 7),
(10004, 200, 1),
(10004, 201, 2),
(10005, 212, 1),
(10006, 210, 5),
(10007, 209, 8),
(10008, 200, 3),
(10008, 201, 8),
(10009, 204, 7)


select * from bookingDetail


	
	
