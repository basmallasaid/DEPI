create database BookStoreTest;

use BookStoreTest;

create table Books (
BookID int primary key,
Title varchar(100),
Author varchar(100),
PuplishedYear int,
Price decimal
)

insert into Books(BookID,Title,Author,PuplishedYear,Price)
values(1 , 'To Kill a Mockingbird', 'Harper Lee' , 1960 , 200);
insert into Books(BookID,Title,Author,PuplishedYear,Price)
values(2 , 'Pride and Prejudice', ' Jane Austen' , 1813 , 150);
insert into Books(BookID,Title,Author,PuplishedYear,Price)
values(3 , 'TThe Great Gatsby', 'Scott Fitzgerald' , 2000 , 250);
insert into Books(BookID,Title,Author,PuplishedYear,Price)
values(4 , 'The Catcher in the Rye', 'Salinger' , 2016 , 200);
insert into Books(BookID,Title,Author,PuplishedYear,Price)
values(5 , 'Hot Mess', 'jeff kinney' , 2000 , 100);
insert into Books(BookID,Title,Author,PuplishedYear,Price)
values(6 , 'Moby-Dick', 'Herman Melville' , 2015 , 160);

UPDATE Books
set Price = 130
where Title = 'jeff kinney';

delete from Books where Author='Jane Austen';

select * from Books order by PuplishedYear;

select * from Books where PuplishedYear<2000;