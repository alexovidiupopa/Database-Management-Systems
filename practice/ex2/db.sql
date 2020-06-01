create database projectmanagement 

use projectmanagement

create table Categories(
	id int primary key identity (1,1),
	description varchar(50)
);

create table Projects(
	id int primary key identity(1,1),
	name varchar(50),
	teamlead varchar(50),
	cid int foreign key references Categories(id)
	);

create table Developers(
	id int primary key identity(1,1),
	name varchar(50),
	age int, 
	experience tinyint,
	pid int foreign key references Projects(id), 
	joined date
	);

create table Tasks(
	id int primary key identity (1,1),
	description varchar(50),
	due date
	);

create table DevelopersTasks(
	did int references Developers(id),
	tid int references Tasks(id)
	);

create table Features( 
	id int primary key identity (1,1),
	name varchar(50), 
	estimation int, 
	tid int foreign key references Tasks(id)
	);
