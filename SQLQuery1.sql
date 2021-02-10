CREATE TABLE Cars(
	CarID int PRIMARY KEY IDENTITY(1,1),
	BrandID int,
	ColorID int,
	ModelYear nvarchar(25),
	DailyPrice decimal,
	Descriptions nvarchar(25),
	FOREIGN KEY (ColorID) REFERENCES Colors(ColorID),
	FOREIGN KEY (BrandID) REFERENCES Brands(BrandID)
)

INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	            ('1','1', '2', '2012', '100', 'Manuel Benzin'),
	            ('2', '1', '3', '2015', '150', 'Otomatik Dizel'),
	            ('3', '2', '1', '2017', '200', 'Otomatik Hybrid'),
	            ('4', '3', '3', '2014', '125', 'Manuel Dizel');
