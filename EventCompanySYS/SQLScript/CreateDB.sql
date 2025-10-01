DROP TABLE Bookings;
DROP TABLE Events;
DROP TABLE Performers;
DROP TABLE Clients;
DROP TABLE Venues;
DROP TABLE EventTypes;
DROP TABLE Counties;


CREATE TABLE Counties
(
    Name VARCHAR2(50) NOT NULL PRIMARY KEY
);

CREATE TABLE EventTypes
(
    TypeID VARCHAR2(2) NOT NULL PRIMARY KEY,
    Name VARCHAR2(50)
);
CREATE TABLE Venues
(
    VenueID NUMBER NOT NULL PRIMARY KEY,
    Name VARCHAR2(40),
    Description VARCHAR2(100),
    ContactPerson VARCHAR2(40),
    ContactPhone VARCHAR2(13),
    Capacity NUMBER(6),
    PricePerDay NUMBER(9,2),
    Building VARCHAR2(30),
    Street VARCHAR2(30),
    City VARCHAR2(25),
    County VARCHAR2(50),
    Eircode VARCHAR2(8),
    Status VARCHAR2(1),
    CreateDate TIMESTAMP,
    UpdatedDate TIMESTAMP,
    FOREIGN KEY (County) REFERENCES Counties(Name)
);

CREATE TABLE Performers (
    PerformerID INT NOT NULL PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Description VARCHAR2(100),
    ContactPerson VARCHAR2(40),
    ContactPhone VARCHAR2(13),
    Email VARCHAR(100) UNIQUE,
    PricePerDay NUMBER(9,2),
    Status VARCHAR2(1),
    CreateDate TIMESTAMP,
    UpdatedDate TIMESTAMP
);


CREATE TABLE Clients
(
    ClientID NUMBER PRIMARY KEY,
    OrganizationName VARCHAR2(50),
    ContactPerson VARCHAR2(40),
    Telephone VARCHAR2(13),
    Email VARCHAR2(50) UNIQUE,
    Building VARCHAR2(30),
    Street VARCHAR2(30),
    City VARCHAR2(25),
    County VARCHAR2(50),
    Eircode VARCHAR2(8),
    Status VARCHAR2(1),
    CreateDate TIMESTAMP,
    UpdatedDate TIMESTAMP,
    FOREIGN KEY (County) REFERENCES Counties(Name)
);

CREATE TABLE Events
(
    EventID NUMBER PRIMARY KEY,
    Name VARCHAR2(20), 
    EventTypeID VARCHAR2(2),
    ClientID NUMBER,
    Description VARCHAR2(100),
    VenueID NUMBER,
    EventDate DATE,
    PerformerID INT,
    StartTime VARCHAR2(5),
    Duration NUMBER(2),
    NumberOfTickets NUMBER,
    AvailableTickets NUMBER,
    TicketPrice NUMBER(6,2),
    Status VARCHAR2(1),
    CreateDate TIMESTAMP,
    UpdatedDate TIMESTAMP,
    FOREIGN KEY (EventTypeID) REFERENCES EventTypes(TypeID),
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
    FOREIGN KEY (VenueID) REFERENCES Venues(VenueID)
);

CREATE TABLE Bookings
(
    BookingID NUMBER PRIMARY KEY,
    Email VARCHAR2(50) NOT NULL,
    EventID NUMBER NOT NULL,
    NumberOfTickets NUMBER,
    Price NUMBER(6,2),
    Status VARCHAR(1) NOT NULL,
    CreateDate TIMESTAMP NOT NULL,
    UpdatedDate TIMESTAMP NOT NULL,
    FOREIGN KEY (EventID) REFERENCES Events(EventID)
);

