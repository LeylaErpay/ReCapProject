CREATE TABLE Users(
	Id int PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(20),
	LastName nvarchar(20),
	Email nvarchar(30),
	Password nvarchar(20),
)

CREATE TABLE Customers(
	Id int PRIMARY KEY IDENTITY(1,1),
	UserId int,
	CompanyName nvarchar(30),
	FOREIGN KEY (UserId) REFERENCES Users(Id),
)

CREATE TABLE Rentals(
	Id int PRIMARY KEY IDENTITY(1,1),
	CarId int,
	CustomerId int,
	RentDate datetime,
	ReturnDate datetime,
	FOREIGN KEY (CarId) REFERENCES Cars(Id),
	FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
)



INSERT INTO Users(FirstName,LastName,Email,Password)
VALUES
	('Yunus','Köse','koyu55000@gmail.com','asd123'),
	('Osman','Akdağ','akdagosman@hotmail.com','osmen123'),
	('Elif','Nur','nurel@gmail.com','cez123'),
	('Ali','Kasım','kasma48@gmail.com','123asd');


INSERT INTO Customers(UserId,CompanyName)
VALUES
	(1,'Samsun Rent a Car'),
	(1,'Koyu Rent a Car'),
	(2,'İzma Rent a Car'),
	(3,'Nur Rent a Car');

INSERT INTO Rentals(CarId,CustomerId,RentDate,ReturnDate)
VALUES
	(1,1,'20200618 10:34:09 AM','20200626 10:00:00 AM'),
	(3,1,'20200722 09:00:00 AM',null),
	(2,4,'20210113 09:34:35 AM','20200626 10:00:00 AM'),
	(3,3,'20210110 08:00:00 AM',null),
	(1,2,'20210106 11:48:12 AM','20200626 10:00:00 AM');



select * from Cars
select * from Customers
select * from Rentals