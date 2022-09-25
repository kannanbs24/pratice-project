create database school
create table student(student_id int primary key,student_name varchar(25),student_class int check(student_class<=12))
create table subjects(subjects_id int primary key,subjects_name varchar(25))

create table class(class_roomno int primary key,class_strength int)
insert into student values(1,'raji',12)
insert into student values(2,'kalai',11)
insert into student values(3,'senthil',8)
insert into student values(4,'raji',12)
insert into student values(5,'raji',10)

insert into subjects values(111,'tamil')
insert into subjects values(222,'english')
insert into subjects values(333,'maths')
insert into subjects values(444,'science')
insert into subjects values(555,'social')

insert into class values(01,45)
insert into class values(02,20)
insert into class values(03,34)
insert into class values(04,44)


select*from student
select*from subjects
select*from class