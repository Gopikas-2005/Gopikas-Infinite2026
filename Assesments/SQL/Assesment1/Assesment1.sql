Create database Assignment;
Use Assignment;
Create Table Books(id int Primary Key,Title varchar(100),Author varchar(100),Isbn Varchar(20) ,Published_date DateTime)
Insert into Books (id,Title,Author,Isbn,Published_date) Values
(1,'My First Sql Book','Mary Parker',981483029127,'2012-02-22 12:08:17'),
(2,'My Second Sql Book' ,'John Mayer',857300923713,'1972-07-03 09:22:45'),
(3,'My Third Sql Book','Cary Flint',523120967812,'2015-10-18 14:05:44')

--Create a book table with id as primary key and provide the appropriate data type to other attributes .isbn no should be unique for each book

--Write a query to fetch the details of the books written by author whose name ends with er.

Select * from Books where Author like '%er'

Create Table Reviews(id int Primary Key,Book_id int,Reviewer_Name Varchar(100), Content varchar(100),Rating int,Published_date DateTime);
Insert into  Reviews Values (1,1,'John Smith','My First Review',4 ,'2017-12-10 05:50:11'),
(2,2,'John Smith','Ny Second eview',5,'2017-10-13 15:05:12'),
(3,2,'Alice Walker','Another Review',1,'2017-10-22 23:47:10');

--Display the Title ,Author and ReviewerName for all the books from the above table
Select B.Title,B.Author,R.Reviewer_Name from Books B Join Reviews R on B.Id=R.Id;
--Display the reviewer name who reviewed more than one book.

Select Reviewer_Name from Reviews where Rating=(Select Max(rating) from Reviews);
Create Table Customers(Id int Primary Key,Names Varchar(100),Age int,Addresess Varchar(100),Salary Decimal)
Insert into Customers Values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'Kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',4500.00),
(7,'Muffy',24,'Indore',10000.00);
Drop Table Customers;
--Display the Name for the customer from above customer table who live in same address which has character o anywhere in address
Select Names from Customers where Addresess like '%o%'

Create Table Orders(OID int Primary Key,Dates Date, Customer_Id int,Amount Decimal)

Insert into Orders Values(102,'2009-10-08',3,3000),
(100,'2009-10-08',3,1500),(101,'2009-11-20',2,1560),(103,'2008-05-20',4,2060)

--Write a query to display the Date,Total no of customer placed order on same Date

Select Dates,Count(Distinct  Customer_id)  As Total_Customers from Orders Group by Dates;

Create Table Employees(Id int Primary Key,Names Varchar(100),Age int,Addresess Varchar(100),Salary Decimal)
Insert into Employees Values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'Kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',null),
(7,'Muffy',24,'Indore',null);

--Display the Names of the Employee in lower case, whose salary is null
Select Lower(Names) as Lowercase_Name
From Employees
Where Salary IS NULL;


Create table Studentdetails (
    RegisterNo INT PRIMARY KEY,
    Name VARCHAR(50),
    Age INT,
    Qualification VARCHAR(20),
    MobileNo BIGINT,
    Mail_id VARCHAR(100),
    Location VARCHAR(50),
    Gender CHAR(1)
);


Insert into Studentdetails Values
(2, 'Sai', 22, 'B.E', 9952836777, 'Sai@gmail.com', 'Chennai', 'M'),
(3, 'Kumar', 20, 'BSC', 7890125648, 'Kumar@gmail.com', 'Madurai', 'M'),
(4, 'Selvi', 22, 'B.Tech', 8904567342, 'selvi@gmail.com', 'Selam', 'F'),
(5, 'Nisha', 25, 'M.E', 7834672310, 'Nisha@gmail.com', 'Theni', 'F'),
(6, 'SaiSaran', 21, 'B.A', 7890345678, 'saran@gmail.com', 'Madurai', 'F'),
(7, 'Tom', 23, 'BCA', 8901234675, 'Tom@gmail.com', 'Pune','M')


--Write a sql server query to display the Gender,Total no of male and female from the above

--relation
Select Gender, COUNT(*) As TotalCount
From Studentdetails
Group By Gender;
