create table tableMain
(
	MainID int primary key identity,
	aDate date,
	aTime Varchar (15),
	TableName varchar (15),
	WaiterName varchar (25),
	status varchar (15),
	orderType varchar (15),
	total float,
	received float,
	change float,
)

create table tableDetails
(
	DetailID int primary key identity,
	MainID int,
	proID int,
	qty int,
	price float,
	amount float
)

truncate table tableDetails;
truncate table tableMain;

select * from tableMain m
inner join tableDetails d on m.MainID = d.MainID