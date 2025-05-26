CREATE DATABASE EShop;
USE EShop;

CREATE TABLE Customer
(
	CustomerId INT PRIMARY KEY,
	CName VARCHAR(50) NOT NULL,
	Email VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE CustomerContactInfo
(
	ContactInfo VARCHAR(50) NOT NULL,
	customerId INT,
	FOREIGN KEY (customerId) REFERENCES Customer(CustomerId)
	ON DELETE SET NULL
);

CREATE TABLE Catogry
(
	CatogryId INT PRIMARY KEY,
	CatogryName VARCHAR(50) NOT NULL
);

CREATE TABLE Products
(
	ProductId INT PRIMARY KEY,
	ProductName VARCHAR(50) NOT NULL,
	ProductDescription TEXT,
	Price DECIMAL(10,2) NOT NULL,
	catogryId INT,
	FOREIGN KEY (catogryId) REFERENCES Catogry(CatogryId)
	ON DELETE SET NULL
);

CREATE TABLE Orders
(
	OrderId INT PRIMARY KEY,
	OrderDate  DATETIME,
	TotalPrice DECIMAL(10,2) NOT NULL,
	customerId INT,
	FOREIGN KEY (customerId) REFERENCES Customer(CustomerId)
	ON DELETE SET NULL
);

CREATE TABLE OrderItems 
(
	OrderItemId INT PRIMARY KEY,
	Quantity INT,
	indItemPrice DECIMAL(10,2) NOT NULL,
	orderId INT,
	productID INT,
	FOREIGN KEY (orderId) REFERENCES Orders(OrderId)
	ON DELETE CASCADE,
	FOREIGN KEY (productID) REFERENCES Products(ProductID)
	ON DELETE CASCADE
);

CREATE TABLE ShippingAddress  
(
	OShippingId INT PRIMARY KEY,
	StreetAddress VARCHAR(100),
	City VARCHAR(100) NOT NULL,
	orderId INT,
	FOREIGN KEY (orderId) REFERENCES Orders(OrderId)
	ON DELETE CASCADE
);

CREATE TABLE PaymentInfo 
(
	PaymentId INT PRIMARY KEY,
	PaymentMethod VARCHAR(100) NOT NULL,
	CardNumber VARCHAR(100) NOT NULL,
	CVV CHAR(3),
	ExpDate DATE,
	customerId INT,
	FOREIGN KEY (customerId) REFERENCES Customer(CustomerId)
	ON DELETE SET NULL
);

CREATE TABLE Review 
(
	ReviewId INT PRIMARY KEY,
	Rating INT,
	Comment VARCHAR(100),
	customerId INT,
	productID INT,
	FOREIGN KEY (customerId) REFERENCES Customer(CustomerId)
	ON DELETE SET NULL,
	FOREIGN KEY (productID) REFERENCES Products(ProductID)
	ON DELETE CASCADE
);