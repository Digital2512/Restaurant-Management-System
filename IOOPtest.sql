Create database IOOPtest;

use IOOPtest;



create table Reservation(
ReservationID nvarchar(50) PRIMARY KEY);

create table Customer(
CustomerID nvarchar(50) PRIMARY KEY,
ReservationID nvarchar(50) FOREIGN KEY REFERENCES Reservation(ReservationID));

create table PlaceOfReservation(
PlaceID nvarchar(50) PRIMARY KEY, 
ReservationID nvarchar(50) FOREIGN KEY REFERENCES Reservation(ReservationID));

ALTER TABLE Reservation
ADD CustomerID nvarchar(50) FOREIGN KEY REFERENCES Customer(CustomerID),
PlaceID nvarchar(50) FOREIGN KEY REFERENCES PlaceOfReservation(PlaceID);

INSERT INTO PlaceOfReservation (PlaceID) Values ('T01');
INSERT INTO PlaceOfReservation (PlaceID) Values ('T02');
INSERT INTO PlaceOfReservation (PlaceID) Values ('T03');
INSERT INTO PlaceOfReservation (PlaceID) Values ('T04');

INSERT INTO Customer (CustomerID) Values ('C01');
INSERT INTO Customer (CustomerID) Values ('C02');
INSERT INTO Customer (CustomerID) Values ('C03');
INSERT INTO Customer (CustomerID) Values ('C04');