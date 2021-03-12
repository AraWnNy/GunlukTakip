create database Daily_Schedule

create table Schedules
(
Id int identity(1,1) not null,
EventId int not null,
Date datetime not null,
EventStatus bit not null,
primary key(Id),
foreign key(EventId) references Events(Id)
)

create table Events
(
Id int identity(1,1) not null,
EventName nvarchar(255) not null,
primary key(Id)
)