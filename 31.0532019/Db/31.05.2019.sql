create database News

create table News
(
Id int identity(1,1) primary key,
Content text not null,
Header nvarchar(max) not null,
CreateDate Date not null,
)
create table Users
(
Id int identity(1,1) primary key,
Username nvarchar(20) not null,
Password nvarchar(20) not null,
)
create table Comment
(
Id int identity(1,1) primary key,
Content text not null,
NewsId int foreign key references News(Id) on delete cascade,
UserId int foreign key references Users(Id)
)


create trigger UserDelete
on Users
instead of delete
as
declare @tmp nvarchar(100);
select @tmp= deleted.Id from deleted
delete from  Comment   where @tmp=Comment.UserId   


insert into Users(Username,Password)
values('Nurullah','Nurullah123'),
('Anar','Anar123'),
('Islam','Islam123')