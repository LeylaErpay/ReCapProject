CREATE TABLE [dbo].[Rentals] (
    [RentalID]         INT  IDENTITY    NOT NULL,
    [CarID]      INT      NULL,
    [CustomerID] INT      NULL,
    [RentDate]   DATETIME NULL,
    [ReturnDate] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([RentalID] ASC),
    FOREIGN KEY ([CarID]) REFERENCES [dbo].[Cars] ([CarID]),
    FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers] ([CustomerID])
);

