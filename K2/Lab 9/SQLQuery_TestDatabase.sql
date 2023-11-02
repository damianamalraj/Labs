USE master
GO

CREATE DATABASE TestDatabase
GO

USE TestDatabase
GO

CREATE TABLE Customer(
    customer_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    first_name NVARCHAR(35) NOT NULL,
    last_name NVARCHAR(35) NOT NULL,
)
GO

CREATE TABLE Orders(
    order_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    customer_id INT NOT NULL,
    FOREIGN KEY (customer_id) REFERENCES Customer(customer_id)
)
GO

INSERT INTO Customer(first_name, last_name) 
VALUES
('Sara','Doe'),
('Mark','Doe'),
('Susanne','Doe')

INSERT INTO Orders(customer_id)
VALUES
(3),
(4)


SELECT * FROM Customer
SELECT * FROM Orders