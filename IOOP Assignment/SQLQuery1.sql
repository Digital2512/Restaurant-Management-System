create database IOOPDatabase

USE IOOPDatabase;

CREATE TABLE Customer 
(CustomerID nvarchar(50) NOT NULL PRIMARY KEY);

CREATE TABLE PlaceOfReservation 
(PlaceID nvarchar(50) NOT NULL PRIMARY KEY,
Description nvarchar(255),
MinOfPax INT,
EventType nvarchar(100),
ReservationID nvarchar(50) Foreign Key References Reservation(ReservationID),
CustomerID nvarchar(50) Foreign Key References Customer(CustomerID));

CREATE TABLE Users 
(UserID nvarchar(50) NOT NULL PRIMARY KEY,
Password nvarchar(50),
Role nvarchar(50),
FullName decimal(10,2),
Gender nvarchar(100),
Birthday nvarchar(50));



CREATE TABLE Reservation 
(ReservationID nvarchar(50) NOT NULL PRIMARY KEY,
CustomerID nvarchar(50) Foreign Key References Customer(CustomerID),
PlaceID nvarchar(50) Foreign Key References PlaceOfReservation(PlaceID),
PlaceName nvarchar(100),
PlacePax nvarchar(50),
PlaceSpecialInstructions nvarchar(255),
ReservedDateTime DATETIME,
ReservationStatus nvarchar(255));

CREATE TABLE [Order]
(OrderID nvarchar(50) NOT NULL PRIMARY KEY,
OrderDateTime nvarchar(50),
BeforePrice decimal(10,2),
Tax decimal(10,2),
TotalPrice decimal(10,2),
PaymentStatus nvarchar(50));

ALTER TABLE Customer
ADD UserID nvarchar(50) Foreign Key References Users(UserID),
ReservationID nvarchar(50) Foreign Key References Reservation(ReservationID),
OrderID nvarchar(50) Foreign Key References [Order](OrderID);

CREATE TABLE Menu 
(ProductID nvarchar(50) NOT NULL PRIMARY KEY,
Name nvarchar(50),
Description nvarchar(255),
Price decimal(10,2),
Category nvarchar(100));

CREATE TABLE Recipe 
(RecipeID nvarchar(50) NOT NULL PRIMARY KEY,
RecipeDetails nvarchar(255),
ProductID nvarchar(50) Foreign Key References Menu(ProductID));

ALTER TABLE Menu
ADD RecipeID nvarchar(50) Foreign Key References Recipe(RecipeID);

CREATE TABLE Inventory 
(StockID nvarchar(50) NOT NULL PRIMARY KEY,
Name nvarchar(50),
IndividualPrice decimal(10,2));

CREATE TABLE OrderDetails
(OrderDetailsID nvarchar(50) NOT NULL PRIMARY KEY,
ProductID nvarchar(50) Foreign Key References Menu(ProductID),
OrderID nvarchar(50) Foreign Key References [Order](OrderID),
Price decimal(10,2));

CREATE TABLE StockUsedInRecipe 
(RecipeID nvarchar(50) Foreign Key References Recipe(RecipeID),
StockID nvarchar(50) Foreign Key References Inventory(StockID),
QuantityUsed INT);

CREATE TABLE Feedback 
(FeedbackID nvarchar(50) NOT NULL PRIMARY KEY,
CustomerID nvarchar(50) Foreign Key References Customer(CustomerID),
FeedbackTopic nvarchar(255),
FeedbackTitle nvarchar(255),
FeedbackDescription nvarchar(255));

CREATE TABLE SalesReport 
(ReportID nvarchar(50) NOT NULL PRIMARY KEY,
ReportDateTime DATETIME,
[Month] DATE);

CREATE TABLE ReportDetails
(ReportDetailsID nvarchar(50) NOT NULL PRIMARY KEY,
ReportID nvarchar(50) Foreign Key References SalesReport(ReportID),
ProductID nvarchar(50) Foreign Key References Menu(ProductID),
Name nvarchar(255),
Quantity INT,
IndividualPrice decimal(10,2),
TotalPrice decimal(10,2));
