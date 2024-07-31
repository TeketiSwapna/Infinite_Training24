create database SQLCC7
use SQLcc7
drop database SQLCC7


create table books(ID int primary key , titile varchar(20),Author varchar(50) not null ,isbn varchar(100) unique, published_date datetime)
insert into books values(1, 'My FIrst Book', 'Mary Parker', '981483029127', '2012-02-22 12:08:17'),
                        (2, 'My Second Book','John Mayer', '857300923713', '1972-07-03 09:22:45'),
						(3, 'My Third Book', 'Cory Flint', '5231208967812', '2015-10-18 14:05:44')
select * from books
create table reviews(ID int,BookID int, Reviwer_Name varchar(50),Content varchar(50), Rating int, Published_Date datetime)
insert into reviews values(1, 1, 'John Smith', 'My First Review', 4,'2017-12-10 05:50:11.1'),
                        (2, 2,'John Smith', 'My Second Review', 5,'2017-10-13 15:05:12.6'),
						(3, 2, 'Alice Walker','Another Review', 1,'2017-10-22 23:47:10.7')
select * from reviews
--1. Display the Title ,Author and ReviewerName for all the books from the above table 
Select b.titile, b.author, r.reviwer_name
from books b
left JOIN reviews r ON b.id = r.bookid;

--2.Display the  reviewer name who reviewed more than one book.

Select distinct Reviwer_Name
from reviews
group by Reviwer_Name
having count(distinct BookID) > 1;


create table Customer
(
Id int,
Name varchar(100),
Age int,
Address varchar(100),
Salary float,
)
insert into Customer Values
(1, 'Ramesh', 32, 'Ahmedabad', 2000),
(2, 'Khilan', 25, 'Delhi', 1500),
(3, 'Kaushik', 23, 'Kota', 2000),
(4, 'Chaitali', 25, 'Mumbai', 6500),
(5, 'Hardik', 27, 'Bhopal', 8500),
(6, 'Komal', 22, 'Ahmedabad', 4500),
(7, 'Muffy', 24, 'Ahmedabad', 10000)


--3.Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address
Select name from customer where Address like '%o%';



create table Orders
(Orderid int,OrderedDate date,Id int,Amount float,)


Insert into Orders Values
(102, '2009-10-08', 3, 3000),
(100, '2009-10-08', 3, 1500),
(101, '2009-11-20', 2, 1500),
(103, '2008-05-20', 4, 2060)



--4.Write a query to display the   Date,Total no of customer  placed order on same Date 
Select OrderedDate, Count(Distinct Id) as Customers from orders group by OrderedDate order by OrderedDate;

Create table Employee
(
Id int,
Name varchar(100),
Age int,
Address varchar(100),
Salary float,
)
insert into Employee values
(1, 'ramesh', 32, 'ahmedabad', 2000),
(2, 'khilan', 25, 'delhi', 1500),
(3, 'kaushik', 23, 'kota', 2000),
(4, 'chaitali', 25, 'mumbai', 6500),
(5, 'hardik', 27, 'bhopal', 8500),
(6, 'komal', 22, 'ahmedabad', null),
(7, 'muffy', 24, 'ahmedabad', null)
 
 
--Display the Names of the Employee in lower case, whose salary is null 
Select LOWER(Name) as lower_case_name from Employee where salary IS NULL;

create table Students
(
	Serialno int,
	RegisterNo int primary key,
	Name varchar(20),
	Age int,
	Qualification varchar(40), 
	PhoneNo varchar(20),
	Mailid varchar(30),
	Location varchar(50),
	Gender char(5)
)
insert into Students values
	(1, 2, 'Sai', 22, 'B.E', '9952836777', 'Sai@gmail.com', 'Chennai', 'M'),
	(2, 3, 'Kumar', 20, 'BSC', '7890125648', 'Kumar@gmail.com', 'Madurai', 'M'),
	(3, 4, 'Selvi', 22, 'B.Tech', '8904567342', 'selvi@gmail.com', 'Selam', 'F'),
	(4, 5, 'Nisha', 25, 'M.E', '7834672310', 'Nisha@gmail.com', 'Theni', 'F'),
	(5, 6, 'SaiSaran', 21, 'B.A', '7890345678', 'saran@gmail.com', 'Madurai', 'F'),
	(6, 7, 'Tom', 23, 'BCA', '8901234675', 'Tom@gmail.com', 'Pune', 'M')

--Write a sql server query to display the Gender,Total no of male and female from the above relation    
select Gender,count(gender) from Students group by gender

