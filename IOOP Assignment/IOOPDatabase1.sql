-- Create a new database named 'IOOPDatabase'
CREATE DATABASE IOOPDatabase1;

-- Use the newly created database
USE IOOPDatabase1;

CREATE TABLE [User](
    UserID nvarchar(50) NOT NULL PRIMARY KEY,
	[Password] nvarchar(50) default 'Test123',
    Role nvarchar(50),
	FullName nvarchar(50),
	Gender nvarchar(50),
	Birthday date,
	Loggedin nvarchar(50) not null default 'FALSE',
	Profilelmage Image);

Create table [Order](
OrderID nvarchar(50) NOT NULL PRIMARY KEY);

CREATE TABLE Customer(
    CustomerID nvarchar(50) NOT NULL PRIMARY KEY,
	UserID nvarchar(50) FOREIGN KEY REFERENCES [User](UserID), 
	OrderID nvarchar(50) FOREIGN KEY REFERENCES [Order](OrderID),
	Loggedin nvarchar(50) not null default 'FALSE');

CREATE TABLE PlaceOfReservation(
    PlaceID nvarchar(50) NOT NULL PRIMARY KEY,
    Description nvarchar(500),
	MinOfPax int, 
    EventType nvarchar(50),
    Chosen nvarchar(50),
	Name nvarchar(50));

CREATE TABLE Reservation(
    ReservationID nvarchar(50) NOT NULL PRIMARY KEY,
    PlaceID nvarchar(50) FOREIGN KEY REFERENCES PlaceOfReservation(PlaceID),
	CustomerID nvarchar(50) FOREIGN KEY REFERENCES Customer(CustomerID), 
    PlaceName nvarchar(200),
	CustomerPax int,
    ReservedDateTime datetime,
	Duration int,
	PlaceSpecialInstructions nvarchar(500));

ALTER TABLE PlaceOfReservation
ADD ReservationID nvarchar(50) FOREIGN KEY REFERENCES Reservation(ReservationID);

ALTER TABLE Customer
ADD ReservationID nvarchar(50) FOREIGN KEY REFERENCES Reservation(ReservationID);

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

CREATE TABLE Menu (
ProductID nvarchar(50) NOT NULL PRIMARY KEY,
[Name] nvarchar(50),
Description nvarchar(500),
Price decimal(10,2),
Cuisine nvarchar(50),
Ratings decimal(10,2),
Chosen nvarchar(50) not null default 'FALSE',
Productlmage Image);

INSERT INTO Menu (ProductID, [Name], [Description], Price, Cuisine)
VALUES ('P001', 'KOREAN RAMYEON', 'Korean ramyeon with poached egg.', '12', 'Korean'),
('P002', 'CHEESE RAMYEON','Korean ramyeon with poached egg and cheese.', '13.5', 'Korean'),
('P003', 'TTEOK RAMYEON', 'Korean ramyeon with rice cake.','15', 'Korean'),
('P004', 'KIMCHI RAMYEON','Korean ramyeon with mushrooms and poached egg served in a spicy kimchi broth.', '15', 'Korean'),
('P005', 'JJAMPONG', 'Spicy Korean noodle soup loaded with seafood.', '18','Korean'),
('P006', 'ONIGIRI', 'Japanese rice balls with assorted fillings.','4.5', 'Japanese'),
('P007', 'INARIZUSHI', 'Tofu pockets filled with fragrant sushi rice.', '4.5', 'Japanese'),
('P008', 'MAGURO NIGIRI SUSHI', 'Sushi rice topped with tuna slices.', '8', 'Japanese'),
('P009', 'TAMAGO NIGIRI SUSHI', 'Sushi rice topped with an egg omelette.', '4.5', 'Japanese'),
('P010', 'TAKO NIGIRI SUSHI', 'Sushi rice topped with slices of octopus.', '8', 'Japanese'),
('P011', 'SPAGHETTI CARBONARA', 'Creamy pasta dish made with spaghetti, eggs, pancetta or bacon, grated Parmesan cheese, and black pepper.', '16', 'Western'),
('P012', 'GRILLED SALMON WITH LEMON BUTTER SAUCE', 'Grilled salmon fillet seasoned with herbs and served with a tangy lemon butter sauce, accompanied by steamed vegetables or mashed potatoes.', '32', 'Western'),
('P013', 'BEEF BURGER WITH FRIES', 'Juicy beef patty topped with lettuce, tomato, onion, cheese, and pickles, served on a toasted bun with a side of French fries.', '25', 'Western'),
('P014', 'MARGHERITA PIZZA', 'Traditional Italian pizza topped with tomato sauce, fresh mozzarella cheese, basil leaves, and a drizzle of olive oil.', '24', 'Western'),
('P015', 'CHICKEN PARMESAN', 'Breaded and fried chicken breast topped with marinara sauce and melted mozzarella cheese, served with spaghetti or garlic bread.', '26', 'Western'),
('P016', 'MATCHA LATTE', 'Creamy green tea latte.', '13', 'Beverages'),
('P017', 'ICED AMERICANO', 'Bold espresso over ice.', '11', 'Beverages'),
('P018', 'WATER', 'Refreshing drinking water.', '3', 'Beverages'),
('P019', 'HOT GREEN TEA', 'Comforting and warm green tea.', '5', 'Beverages'),
('P020', 'SOJU', 'Korean rice liquor.', '13', 'Beverages');



INSERT INTO PlaceOfReservation(PlaceID, [Description], MinOfPax, EventType, [Name], ReservationID)
VALUES 
    ('T01', 'A small table suitable for accommodating two persons', 1, 'Dining', 'Table 1',NULL),
    ('T02', 'A small table suitable for accommodating two persons', 1, 'Dining', 'Table 2',NULL),
    ('T03', 'A small table suitable for accommodating two persons', 1, 'Dining', 'Table 3',NULL),
    ('T04', 'A small table suitable for accommodating two persons', 1, 'Dining', 'Table 4',NULL),
    ('T05', 'A medium-sized table designed to seat four individuals comfortably.', 3, 'Dining', 'Table 5',NULL),
    ('T06', 'A medium-sized table designed to seat four individuals comfortably.', 3, 'Dining', 'Table 6',NULL),
    ('T07', 'A medium-sized table designed to seat four individuals comfortably.', 3, 'Dining', 'Table 7',NULL),
    ('T08', 'A medium-sized table designed to seat four individuals comfortably.', 3, 'Dining', 'Table 8',NULL),
    ('T09', 'A large table intended to accommodate up to eight people.', 6, 'Dining', 'Table 9',NULL),
    ('T10', 'A large table intended to accommodate up to eight people.', 6, 'Dining', 'Table 10',NULL),
    ('VIP01', 'A private dining area reserved for VIP guests or special occasions.', 8, 'Private Dining or Party', 'VIP Room 1',NULL),
    ('VIP02', 'A private dining area reserved for VIP guests or special occasions.', 8, 'Private Dining or Party', 'VIP Room 2',NULL);

	INSERT INTO [User](UserID, [Role], FullName, Gender, Birthday)
VALUES 
    ('M001', 'Manager', 'John Doe', 'Male', '1990-01-01'),
    ('A002', 'Customer', 'Jane Smith', 'Female', '1995-05-15');

	INSERT INTO Customer(CustomerID, UserID)
VALUES 
    ('C001','A002');

EXEC sp_rename 'Menu.Productlmage',  'ProductImage', 'COLUMN';

--placeID
SELECT ReservationReport.ReservationReportID, Reservation.ReservationID, PlaceOfReservation.PlaceID, Reservation.CustomerID, PlaceOfReservation.EventType, Reservation.CustomerPax, Reservation.ReservationID, Reservation.Duration
FROM Reservation
INNER JOIN 
    PlaceOfReservation ON Reservation.PlaceID = PlaceOfReservation.PlaceID
INNER JOIN
    ReservationReport ON ReservationReport.ReservationID = Reservation.ReservationID;


