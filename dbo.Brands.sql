CREATE TABLE [dbo].[Brands] (
    [BrandId]   INT           IDENTITY (1, 1) NULL,
    [BrandName] NVARCHAR (25) NULL,
    
);

INSERT INTO Brands(BrandName)
VALUES
	('Tesla'),
	('BMW'),
	('Renault');