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
	ReservationID nvarchar(50),
    PlaceID nvarchar(50),
	CustomerID nvarchar(50),
    EventType nvarchar(50),
    Price decimal(10,2),
    ReservedDateTime datetime
);

INSERT INTO ReservationReport(ReservationReportID, ReservationID, PlaceID, CustomerID, EventType, Price, ReservedDateTime)
VALUES ('RR001', 'RSV001', 'T001', 'C001', 'Dining', '65','2024-5-16 14:30:00');

ALTER TABLE Reservation
ADD Duration INT;