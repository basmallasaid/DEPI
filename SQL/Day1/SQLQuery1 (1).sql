use master;
create Table Students(
 StudentID INT PRIMARY KEY,
 FirstName varchar(100),
 LastName varchar(100),
 Age int,
 Grade varchar(150)
)
insert into Students (StudentID , FirstName , LastName,Age, Grade)
values (1,'basmala','said',21,'A')
insert into Students (StudentID , FirstName , LastName,Age, Grade)
values (2,'Muhammed','Elboshy',25,'A')
insert into Students (StudentID , FirstName , LastName,Age, Grade)
values (3,'Muhammed','Ahmed',20,'B')
insert into Students (StudentID , FirstName , LastName,Age, Grade)
values (4,'Ali','kamal',24,'B')
insert into Students (StudentID , FirstName , LastName,Age, Grade)
values (5,'Nora','Mustafa',23,'C')
select *from Students 
select FirstName ,LastName from Students
select *from Students 
where Age>18
select *from Students 
where Grade='A'