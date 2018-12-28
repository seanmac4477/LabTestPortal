CREATE DATABASE labTestPortal
GO

USE labTestPortal 

CREATE TABLE dbo.States  
   (
   state_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL, 
   States CHAR(2) 
   ) 
GO

CREATE TABLE dbo.Pers_Gender  
(
gender_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Gender CHAR(20) NOT NULL,
)
GO

CREATE TABLE dbo.Person  
(
person_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
state_id int NOT NULL,
gender_id int NOT NULL,
First_Name VARCHAR(50)NOT NULL,
Last_Name VARCHAR(50)NOT NULL,
DOB DATE NOT NULL,
foreign key (state_id) references states(state_id),
foreign key (gender_id) references Pers_Gender(gender_id),
)
GO

INSERT INTO Pers_Gender (Gender)

VALUES 
('M'),
('F'),
('Wish not to answer.')

INSERT INTO States (States)

VALUES 
('AL'),
('AK'),
('AS'),
('AZ'),
('AR'),
('CA'),
('CO'),
('CT'),
('DE'),
('DC'),
('FM'),
('FL'),
('GA'),
('GU'),
('HI'),
('ID'),
('IL'),
('IN'),
('IA'),
('KS'),
('KY'),
('LA'),
('ME'),
('MH'),
('MD'),
('MA'),
('MI'),
('MN'),
('MS'),
('MO'),
('MT'),
('NE'),
('NV'),
('NH'),
('NJ'),
('NM'),
('NY'),
('NC'),
('ND'),
('MP'),
('OH'),
('OK'),
('OR'),
('PW'),
('PA'),
('PR'),
('RI'),
('SC'),
('SD'),
('TN'),
('TX'),
('UT'),
('VT'),
('VI'),
('VA'),
('WA'),
('WV'),
('WI'),
('WY');
GO
