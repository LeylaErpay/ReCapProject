CREATE TABLE [dbo].[Cars] (
    [CarID]        INT           IDENTITY (1, 1) NOT NULL,
    [BrandID]      INT           NOT NULL,
    [ColorID]      INT           NULL,
    [ModelYear]    NVARCHAR (25) NULL,
    [DailyPrice]   DECIMAL (18)  NULL,
    [Descriptions] NVARCHAR (25) NULL,
    [CarName] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([CarID] ASC),
    FOREIGN KEY ([ColorID]) REFERENCES [dbo].[Colors] ([ColorID]),
    FOREIGN KEY ([BrandID]) REFERENCES [dbo].[Brands] ([BrandID])
)

INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Descriptions, CarName)
VALUES
	            (3, 1,  '2012', '100', 'Manuel Benzin', 'BMW'),
	            (4, 1, '2015', '150', 'Otomatik Dizel','Mercedes'),
	            (5, 2, '2017', '200', 'Otomatik Hybrid','Audi'),
	            (6, 3, '2014', '125', 'Manuel Dizel','peugeot');

                select *from dbo.Cars


     