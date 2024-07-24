-- טבלת קורסים
create table Course
(Id int primary key identity,
Name varchar (100),
StartDate date,
Day varchar (255),
Hour time,
Price decimal (10, 2))

-- טבלת מרצים 
create table Lecturer
(Id int primary key identity,
Name varchar (100),
HourlyRate decimal (10, 2))

-- טבלת נושאים 
create table Subject
(Id int primary key identity,
Name varchar (100),
Hours int,
CourseId int,
foreign key (CourseId) references Course(Id),
LecturerId int,
foreign key (LecturerId) references Lecturer(Id))


-- טבלת תשלומי סטודנטים
create table Budget
(Id int primary key identity,
Cost decimal (10, 2),
Payment decimal (10, 2),
Debt decimal (10, 2))

-- טבלת תלמידים
create table Student
(Id int primary key identity,
Name varchar(100),
Password varchar(100),
Debt decimal (10, 2),
BudgetId int,
foreign key (BudgetId) references Budget(Id))


-- טבלה מקשרת בין הקורסים והתלמידים
create table College
(Id int primary key identity,
CourseId int,
foreign key (CourseId) references Course(Id),
StudentId int,
foreign key (StudentId) references Student(Id))


-- בדיקת התאמת שם וסיסמה..
declare @password varchar (100), @name varchar (100)
declare @answer varchar (255)

IF exists (SELECT * FROM Student where Name = @name and Password = @password)
	begin
		select @answer = 'true';
	end
else
	begin
		select @answer = 'User does not exist, create a new user';
	end
	select @answer

-- הכנסת תלמיד
insert into Student (name, Password) values ('moshe', '1234') 
-- הכנסת קורסים
insert into Course(name, StartDate, Day, Hour, Price) 
values ('programming', '01/09/2024', 'Sunday, Tuesday, Thursday', '09:00', 15000) 
