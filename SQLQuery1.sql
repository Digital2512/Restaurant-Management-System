
ALTER TABLE Reservation
ALTER COLUMN Duration FLOAT;

INSERT INTO [User] (UserID, Role, FullName, Gender, Birthday) VALUES ('A003', 'Customer', 'Christine', 'Female', '1999-09-09');
INSERT INTO [Customer] (CustomerID, UserID) VALUES ('C002', 'A003');

INSERT INTO [User] (UserID, Role, FullName, Gender, Birthday) VALUES ('A004', 'Customer', 'Jeff', 'Male', '1999-09-09');
INSERT INTO [Customer] (CustomerID, UserID) VALUES ('C003', 'A004');

INSERT INTO [User] (UserID, Role, FullName, Gender, Birthday) VALUES ('A005', 'Customer', 'Mike', 'Male', '1999-09-09');
INSERT INTO [Customer] (CustomerID, UserID) VALUES ('C004', 'A005');

INSERT INTO [User] (UserID, Role, FullName, Gender, Birthday) VALUES ('A006', 'Customer', 'Adam', 'Male', '1999-09-09');
INSERT INTO [Customer] (CustomerID, UserID) VALUES ('C005', 'A006');

INSERT INTO [User] (UserID, Role, FullName, Gender, Birthday) VALUES ('A007', 'Customer', 'Lauv', 'Male', '1999-09-09');
INSERT INTO [Customer] (CustomerID, UserID) VALUES ('C006', 'A007');

ALTER TABLE Reservation
ADD ReservationStatus nvarchar(50);

EXEC sp_rename 'PlaceOfReservation.[Name]',  'PlaceName', 'COLUMN';

INSERT INTO [User] (UserID, Role, FullName, Gender, Birthday) VALUES ('A008', 'Customer', 'Justin', 'Male', '1999-09-09');
INSERT INTO [Customer] (CustomerID, UserID) VALUES ('C007', 'A008');

INSERT INTO [User] (UserID, Role, FullName, Gender, Birthday) VALUES ('A009', 'Customer', 'Jay', 'Male', '1999-09-09');
INSERT INTO [Customer] (CustomerID, UserID) VALUES ('C008', 'A009');

-- Rename a table 
EXEC sp_rename 'User', 'Users';

INSERT INTO [Users] (UserID, Role, FullName, Gender, Birthday) VALUES ('A010', 'Manager', 'Ryan', 'Male', '1999-09-09');
INSERT INTO [Users] (UserID, Role, FullName, Gender, Birthday,Loggedin) VALUES ('A011', 'Manager', 'Felix', 'Male', '1999-09-09','TRUE');

EXEC sp_rename 'Users.[Profilelmage]',  'ProductImage', 'COLUMN';
EXEC sp_rename 'Users.[ProductImage]',  'ProfileImage', 'COLUMN';

EXEC sp_rename 'Order', 'Orders';
ALTER TABLE Orders
ADD Tax decimal(10,2);

ALTER TABLE Orders
ADD CustomerID nvarchar(50);

ALTER TABLE Orders
ADD CONSTRAINT FK_CustomerID FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID);

INSERT INTO [Orders] (OrderID, Tax, CustomerID) VALUES ('B001','20', 'C008');
INSERT INTO [Orders] (OrderID, Tax, CustomerID) VALUES ('B002','20', 'C006');

SELECT R.ReservationID, R.PlaceID, R.CustomerID, R.CustomerPax, R.ReservedDateTime, R.Duration, POR.EventType, O.Tax AS 'TotalPrice' FROM Reservation 
AS R JOIN PlaceOfReservation AS POR ON R.PlaceID = POR.PlaceID JOIN Orders AS O ON R.CustomerID = O.CustomerID;

INSERT INTO [Orders] (OrderID, Tax, CustomerID) VALUES ('B003','50', 'C005');

INSERT INTO Reservation(ReservationID, PlaceID, CustomerID, PlaceName, CustomerPax, ReservedDateTime, Duration, ReservationStatus) VALUES ('RSV011','T02','C007', 'Table 2', '5','2024-05-28 17:00:00','60','Pending');

UPDATE Users
SET Loggedin = 'TRUE'
WHERE FullName = 'Ryan';

Create Table Recipe (
    ProductID nvarchar(50) FOREIGN KEY REFERENCES Menu(ProductID),
    RecipeID nvarchar(50) PRIMARY KEY,
    Stock int);

/*ALTER TABLE Menu
ADD CONSTRAINT FK_RecipeID FOREIGN KEY (RecipeID) REFERENCES Recipe(RecipeID);*/

ALTER TABLE Menu
ADD RecipeID nvarchar(50) FOREIGN KEY REFERENCES Recipe(RecipeID);

UPDATE Reservation SET ReservationStatus = 'PENDING' WHERE ReservationID = 'RSV005';

ALTER TABLE PlaceOfReservation
DROP constraint FK__PlaceOfRe__Reser__32E0915F;

UPDATE PlaceOfReservation SET ReservationID = 'RSV001' WHERE ReservationID = 'RSV005, RSV006';

INSERT INTO Reservation(ReservationID, PlaceID, CustomerID, PlaceName, CustomerPax, ReservedDateTime, Duration, ReservationStatus) VALUES ('RSV011','T02','C007', 'Table 2', '5','2024-06-01 17:00:00','1','Pending');
INSERT INTO Reservation(ReservationID, PlaceID, CustomerID, PlaceName, CustomerPax, ReservedDateTime, Duration, ReservationStatus) VALUES ('RSV012','T03','C007', 'Table 3', '5','2024-05-31 17:00:00','1','Pending');
INSERT INTO Reservation(ReservationID, PlaceID, CustomerID, PlaceName, CustomerPax, ReservedDateTime, Duration, ReservationStatus) VALUES ('RSV015','T01','C007', 'Table 1', '1','2024-05-31 17:00:00','1','Pending');
INSERT INTO Reservation(ReservationID, PlaceID, CustomerID, PlaceName, CustomerPax, ReservedDateTime, Duration, ReservationStatus) VALUES ('RSV013','T01','C007', 'Table 1', '1','2024-06-01 17:00:00','1','Pending');
INSERT INTO Reservation(ReservationID, PlaceID, CustomerID, PlaceName, CustomerPax, ReservedDateTime, Duration, ReservationStatus) VALUES ('RSV016','T01','C007', 'Table 1', '1','2024-05-31 19:00:00','1','Pending');

UPDATE PlaceOfReservation SET ReservationID = ',RSV003' WHERE ReservationID = ',RSV001,RSV003';
UPDATE PlaceOfReservation SET ReservationID = ',RSV001' WHERE PlaceID = 'T02';

UPDATE PlaceOfReservation SET ReservationID = NULL WHERE ReservationID IS NOT NULL;

DELETE FROM Reservation WHERE ReservationStatus='APPROVED';

UPDATE Customer SET ReservationID = NULL WHERE ReservationID = 'RSV010';

UPDATE Customer SET ReservationID = NULL WHERE CustomerID = 'C005';

UPDATE Customer SET ReservationID = NULL WHERE CustomerID IS NOT NULL;

CREATE TABLE PlaceAvailability (
    PlaceID NVARCHAR(50) NOT NULL,
    PlaceTime INT NOT NULL,
    TimeStatus NVARCHAR(50) DEFAULT 'AVAILABLE' NOT NULL
);

INSERT INTO PlaceAvailability (PlaceID, PlaceTime, TimeStatus) VALUES
('T01', 1700, 'AVAILABLE'),
('T01', 1800, 'AVAILABLE'),
('T01', 1900, 'AVAILABLE'),
('T01', 2000, 'AVAILABLE'),
('T01', 2100, 'AVAILABLE'),
('T01', 2200, 'AVAILABLE'),
('T02', 1700, 'AVAILABLE'),
('T02', 1800, 'AVAILABLE'),
('T02', 1900, 'AVAILABLE'),
('T02', 2000, 'AVAILABLE'),
('T02', 2100, 'AVAILABLE'),
('T02', 2200, 'AVAILABLE'),
('T03', 1700, 'AVAILABLE'),
('T03', 1800, 'AVAILABLE'),
('T03', 1900, 'AVAILABLE'),
('T03', 2000, 'AVAILABLE'),
('T03', 2100, 'AVAILABLE'),
('T03', 2200, 'AVAILABLE'),
('T04', 1700, 'AVAILABLE'),
('T04', 1800, 'AVAILABLE'),
('T04', 1900, 'AVAILABLE'),
('T04', 2000, 'AVAILABLE'),
('T04', 2100, 'AVAILABLE'),
('T04', 2200, 'AVAILABLE'),
('T05', 1700, 'AVAILABLE'),
('T05', 1800, 'AVAILABLE'),
('T05', 1900, 'AVAILABLE'),
('T05', 2000, 'AVAILABLE'),
('T05', 2100, 'AVAILABLE'),
('T05', 2200, 'AVAILABLE'),
('T06', 1700, 'AVAILABLE'),
('T06', 1800, 'AVAILABLE'),
('T06', 1900, 'AVAILABLE'),
('T06', 2000, 'AVAILABLE'),
('T06', 2100, 'AVAILABLE'),
('T06', 2200, 'AVAILABLE'),
('T07', 1700, 'AVAILABLE'),
('T07', 1800, 'AVAILABLE'),
('T07', 1900, 'AVAILABLE'),
('T07', 2000, 'AVAILABLE'),
('T07', 2100, 'AVAILABLE'),
('T07', 2200, 'AVAILABLE'),
('T08', 1700, 'AVAILABLE'),
('T08', 1800, 'AVAILABLE'),
('T08', 1900, 'AVAILABLE'),
('T08', 2000, 'AVAILABLE'),
('T08', 2100, 'AVAILABLE'),
('T08', 2200, 'AVAILABLE'),
('T09', 1700, 'AVAILABLE'),
('T09', 1800, 'AVAILABLE'),
('T09', 1900, 'AVAILABLE'),
('T09', 2000, 'AVAILABLE'),
('T09', 2100, 'AVAILABLE'),
('T09', 2200, 'AVAILABLE'),
('T10', 1700, 'AVAILABLE'),
('T10', 1800, 'AVAILABLE'),
('T10', 1900, 'AVAILABLE'),
('T10', 2000, 'AVAILABLE'),
('T10', 2100, 'AVAILABLE'),
('T10', 2200, 'AVAILABLE'),
('VIP01', 1700, 'AVAILABLE'),
('VIP01', 1800, 'AVAILABLE'),
('VIP01', 1900, 'AVAILABLE'),
('VIP01', 2000, 'AVAILABLE'),
('VIP01', 2100, 'AVAILABLE'),
('VIP01', 2200, 'AVAILABLE'),
('VIP02', 1700, 'AVAILABLE'),
('VIP02', 1800, 'AVAILABLE'),
('VIP02', 1900, 'AVAILABLE'),
('VIP02', 2000, 'AVAILABLE'),
('VIP02', 2100, 'AVAILABLE'),
('VIP02', 2200, 'AVAILABLE');
