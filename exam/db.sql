-- database structure 
create database coffee

use coffee

create table CoffeeShops(
	sid int primary key identity(1,1),
	name varchar(50),
	address varchar(100)
);

create table Reviews(
	rid int primary key identity(1,1),
	rtext varchar(200),
	rdate date,
	noStars int, 
	sid int foreign key references CoffeeShops(sid)
); 

create table Customers(
	cid int primary key identity(1,1),
	fname varchar(50),
	lname varchar(50),
);

create table CoffeeProducts(
	cpid int primary key identity (1,1),
	cpname varchar(50),
	cpdesc varchar(100)
);

create table Sales(
	sid int references CoffeeShops(sid),
	cpid int references CoffeeProducts(cpid),
	price int
	primary key (sid,cpid)
);

create table Orders(
	sid int references CoffeeShops(sid),
	cid int references Customers(cid), 
	odate datetime,
	primary key (sid,cid)
);

insert into CoffeeShops (name,address) values ('alex','traian'), ('dani','alba')
insert into Reviews(rtext, rdate, noStars, sid) values ('asd','12/02/2020',5,1)