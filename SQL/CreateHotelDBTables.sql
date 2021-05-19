CREATE TABLE RoomCategory(
	Id int NOT NULL PRIMARY KEY,
	RoomLevel tinyint NOT NULL,
	NumberOfSeats int NOT NULL,
	PricePerNight money NOT NULL
)

CREATE TABLE Room(
	Id int NOT NULL PRIMARY KEY,
	RoomNumber int,
	RoomCategoryId int NOT NULL FOREIGN KEY REFERENCES [RoomCategory](Id),
	[Floor] int,
)

CREATE TABLE Guest(
	Id int NOT NULL PRIMARY KEY,
	FullName nvarchar(500) NOT NULL,
	DateOfBirthday datetime NOT NULL,
	ResidenceAddress nvarchar(100)
)

CREATE TABLE Reservation(
	Id int NOT NULL PRIMARY KEY,
	GuestId int NOT NULL FOREIGN KEY REFERENCES [Guest](Id),
	RoomId int NOT NULL FOREIGN KEY REFERENCES [Room](Id),
	PricePerNight money NOT NULL,
	ArrivalDate datetime NOT NULL,
	DepartureTime datetime NOT NULL,
	BookStatus tinyint NOT NULL
)