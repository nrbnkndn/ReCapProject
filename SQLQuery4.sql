
CREATE TABLE Users(
	UserID int PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(25),
	LastName nvarchar(25),
	Email nvarchar(25),
	UserPassword nvarchar(25)
)

CREATE TABLE Customers(
	CustomerID int PRIMARY KEY IDENTITY(1,1),
	CompanyName nvarchar(25),
	UserID int FOREIGN KEY REFERENCES Users(UserID),
)

CREATE TABLE Rentals(
	RentalID int PRIMARY KEY IDENTITY(1,1),
	RentDate DATE,
	ReturnDate DATE,
	CarID int FOREIGN KEY REFERENCES Cars(CarID),
	CustomerID int FOREIGN KEY REFERENCES Customers(CustomerID),
)

INSERT INTO Users(FirstName,LastName,Email,UserPassword)
VALUES
	('Ali','Kırca','alikirca@kodlama.io','1111111'),
	('Veli','Mırca','velimirca@kodlama.io','22222222'),
	('Ahmet','Vurca','ahmetvurca@kodlama.io','33333333'),
	('Mehmet','Kılca','mehmetkilca@kodlama.io','444444444');

INSERT INTO Customers(CompanyName,UserID)
VALUES
	('Beyaz','1'),
	('Siyah','2'),
	('Mavi','3');


INSERT INTO Rentals(RentDate,ReturnDate,CarID,CustomerID)
VALUES
	('12-FEB-2020','14-FEB-2020','2','1'),
	('11-FEB-2020','15-FEB-2020','2','2'),
	('13-FEB-2020','14-FEB-2020','3','3');