CREATE TABLE [ItemTypes]
(
	[ItemTypeID] INT IDENTITY PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Items]
(
	[ItemID] INT IDENTITY PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL,
	[ItemTypeID] INT REFERENCES [ItemTypes]([ItemTypeID])
)

CREATE TABLE [Cities]
(
	[CityID] INT IDENTITY PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Customers]
(	
	[CustomerID] INT IDENTITY PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL,
	[Birthday] DATE,
	[CityID] INT REFERENCES [Cities]([CityID])
)

CREATE TABLE [Orders]
(
	[OrderID] INT IDENTITY PRIMARY KEY,
	[CustomerID] INT REFERENCES [Customers]([CustomerID])
)

CREATE TABLE [OrderItems]
(
	[OrderID] INT REFERENCES [Orders]([OrderID]),
	[ItemID] INT REFERENCES [Items]([ItemID])
	PRIMARY KEY([OrderID], [ItemID])
)