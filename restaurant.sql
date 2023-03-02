create table Menu (
  menuid int primary key identity,
  name nvarchar(50) not null,
  price int not null,
  photo nvarchar(100) not null
)
create table Member (
  memberid int primary key identity,
  name nvarchar(50) not null,
  email nvarchar(50) not null,
  handphone nvarchar(50) not null,
  joindate date not null
)
create table Employee (
  employeeid int primary key identity,
  name nvarchar(50) not null,
  email nvarchar(50) not null,
  password nvarchar(100) not null,
  handphone nvarchar(50) not null,
  position nvarchar(50) not null
)
create table Headorder (
  orderid int primary key,
  employeeid foreign key references employee(employeeid),
  memberid foreign key references member(memberid),
  date date not null,
  payment nvarchar(50) not null,
  bank nvarchar(50) not null
)
create table Detailorder (
  detailid int primary key identity,
  orderid foreign key references headorder(orderid),
  menuid foreign key references menu(menuid),
  qty int not null,
  price int not null,
  status nvarchar(10) not null
)