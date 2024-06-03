CREATE TABLE [dbo].[Reservation] (
    [ReservationID]            NVARCHAR (50)  NOT NULL,
    [PlaceID]                  NVARCHAR (50)  NULL,
    [CustomerID]               NVARCHAR (50)  NULL,
    [PlaceName]                NVARCHAR (200) NULL,
    [CustomerPax]              INT            NULL,
    [ReservedDateTime]         DATETIME       NULL,
    [Duration]                 INT            NULL,
    [PlaceSpecialInstructions] NVARCHAR (500) NULL,
    [ReservationStatus] NVARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([ReservationID] ASC),
    FOREIGN KEY ([PlaceID]) REFERENCES [dbo].[PlaceOfReservation] ([PlaceID]),
    FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([CustomerID])
);

