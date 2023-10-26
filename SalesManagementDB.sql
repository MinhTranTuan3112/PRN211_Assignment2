use master;
go
create database SalesManagementDB;
go
use SalesManagementDB;

create table Member (
  MemberId int not null primary key,
  Email varchar(100) not null,
  CompanyName varchar(40) not null,
  City varchar(15) not null,
  Country varchar(15) not null,
  [Password] varchar(30) not null
);

insert into Member (MemberId, Email, CompanyName, City, Country, [Password])
values
(1,'john.doe@example.com', 'Tech Corp', 'Hanoi', 'Vietnam', 'Johndoe123'),
(2, 'jane.smith@example.com', 'Innovate Ltd', 'TP.HCM', 'Vietnam', 'Janesmith456'),
(3, 'michael.nguyen@example.com', 'BuildIt Inc', 'Da Nang', 'Vietnam', 'Michaelnguyen789'),
(4, 'minh.tran@example.com', 'Pkmn', 'TP.HCM', 'Vietnam', 'minhtran3112'),
(5, 'james.vo@example.com', 'Create Solutions', 'Hue', 'Vietnam', 'Jamesvo345');

create table [Order](
  OrderId int identity(1,1) not null primary key,
  MemberId int not null,
  OrderDate datetime not null, 
  RequiredDate datetime,
  ShippedDate datetime,
  Freight money,

  foreign key (MemberId) references dbo.Member(MemberId)
);

create table Product(
  ProductId int identity(1,1) not null primary key,  
  CategoryId int not null,
  ProductName varchar(40) not null,
  [Weight] varchar(20) not null,
  UnitPrice money not null,
  UnitsInStock int not null
);

insert into Product (CategoryId, ProductName, [Weight], UnitPrice, UnitsInStock)
values
(101, 'Apple iPhone 13', '174g', 699.00, 1000),
(102, 'Samsung Galaxy S21', '171g', 799.99, 800),
(103, 'Google Pixel 6 Pro', '210g', 899.00, 700),
(104, 'OnePlus 9 Pro', '197g', 969.00, 600);


create table OrderDetail(
  OrderId int not null,
  ProductId int not null,
  UnitPrice money not null,
  Quantity int not null,
  Discount float not null,

  primary key(OrderId, ProductId),
  foreign key (OrderId) references dbo.[Order](OrderId),
  foreign key (ProductId) references dbo.Product(ProductId)
);
