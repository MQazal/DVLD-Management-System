CREATE DATABASE DVLD_Database

USE DVLD_Database;

CREATE TABLE Countries(
CountryID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
CountryName VARCHAR(50) NOT NULL
);

CREATE TABLE People(
PersonID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
NationalNumber NVARCHAR(3) UNIQUE NOT NULL,
FirstName NVARCHAR(20) NOT NULL,
SecondName NVARCHAR(20) NOT NULL,
ThirdName NVARCHAR(20) NOT NULL,
LastName NVARCHAR(20) NOT NULL,
DateOfBirth DATE,
Gender TINYINT NOT NULL,
Phone VARCHAR(14) NOT NULL,
Email VARCHAR(250) NULL,
Address NVARCHAR(100) NOT NULL,
ImagePath NVARCHAR(250) NULL,
CountryID INT REFERENCES Countries(CountryID)
);

CREATE TABLE Users(
UserID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Username VARCHAR(15) NOT NULL,
Password VARCHAR(8) NOT NULL,
IsActive BIT NOT NULL,
PersonID INT REFERENCES People(PersonID) NOT NULL
);

CREATE TABLE ApplicationTypes(
ApplicationTypeID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ApplicationTitle NVARCHAR(70),
ApplicationFees DECIMAL(4,2)
);

CREATE TABLE TestTypes(
TestTypeID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
TestTypeTitle NVARCHAR(70) NOT NULL,
TestTypeDescription NVARCHAR(500) NOT NULL,
TestTypeFees DECIMAL(4,2)
);

CREATE TABLE LicenseClasses(
ClassID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ClassName NVARCHAR(70) NOT NULL,
ClassDescription NVARCHAR(500) NOT NULL,
MinimumAllowedAge TINYINT NOT NULL,
DefalutValidityLength TINYINT NOT NULL,
ClassFees DECIMAL(5,2) NOT NULL
);

CREATE TABLE Applications(
ApplicationID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ApplicationDate DATE NOT NULL,
ApplicationStatus TINYINT NOT NULL,
LastStatusDate DATE NOT NULL,
PaidFees DECIMAL(5,2) NOT NULL,
ApplicationTypeID INT REFERENCES ApplicationTypes(ApplicationTypeID) NOT NULL,
ApplicantPersonID INT REFERENCES People(PersonID) NOT NULL,
CreatedByUserID INT REFERENCES Users(UserID) NOT NULL
);

CREATE TABLE LocalDrivingLicenseApplications(
LocalDrivingLicenseApplicationID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ApplicationID INT REFERENCES Applications(ApplicationID) NOT NULL,
ClassID INT REFERENCES LicenseClasses(ClassID) NOT NULL
);

CREATE TABLE TestAppointments(
AppointmentID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
TestTypeID INT REFERENCES TestTypes(TestTypeID) NOT NULL,
LocalDrivingLicenseApplicationID INT REFERENCES LocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID) NOT NULL,
AppointmentDate DATE NOT NULL,
PaidFees DECIMAL NOT NULL,
CreatedByUserID INT REFERENCES Users(UserID) NOT NULL,
IsLocked BIT NOT NULL
);

CREATE TABLE Tests(
TestID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
AppointmentID INT REFERENCES TestAppointments(AppointmentID) NOT NULL,
TestResult BIT NOT NULL,
Notes NVARCHAR(500),
CreatedByUserID INT REFERENCES Users(UserID) NOT NULL
);

CREATE VIEW vw_LocalDrivingLicenseApplicationDetails AS
SELECT
    LDLA.LocalDrivingLicenseApplicationID,
    LC.ClassName,
    P.NationalNumber,
    CONCAT(P.FirstName, ' ', P.SecondName, ' ', P.ThirdName, ' ', P.LastName) AS FullName,
    A.ApplicationDate,
    (
        SELECT COUNT(T.TestResult)
        FROM Tests T
        JOIN TestAppointments TA ON T.AppointmentID = TA.AppointmentID
        WHERE TA.LocalDrivingLicenseApplicationID = LDLA.LocalDrivingLicenseApplicationID
          AND T.TestResult = 1
    ) AS NumberOfPassedTests,
    CASE
        WHEN A.ApplicationStatus = 1 THEN 'New'
        WHEN A.ApplicationStatus = 2 THEN 'Canceled'
        ELSE 'Completed'
    END AS Status
FROM LocalDrivingLicenseApplications LDLA
JOIN LicenseClasses LC ON LDLA.ClassID = LC.ClassID
JOIN Applications A ON LDLA.ApplicationID = A.ApplicationID
JOIN People P ON A.ApplicantPersonID = P.PersonID;

CREATE VIEW AS
SELECT TestAppointments.AppointmentID,
TestAppointments.LocalDrivingLicenseApplicationID,
TestTypes.TestTypeTitle AS TestTypeTitle,
ClassName,
AppointmentDate,
TestAppointments.PaidFees,
CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.ThirdName, ' ', People.LastName) AS FullName,
TestAppointments.IsLocked
FROM TestAppointments
JOIN LocalDrivingLicenseApplications
ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
JOIN LicenseClasses ON LocalDrivingLicenseApplications.ClassID = LicenseClasses.ClassID
JOIN TestTypes ON TestAppointments.TestTypeID = TestTypes.TestTypeID
JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
JOIN People ON Applications.ApplicantPersonID = People.PersonID;

CREATE VIEW TestAppointments_View AS
SELECT 
    TestAppointments.AppointmentID,
    TestAppointments.LocalDrivingLicenseApplicationID,
    TestTypes.TestTypeTitle AS TestTypeTitle,
    LicenseClasses.ClassName,
    TestAppointments.AppointmentDate,
    TestAppointments.PaidFees,
    CONCAT(
        People.FirstName, ' ',
        People.SecondName, ' ',
        People.ThirdName, ' ',
        People.LastName
    ) AS FullName,
    TestAppointments.IsLocked
FROM TestAppointments
JOIN LocalDrivingLicenseApplications
    ON TestAppointments.LocalDrivingLicenseApplicationID =
       LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
JOIN LicenseClasses
    ON LocalDrivingLicenseApplications.ClassID =
       LicenseClasses.ClassID
JOIN TestTypes
    ON TestAppointments.TestTypeID =
       TestTypes.TestTypeID
JOIN Applications
    ON LocalDrivingLicenseApplications.ApplicationID =
       Applications.ApplicationID
JOIN People
    ON Applications.ApplicantPersonID =
       People.PersonID;

CREATE TABLE Drivers(
DriverID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
PersonID INT REFERENCES People(PersonID) NOT NULL,
CreatedByUserID INT REFERENCES Users(UserID) NOT NULL,
CreatedDate DATE NOT NULL
);

CREATE TABLE Licenses(
LicenseID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ApplicationID INT REFERENCES Applications(ApplicationID) NOT NULL,
DriverID INT REFERENCES Drivers(DriverID) NOT NULL,
LicenseClassID INT REFERENCES LicenseClasses(ClassID) NOT NULL,
IssueDate DATE NOT NULL,
ExpirationDate DATE NOT NULL,
Notes NVARCHAR(100) NULL,
PaidFees DECIMAL(5,2) NOT NULL,
IsActive BIT NOT NULL,
IssueReason TINYINT NOT NULL,
CreatedByUserID INT REFERENCES Users(UserID) NOT NULL
);

CREATE VIEW Drivers_View AS
SELECT 
    D.DriverID,
    D.PersonID,
    P.NationalNumber,
    CONCAT(
        P.FirstName, ' ',
        P.SecondName, ' ',
        P.ThirdName, ' ',
        P.LastName
    ) AS FullName,
    D.CreatedDate,
    COUNT(L.LicenseID) AS NumberOfActiveLicenses
FROM Drivers D
JOIN People P
    ON D.PersonID = P.PersonID
LEFT JOIN Licenses L
    ON D.DriverID = L.DriverID
    AND L.IsActive = 1
GROUP BY
    D.DriverID,
    D.PersonID,
    P.NationalNumber,
    P.FirstName,
    P.SecondName,
    P.ThirdName,
    P.LastName,
    D.CreatedDate;

CREATE TABLE InternationalLicenses(
InternationalLicenseID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ApplicationID INT REFERENCES Applications(ApplicationID) NOT NULL,
DriverID INT REFERENCES Drivers(DriverID) NOT NULL,
IssuedUsingLocalLicenseID INT REFERENCES Licenses(LicenseID) NOT NULL,
IssueDate DATE NOT NULL,
ExpirationDate DATE NOT NULL,
IsActive BIT NOT NULL,
CreatedByUserID INT REFERENCES Users(UserID) NOT NULL
);

CREATE TABLE DetainedLicenses(
DetainID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
LicenseID INT REFERENCES Licenses(LicenseID) NOT NULL,
DetainDate DATE NOT NULL,
FineFees DECIMAL NOT NULL,
CreatedByUserID INT REFERENCES Users(UserID) NOT NULL,
IsReleased BIT NOT NULL,
ReleaseDate DATE NULL,
ReleasedByUserID INT REFERENCES Users(UserID) NULL,
ReleaseApplicationID INT REFERENCES Applications(ApplicationID) NULL
);

CREATE VIEW detainedLicenses_View AS
SELECT DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate,
DetainedLicenses.IsReleased, DetainedLicenses.FineFees, DetainedLicenses.ReleaseDate, People.NationalNumber,
CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.ThirdName, ' ', People.LastName) AS FullName,
DetainedLicenses.ReleaseApplicationID
FROM DetainedLicenses
JOIN Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID
JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
JOIN People ON Drivers.PersonID = People.PersonID;
