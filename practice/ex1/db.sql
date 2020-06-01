--create database library

use library 

drop table if exists BooksReaders 
drop table if exists BooksAuthors 
drop table if exists Readers 
drop table if exists Books 
drop table if exists Libraries 
drop table if exists Publishers 
drop table if exists Authors 
drop table if exists Readers 
drop table if exists Affiliations

create table Libraries(
	id int primary key identity(1,1),
	name varchar(50), 
	location varchar(50)
);

create table Publishers(
	id int primary key identity(1,1),
	name varchar(50),
);

create table Books(
	id int primary key identity(1,1),
	title varchar(50),
	category varchar(50),
	lid int foreign key references Libraries(id),
	pid int foreign key references Publishers(id)
);

create table Authors(
	id int primary key identity(1,1),
	name varchar(50)
);

create table BooksAuthors(
	bid int references Books(id),
	aid int references Authors(id),
	primary key (bid,aid)
);


create table Affiliations( 
	id int primary key identity(1,1),
	name varchar(50)
);

create table Readers(
	id int primary key identity(1,1),
	preference varchar(50),
	aid int foreign key references Affiliations(id)
);

create table BooksReaders(
	bid int references Books(id),
	rid int references Readers(id),
	primary key (bid,rid)
);

insert into Publishers (name) values ('alex'),('dani');
insert into Books (title, category, lid, pid) values ('procesul', 'drama', 1,2), ('castelul', 'drama', 1, 1);