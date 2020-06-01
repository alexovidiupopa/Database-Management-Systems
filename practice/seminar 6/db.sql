create database seminar6 

use seminar6


create table Users(
	id int primary key identity(1,1),
	name varchar(50),
	city varchar(20),
	dob date
	);

create table Categories(
	id int primary key identity(1,1),
	name varchar(50),
	description varchar(50)
	);

create table Pages(
	id int primary key identity(1,1),
	name varchar(50),
	cid int foreign key references Categories(id)
	);

create table Likes(
	uid int references Users(id),
	pid int references Pages(id),
	LDate date,
	primary key (uid,pid)
	);

create table Posts(
	id int primary key identity(1,1),
	PDate date,
	text varchar(50),
	noShares int,
	uid int foreign key references Users(id)
	);


create table Comments(
	id int primary key identity(1,1),
	text varchar(50),
	CDate date,
	flag bit,
	pid int foreign key references Posts(id)
	);