select * from Reservation
select * from Customer;
select * from PlaceOfReservation;
update Customer set ReservationID = NULL;
update PlaceOfReservation set ReservationID = NULL;
delete from Reservation;

ALTER TABLE Reservation
ADD StartTime int;

ALTER TABLE Reservation
ADD EndTime int;

EXEC sp_rename 'Reservation.ReservedDateTime',  'ReservedDate', 'COLUMN';

select * from Reservation;

update Customer set ReservationID = NULL WHERE ReservationID = 'RSV005';
delete from Reservation WHERE ReservationID = 'RSV004';
INSERT INTO Reservation(ReservationID, PlaceID, CustomerID, PlaceName, CustomerPax, ReservedDateTime, Duration, ReservationStatus) VALUES ('RSV005','T10','C005', 'Table 10', '7','2024-05-31 17:00:00','1','APPROVED');
UPDATE Customer SET ReservationID = 'RSV005' WHERE CustomerID = 'C005';
UPDATE PlaceOfReservation SET ReservationID = ',RSV005' WHERE PlaceID = 'T10';

UPDATE Reservation SET CustomerPax = '7' WHERE CustomerID = 'C004';

UPDATE PlaceAvailability SET TimeStatus = 'AVAILABLE';

INSERT INTO Reservation(ReservationID, PlaceID, CustomerID, PlaceName, CustomerPax, ReservedDate, Duration, StartTime, EndTime, ReservationStatus) VALUES ('RSV005','T10','C005', 'Table 10', '7','2024-06-03','1', '1700', '1800', 'PENDING');

UPDATE Users SET Loggedin = 'TRUE' WHERE UserID = 'A010';

ALTER TABLE Recipe
DROP CONSTRAINT FK_Recipe_Productl_4AB81AFO;

ALTER TABLE Menu
DROP CONSTRAINT FK__Menu__RecipeID__4BAC3F29;

ALTER TABLE Menu
DROP COLUMN RecipeID;

ALTER TABLE Recipe
DROP CONSTRAINT PK__Recipe__FDD988D0B317F444;

