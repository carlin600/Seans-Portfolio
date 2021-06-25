USE InTheDogHouse

CREATE VIEW CustomerBooking
AS
SELECT c.CustomerNo, c.Title, c.Forename, c.Surname,
b.BookingNo, b.DateBooked, b.DateStart, b.NoDays,s.ChargePerDay, (b.NoDays * s.ChargePerDay) AS 'Total Charge',
bd.DogNo,br.BreedName, d.Name, bd.KennelNo

FROM Customer c

JOIN Booking b ON c.CustomerNo = b.CustomerNo
JOIN BookingDetail bd ON b.BookingNo = bd.BookingNo
JOIN Dog d ON bd.DogNo = d.DogNo
JOIN Breed br ON br.BreedNo = d.BreedNo
JOIN Size s ON br.SizeB = s.SizeNo