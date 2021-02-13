CREATE TABLE [dbo].[Customers] (
    [CustomerID]  INT        NOT NULL,
    [UserID]      INT        NULL,
    [CompanyName] NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([CustomerID] ASC),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID])
);

