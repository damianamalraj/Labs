SELECT Products.ProductName, Products.UnitPrice, Categories.CategoryName
FROM Products
JOIN Categories ON Products.CategoryID = Categories.CategoryID
ORDER BY CategoryName, ProductName