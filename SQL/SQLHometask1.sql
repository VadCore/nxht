--1. Как называется самый дорогой товар из товарной категории №1?

SELECT TOP 1
ProductName,
Price = MAX(UnitPrice)
FROM dbo.Products
WHERE CategoryID = 1
GROUP BY ProductName
ORDER BY Price DESC

--2. В какие города заказы комплектовались более десяти дней?

SELECT DISTINCT
ShipCity
FROM dbo.Orders
WHERE DATEDIFF(day, OrderDate, ShippedDate) > 10

--3. Какие покупатели до сих пор ждут отгрузки своих заказов?

SELECT DISTINCT
CustomerID
FROM dbo.Orders
WHERE ShippedDate IS NULL

--4. Скольких покупателей обслужил продавец, лидирующий по общему количеству заказов?

SELECT DISTINCT TOP 1
EmployeeID, [Count of unique buyers] = Count(DISTINCT CustomerID)
FROM dbo.Orders
GROUP BY EmployeeID
ORDER BY [Count of unique buyers] DESC

--5. Сколько французских городов обслужил продавец №1 в 1997-м?

SELECT
EmployeeID,
[France City count] = Count(DISTINCT ShipCity)
FROM dbo.Orders
WHERE EmployeeID = 1 AND ShipCountry = 'France' AND ShippedDate BETWEEN CAST('1997-01-01' AS DATE) AND CAST('1997-12-31' AS DATE)
GROUP BY EmployeeID

--6. В каких странах есть города, в которые было отправлено больше двух заказов?

SELECT DISTINCT
ShipCountry
FROM dbo.Orders
GROUP BY ShipCountry, ShipCity
HAVING COUNT(OrderID) > 2

--7. Перечислите названия товаров, которые были проданы в количестве менее 1000 штук (quantity)?

SELECT
ProductName, Quant = SUM(Quantity)
FROM dbo.Products LEFT JOIN [Order Details]
ON dbo.Products.ProductID = [Order Details].ProductID
GROUP BY ProductName
HAVING SUM(Quantity) < 1000
ORDER BY Quant

--8. Как зовут покупателей, которые делали заказы с доставкой в другой город (не в тот, в котором они прописаны)?

SELECT DISTINCT
ContactName
FROM dbo.Customers c
INNER JOIN dbo.Orders o
ON c.CustomerID = o.CustomerID
WHERE c.City != o.ShipCity

--9. Товарами из какой категории в 1997-м году заинтересовалось больше всего компаний, имеющих факс?

SELECT TOP 1 WITH TIES
CategoryName,
TotalCompanies = COUNT(DISTINCT cus.CustomerID)

FROM dbo.Categories c
LEFT JOIN dbo.Products p
ON p.CategoryID = c.CategoryID
LEFT JOIN dbo.[Order Details] od
ON od.ProductID = p.ProductID
LEFT JOIN dbo.Orders o
ON o.OrderID = od.OrderID
LEFT JOIN dbo.Customers cus
ON o.CustomerID = cus.CustomerID

WHERE OrderDate BETWEEN CAST('1997-01-01' AS DATE) AND CAST('1997-12-31' AS DATE) 
AND cus.Fax IS NOT NULL

GROUP BY CategoryName

ORDER BY TotalCompanies DESC

--10. Сколько всего единиц товаров (то есть, штук – Quantity) продал каждый продавец (имя, фамилия) осенью 1996 года?

SELECT 
FirstName,
LastName,
TotalQuantity = SUM(od.Quantity)

FROM dbo.Employees e
INNER JOIN dbo.Orders o
ON o.EmployeeID = e.EmployeeID
INNER JOIN dbo.[Order Details] od
ON o.OrderID = od.OrderID

WHERE o.OrderDate BETWEEN CAST('1996-09-01' AS DATE) AND CAST('1996-11-30' AS DATE)

GROUP BY FirstName, LastName
ORDER BY TotalQuantity DESC

---------------------------------------------------------------------------------