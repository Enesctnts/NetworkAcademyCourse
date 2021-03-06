USE [Northwind]
GO
/****** Object:  StoredProcedure [dbo].[CustOrderHist]    Script Date: 21.01.2022 10:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[CustOrderHist] @CustomerID nchar(5)
AS
SELECT ProductName, SUM(Quantity) AS Total
FROM Products P, [Order Details] OD, Orders O, Customers C
WHERE C.CustomerID = @CustomerID
AND C.CustomerID = O.CustomerID AND O.OrderID = OD.OrderID 
AND OD.ProductID = P.ProductID
GROUP BY ProductName

--EXEC [CustOrderHist] 'ANATR'
