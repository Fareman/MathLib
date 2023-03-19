SELECT Products.Name AS 'Name', Categories.Name AS 'Category'
FROM Products
LEFT JOIN Products_Categories ON Products.Id = Products_Categories.Product_Id
LEFT JOIN Categorise ON Categories.Id = Products_Categories.Category_Id
ORDER BY Products.Name, Categories.Name;