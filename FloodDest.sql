CREATE DATABASE FloodDestruction
CREATE TABLE HomeFloodInfo(
    pid INT PRIMARY KEY IDENTITY(1,1),
    heading VARCHAR(200),
    info VARCHAR(1000),
    imageURL VARCHAR(100)
)

CREATE PROC Sp_AddHomeFloodInfo
@heading varchar(200),
@info varchar(1000),
@imageURL varchar(100)
AS
BEGIN
INSERT INTO HomeFloodInfo(heading, info, imageURL)
VALUES(@heading, @info, @imageURL)
END

CREATE PROC Sp_GetHomeFloodInfo
AS BEGIN
SELECT * FROM HomeFloodInfo
END

CREATE PROC Sp_DeleteHomeFloodInfo
@pid int
AS
BEGIN
DELETE FROM HomeFloodInfo
WHERE pid=@pid
END

select * from HomeFloodInfo
truncate table HomeFloodInfo
-------------------------------------------------
CREATE TABLE Larkana(
    pid INT PRIMARY KEY IDENTITY(1,1),
    heading VARCHAR(200),
    info VARCHAR(1000),
    imageURL3 VARCHAR(100)
)

CREATE PROC Sp_Larkana
@heading varchar(200),
@info varchar(1000),
@imageURL3 varchar(100)
AS
BEGIN
INSERT INTO Larkana(heading, info, imageURL3)
VALUES(@heading, @info, @imageURL3)
END

Alter PROC Sp_GetLarkana
AS BEGIN
SELECT * FROM Larkana
END

CREATE PROC  Sp_DeleteLarkana
@pid int
AS
BEGIN
DELETE FROM Larkana
WHERE pid=@pid
END

select * from Larkana
truncate table Larkana


-------------------------------------------------
CREATE TABLE Sukkur(
    pid INT PRIMARY KEY IDENTITY(1,1),
    heading VARCHAR(200),
    info VARCHAR(1000),
    imageURL4 VARCHAR(100)
)

CREATE PROC Sp_AddSukkur
@heading varchar(200),
@info varchar(1000),
@imageURL4 varchar(100)
AS
BEGIN
INSERT INTO Sukkur(heading, info, imageURL4)
VALUES(@heading, @info, @imageURL4)
END

Create PROC Sp_GetSukkur
AS BEGIN
SELECT * FROM Sukkur
END

CREATE PROC  Sp_DeleteSukkur
@pid int
AS
BEGIN
DELETE FROM Sukkur
WHERE pid=@pid
END

select * from Sukkur
-------------------------------------------------



CREATE TABLE Shikarpur(
    pid INT PRIMARY KEY IDENTITY(1,1),
    heading VARCHAR(200),
    info VARCHAR(1000),
    imageURL5 VARCHAR(100)
)

CREATE PROC Sp_AddShikarpur
@heading varchar(200),
@info varchar(1000),
@imageURL5 varchar(100)
AS
BEGIN
INSERT INTO Shikarpur(heading, info, imageURL5)
VALUES(@heading, @info, @imageURL5)
END

Create PROC Sp_GetShikarpur
AS BEGIN
SELECT * FROM Shikarpur
END

CREATE PROC  Sp_DeleteShikarpur
@pid int
AS
BEGIN
DELETE FROM Shikarpur
WHERE pid=@pid
END

select * from Shikarpur

---------------------------------------------
CREATE TABLE PakFloodInfo(
    pid INT PRIMARY KEY IDENTITY(1,1),
    heading VARCHAR(200),
    info VARCHAR(1000),
    imageURL6 VARCHAR(100)
)

CREATE PROC Sp_AddPakFloodInfo
@heading varchar(200),
@info varchar(1000),
@imageURL6 varchar(100)
AS
BEGIN
INSERT INTO PakFloodInfo(heading, info, imageURL6)
VALUES(@heading, @info, @imageURL6)
END

CREATE PROC Sp_GetPakFloodInfo
AS BEGIN
SELECT * FROM PakFloodInfo
END

CREATE PROC Sp_DeletePakFloodInfo
@pid int
AS
BEGIN
DELETE FROM PakFloodInfo
WHERE pid=@pid
END

select * from PakFloodInfo