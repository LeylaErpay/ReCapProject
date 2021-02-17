CREATE TABLE Cars(
	Id int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	ModelYear smallint,
	DailyPrice int,
	Description nvarchar(30),
	FOREIGN KEY (BrandId) REFERENCES Colors(Id),
	FOREIGN KEY (ColorId) REFERENCES Brands(Id)
)

CREATE TABLE Colors(
	Id int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(15),
)

CREATE TABLE Brands(
	Id int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(20),
)

INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	(1,1,2007,155,'Manuel'),
	(3,2,2012,170,'Otomatik'),
	(2,4,2009,150,'Manuel'),
	(4,3,2018,300,'Otomatik');

INSERT INTO Colors(ColorName)
VALUES
	('Beyaz'),
	('Kırmızı'),
	('Siyah'),
	('Mavi');


INSERT INTO Brands(BrandName)
VALUES
	('Citroen'),
	('Renault'),
	('Volkswagen'),
	('Ford');

select * from Brands