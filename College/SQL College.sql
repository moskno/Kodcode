-- ���� ������
create table Course
(Id int primary key identity,
Name varchar (100),
StartDate date,
Day varchar (255),
Hour time,
Price decimal (10, 2))

-- ���� ����� 
create table Lecturer
(Id int primary key identity,
Name varchar (100),
HourlyRate decimal (10, 2))

-- ���� ������ 
create table Subject
(Id int primary key identity,
Name varchar (100),
Hours int,
CourseId int,
foreign key (CourseId) references Course(Id),
LecturerId int,
foreign key (LecturerId) references Lecturer(Id))


-- ���� ������ ��������
create table Budget
(Id int primary key identity,
Cost decimal (10, 2),
Payment decimal (10, 2),
Debt decimal (10, 2))

-- ���� �������
create table Student
(Id int primary key identity,
Name varchar(100),
Password varchar(100),
Debt decimal (10, 2),
BudgetId int,
foreign key (BudgetId) references Budget(Id))


-- ���� ����� ��� ������� ���������
create table College
(Id int primary key identity,
CourseId int,
foreign key (CourseId) references Course(Id),
StudentId int,
foreign key (StudentId) references Student(Id))


-- ������ ������ ����� �� ������
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


-- ������ ������ �� ������� ������� ���
declare @student varchar

select Course.name as Name, Course.Price as Price, Course.StartDate as StartDate
from College
join Course on Course.id = College.CourseId
join Student on Student.id = College.StudentId
WHERE Student.Name = @student


-- ������ ����� ���� ������
declare @course varchar

INSERT INTO College (StudentId, CourseId)
SELECT Student.id, Course.id
FROM Student, Course
WHERE Student.Name = @student AND Course.Name = @course


-- ������ ������ �� ������� �� ����� 
declare @courseName varchar

SELECT Price, StartDate, Day, Hour FROM Course WHERE Name = @courseName


-- ������ ������ ��� ����� ������
declare @courseNam varchar

SELECT Student.Name 
FROM Subject Student
JOIN Course c ON Student.CourseId = CourseId
WHERE c.Name = @courseNam








-- ����� �����
insert into Student (name, Password) values ('moshe', '1234') 
-- ����� ������
insert into Course(name, StartDate, Day, Hour, Price) 
values 
('Programming', '01/09/2024', 'Sunday, Tuesday, Thursday', '09:00', 15000);
('Engineering', '01/09/2024', 'Monday, Wednesday, Thursday', '09:00', 12000),
('Architecture', '01/10/2024', 'Sunday, Tuesday, Thursday', '14:00', 13600),
('Lawyer', '01/10/2024', 'Tuesday, Wednesday, Thursday', '10:00', 14500);

