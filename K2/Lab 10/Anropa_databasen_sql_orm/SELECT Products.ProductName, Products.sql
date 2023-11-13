-- Hämta alla produkter med deras namn, pris och kategori namn. Sortera på kategori namn och sen produkt namn
SELECT Products.ProductName, Products.UnitPrice, Categories.CategoryName
FROM Products
JOIN Categories ON Products.CategoryID = Categories.CategoryID
ORDER BY CategoryName, ProductName

-- Hämta alla kunder och antal ordrar de gjort. Sortera fallande på antal ordrar.
SELECT Customers.CustomerID, Customers.CompanyName, COUNT(Orders.OrderID) AS NumberOfOrders
FROM Customers
JOIN Orders ON Customers.CustomerID = Orders.CustomerID
GROUP BY Customers.CustomerID, Customers.CompanyName
ORDER BY COUNT(Orders.OrderID) DESC;

-- Hämta alla anställda tillsammans med territorie de har hand om (EmployeeTerritories och Territories tabellerna)
SELECT e.EmployeeID, e.FirstName, e.LastName, t.TerritoryDescription
FROM Employees AS e
JOIN EmployeeTerritories AS et ON e.EmployeeID = et.EmployeeID
JOIN Territories AS t ON et.TerritoryID = t.TerritoryID;