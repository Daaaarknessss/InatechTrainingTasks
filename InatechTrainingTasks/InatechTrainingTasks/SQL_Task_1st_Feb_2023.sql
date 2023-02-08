



--Task1
select FirstName, LastName
from person.person
where Title IS NOT NULL

--Task2
select FirstName, LastName
from person.person
where (FirstName like '%a%') AND (LastName like '%a%')

--Task3
select cur.CurrencyCode,Name
from Sales.Currency cur, Sales.CountryRegionCurrency  reg

--Task4
select * into HR_Dept
from HumanResources.Department
select * from HR_Dept

--Task5
create table TaskTab
(
 tfname varchar(20),
 Sno int identity(1,1),
)

declare @var int
set @var=16
while @var<=25
begin
insert into TaskTab
values(concat('Padma',@var))
set @var = @var+1
end
select * from TaskTab


--Task6
select per.BusinessEntityID, AddressTypeID
from HumanResources.Department dep join
Person.BusinessEntityAddress per on
dep.DepartmentID = per.BusinessEntityID

--Task7
select distinct GroupName
from HumanResources.Department

--Task8 
select sum(ListPrice), sum(chis.StandardCost), ProductSubcategoryID
from Production.ProductCostHistory chis 
join Production.Product pro
on chis.ProductID = pro.ProductID
group by ProductSubcategoryID

--Task9
select DATEDIFF(year, StartDate, EndDate) Role
from HumanResources.EmployeeDepartmentHistory

--Task10
 --select 
 --from 

 --select * from Production.ProductCostHistory
 --select * from Production.ProductSubcategory
--Task11
select max(TaxRate) Max_taxrate
from Sales.SalesTaxRate

--Task12 (nc)
Select dep.DepartmentID, emp.BusinessEntityID, dhis.ShiftID, emp.BirthDate
from HumanResources.Department dep 
join HumanResources.Employee emp 
on dep.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dhis
on dhis.BusinessEntityID = emp.BusinessEntityID


--task13
create view Name_age
as
Select dep.DepartmentID, emp.BusinessEntityID, dhis.ShiftID, emp.BirthDate, getdate() as CurrentDate, year(getdate())-year(emp.BirthDate) as age 
from HumanResources.Department dep 
join HumanResources.Employee emp 
on dep.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dhis
on dhis.BusinessEntityID = emp.BusinessEntityID

--task14
select count(*) [No_of_rows] from HumanResources.Department, HumanResources.Employee

--task15
select max(Rate) Max_Rate,Name
from HumanResources.EmployeePayHistory pay join
HumanResources.Department dep
on pay.BusinessEntityID = dep.DepartmentID
group by Name

--task16
select FirstName,MiddleName,Title,AddressTypeID,pb.BusinessEntityID
from Person.Person pp
left join Person.BusinessEntityAddress pb
on pp.BusinessEntityID=pb.BusinessEntityID
where Title is not null


--task 17
select ProductID,PL.LocationID,Shelf
from Production.ProductInventory PI
join Production.Location PL
on PI.LocationID=PL.LocationID
where ProductID>=300 and ProductID<=350 and PL.LocationID=50 or Shelf='E'

--task 18
select Shelf,Name,pp.LocationID
from Production.ProductInventory pp
join Production.Location pl
on pp.LocationID=pl.LocationID

--task 19
select AddressID,AddressLine1,AddressLine2,SP.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince SP
join Person.Address PA
on SP.StateProvinceID=PA.StateProvinceID

--task20
select  CurrencyCode,Sum(SubTotal+TaxAmt) as total
from Sales.SalesOrderHeader so
join Sales.SalesTerritory st
on st.TerritoryID=so.TerritoryID
join Sales.CountryRegionCurrency cr
on cr.CountryRegionCode=st.CountryRegionCode
group by CurrencyCode


