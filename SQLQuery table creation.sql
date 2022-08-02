create table Company
(
	name varchar(255) not null primary key, 
	email varchar(255) not null,
	discription varchar(255),
	address varchar(255),
	contact numeric(12),
	logo image,
);

create table ServiceCenter
(
	cname varchar(255) not null foreign key references Company(name),
	name varchar(255) not null,
	address varchar(255),
	areaname varchar(255),
	city char(50),
	state char(100),
	phone numeric(12),
	email varchar(255) not null,
	discription varchar(500),
);