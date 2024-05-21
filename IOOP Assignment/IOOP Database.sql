SELECT TOP (1000) [PlaceID]
      ,[Description]
      ,[MinOfPax]
      ,[EventType]
      ,[ReservationID]
      ,[CustomerID]
  FROM [IOOPDatabase].[dbo].[PlaceOfReservation]

CREATE TABLE ReservationReport (
    ReservationReportID nvarchar(50) NOT NULL PRIMARY KEY,
	ReservationID nvarchar(50) FOREIGN KEY REFERENCES Reservation(ReservationID),
    PlaceID nvarchar(50) FOREIGN KEY REFERENCES PlaceOfReservation(PlaceID),
	CustomerID nvarchar(50) FOREIGN KEY REFERENCES Customer(CustomerID),
    EventType nvarchar(50),
    Price decimal(10,2),
    ReservedDateTime datetime
);

--[ReservationID, CustomerID, PlaceID, PlaceName, PlaceMinOfPax,ReservedDateTime,ReservationStatus)

--INSERT INTO ReservationReport(ReservationReportID, ReservationID, PlaceID, CustomerID, EventType, Price, ReservedDateTime)
--VALUES ('RR001', 'RSV001', 'T001', 'C001', 'Dining', '65','2024-5-16');//

DROP Table ReservationReport

CREATE TABLE ReservationReport (
    ReservationReportID nvarchar(50) NOT NULL PRIMARY KEY,
	ReservationID nvarchar(50) FOREIGN KEY REFERENCES Reservation(ReservationID),
    PlaceID nvarchar(50) FOREIGN KEY REFERENCES PlaceOfReservation(PlaceID),
	CustomerID nvarchar(50) FOREIGN KEY REFERENCES Customer(CustomerID), 
    EventType nvarchar(50),
	CustomerPax int,
    ReservedDateTime datetime,
	Duration time,
	TotalPrice decimal(10,2));

INSERT INTO ReservationReport(ReservationReportID, ReservationID, PlaceID, CustomerID, EventType, Price, ReservedDateTime)
VALUES ('RR001', 'RSV001', 'T001', 'C001', 'Dining', '65','2024-5-16 14:30:00');

ALTER TABLE Reservation
ADD Duration INT;

DROP Table ReservationReport

CREATE TABLE ReservationReport (
    ReservationReportID nvarchar(50) NOT NULL PRIMARY KEY,
	ReservationID nvarchar(50) FOREIGN KEY REFERENCES Reservation(ReservationID),
    PlaceID nvarchar(50) FOREIGN KEY REFERENCES PlaceOfReservation(PlaceID),
	CustomerID nvarchar(50) FOREIGN KEY REFERENCES Customer(CustomerID), 
    EventType nvarchar(50),
	CustomerPax int,
    ReservedDateTime datetime,
	Duration time,
	TotalPrice decimal(10,2));

EXEC sp_rename 'Reservation.PlaceMinOfPax',  'CustomerPax', 'COLUMN';

ALTER TABLE Reservation
ALTER COLUMN CustomerPax int;

ALTER TABLE Reservation
ALTER COLUMN Duration int;

ALTER TABLE Reservation
DROP COLUMN CustomerPax;

ALTER TABLE Reservation
ADD CustomerPax int;

ALTER TABLE Reservation
DROP COLUMN CustomerPax;

ALTER TABLE [Reservation] ADD [CustomerPax] int;

EXEC sp_rename 'Reservation', 'reservation';

EXEC sp_rename 'reservation.ReservationID',  'reservationID', 'COLUMN';

CREATE TABLE Reservation(
    ReservationID nvarchar(50) NOT NULL PRIMARY KEY,
    PlaceID nvarchar(50) FOREIGN KEY REFERENCES PlaceOfReservation(PlaceID),
	CustomerID nvarchar(50) FOREIGN KEY REFERENCES Customer(CustomerID), 
    PlaceName nvarchar(200),
	CustomerPax int,
    ReservedDateTime datetime,
	Duration time,
	PlaceSpecialInstructions nvarchar(500));