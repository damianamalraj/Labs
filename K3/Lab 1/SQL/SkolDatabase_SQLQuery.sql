-- Create database
CREATE DATABASE SkolDatabas;
USE SkolDatabas;

-- Create table for Klasser
CREATE TABLE Klasser (
    KlassID INT PRIMARY KEY IDENTITY(1,1),
    KlassNamn NVARCHAR(50)
);

-- Create table for Elever
CREATE TABLE Elever (
    ElevID INT PRIMARY KEY IDENTITY(1,1),
    Namn NVARCHAR(100),
    Fodelsedatum DATE,
    KlassID INT,
    FOREIGN KEY (KlassID) REFERENCES Klasser(KlassID)
);

-- Create table for Kurser
CREATE TABLE Kurser (
    KursID INT PRIMARY KEY IDENTITY(1,1),
    KursNamn NVARCHAR(50)
);

-- Create table for Betyg
CREATE TABLE Betyg (
    BetygID INT PRIMARY KEY IDENTITY(1,1),
    ElevID INT,
    KursID INT,
    Betyg INT,
    FOREIGN KEY (ElevID) REFERENCES Elever(ElevID),
    FOREIGN KEY (KursID) REFERENCES Kurser(KursID)
);

-- Create table for Personal
CREATE TABLE Personal (
    PersonalID INT PRIMARY KEY IDENTITY(1,1),
    Namn NVARCHAR(100),
    Roll NVARCHAR(50)
);