CREATE TABLE [dbo].[Brands] (
    [BrandID]   INT     PRIMARY KEY  IDENTITY (1, 1) NULL,
    [BrandName] NVARCHAR (25) NULL,
    
);

INSERT INTO Brands(BrandName)
VALUES
	
	('BMW'),
	('Mercedes'),
	('Audi'),
	('Peugeot');


	select *from dbo.Brands

	