/*
  All sample data were suggested by ChatGPT.
  Reference: ChatGPT, OpenAI, https://chat.openai.com/
  Accessed: 2025-08-18
*/

--Counties
INSERT ALL
    INTO Counties (Name) VALUES ('Antrim')
    INTO Counties (Name) VALUES ('Armagh')
    INTO Counties (Name) VALUES ('Carlow')
    INTO Counties (Name) VALUES ('Cavan')
    INTO Counties (Name) VALUES ('Clare')
    INTO Counties (Name) VALUES ('Cork')
    INTO Counties (Name) VALUES ('Derry')
    INTO Counties (Name) VALUES ('Donegal')
    INTO Counties (Name) VALUES ('Down')
    INTO Counties (Name) VALUES ('Dublin')
    INTO Counties (Name) VALUES ('Fermanagh')
    INTO Counties (Name) VALUES ('Galway')
    INTO Counties (Name) VALUES ('Kerry')
    INTO Counties (Name) VALUES ('Kildare')
    INTO Counties (Name) VALUES ('Kilkenny')
    INTO Counties (Name) VALUES ('Laois')
    INTO Counties (Name) VALUES ('Leitrim')
    INTO Counties (Name) VALUES ('Limerick')
    INTO Counties (Name) VALUES ('Longford')
    INTO Counties (Name) VALUES ('Louth')
    INTO Counties (Name) VALUES ('Mayo')
    INTO Counties (Name) VALUES ('Meath')
    INTO Counties (Name) VALUES ('Monaghan')
    INTO Counties (Name) VALUES ('Offaly')
    INTO Counties (Name) VALUES ('Roscommon')
    INTO Counties (Name) VALUES ('Sligo')
    INTO Counties (Name) VALUES ('Tipperary')
    INTO Counties (Name) VALUES ('Tyrone')
    INTO Counties (Name) VALUES ('Waterford')
    INTO Counties (Name) VALUES ('Westmeath')
    INTO Counties (Name) VALUES ('Wexford')
    INTO Counties (Name) VALUES ('Wicklow')
SELECT * FROM dual;

INSERT INTO EventTypes (TypeID, Name) VALUES ('MU', 'Music');
INSERT INTO EventTypes (TypeID, Name) VALUES ('SP', 'Sports');
INSERT INTO EventTypes (TypeID, Name) VALUES ('TH', 'Theater');
INSERT INTO EventTypes (TypeID, Name) VALUES ('EX', 'Exhibition');
INSERT INTO EventTypes (TypeID, Name) VALUES ('FA', 'Festival');
INSERT INTO EventTypes (TypeID, Name) VALUES ('CO', 'Conference');
INSERT INTO EventTypes (TypeID, Name) VALUES ('ED', 'Education');
INSERT INTO EventTypes (TypeID, Name) VALUES ('CM', 'Comedy');
INSERT INTO EventTypes (TypeID, Name) VALUES ('DA', 'Dance');
INSERT INTO EventTypes (TypeID, Name) VALUES ('FI', 'Film');


INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (1, 'The Amazing Acrobats', 'A group of acrobats performing breathtaking aerial stunts.', 'John Doe', '555-1234', 'info@amazingacrobats.com', 1500.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (2, 'Melody Music Band', 'A classical music band with a variety of instruments.', 'Alice Smith', '555-5678', 'contact@melodyband.com', 2000.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (3, 'Dance Explosion', 'Professional dancers with a high-energy performance.', 'Bob Johnson', '555-8765', 'book@danceexplosion.com', 1200.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (4, 'Fire Breathers', 'Experts in fire breathing and fire performances for events.', 'Charlie Brown', '555-2345', 'info@firebreathers.com', 1800.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (5, 'Jungle Drummers', 'A percussion ensemble specializing in tribal rhythms.', 'Eve White', '555-6789', 'jungle@drummers.com', 1000.00, 'I', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (6, 'The Magic Show', 'A family-friendly magic show featuring illusionists and escape artists.', 'Sarah Williams', '555-1122', 'bookings@magicshow.com', 2500.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (7, 'Circus of Wonders', 'A circus featuring clowns, trapeze artists, and animal acts.', 'David Clark', '555-3344', 'contact@circuswonders.com', 3000.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (8, 'Rocking Rebels', 'A rock band known for their energetic live performances.', 'Tom Green', '555-4455', 'rock@rockingrebels.com', 3500.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (9, 'Illusionist Masters', 'A duo of illusionists who perform mind-bending tricks.', 'Laura Blue', '555-5566', 'info@illusionmasters.com', 2200.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (10, 'Comedian Extraordinaire', 'Stand-up comedy show featuring some of the best comedians in the country.', 'Marty Gold', '555-6677', 'comedy@comedianextraordinaire.com', 1800.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (11, 'The Fireworks Crew', 'Specializes in large-scale firework displays for celebrations.', 'Karen Black', '555-7788', 'info@fireworkscrew.com', 4000.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (12, 'Super Spinners', 'Professional yo-yo and spinning performers.', 'Chris Red', '555-8899', 'super@spinners.com', 1100.00, 'I', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (13, 'The Light Show', 'High-tech light and laser show for events and parties.', 'Olivia Stone', '555-9900', 'info@lightshow.com', 2700.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (14, 'Puppet Masters', 'Puppet show featuring intricate marionettes and storytelling.', 'Jake Miller', '555-1234', 'info@puppetmasters.com', 950.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (15, 'The Stilt Walkers', 'Performers who entertain with stilt walking and acrobatic routines.', 'Sophia Taylor', '555-4321', 'contact@stiltwalkers.com', 1400.00, 'I', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (16, 'Salsa Stars', 'Latin dance troupe that performs vibrant salsa and mambo routines.', 'Carlos Rivera', '555-5678', 'salsa@stars.com', 1600.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (17, 'The Stand-Up Trio', 'A group of stand-up comedians offering a variety of comedy acts.', 'Rita Green', '555-8765', 'book@standuptrio.com', 2000.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (18, 'Aerialists of the Sky', 'Performing arts group with breathtaking aerial silks and trapeze performances.', 'Diane Lee', '555-2345', 'contact@aerialists.com', 2300.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (19, 'Raging Rhythms', 'A high-energy drum group that plays everything from traditional to modern rhythms.', 'Henry Adams', '555-6789', 'raging@rhythms.com', 1700.00, 'I', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Performers (PerformerID, Name, Description, ContactPerson, ContactPhone, Email, PricePerDay, Status, CreateDate, UpdatedDate)
VALUES (20, 'The Juggling Masters', 'Juggling specialists who put on a fun and engaging show for all ages.', 'Mark Brown', '555-1123', 'book@jugglingmasters.com', 1300.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);




--Venues
INSERT INTO Venues 
(VenueID, Name, Description, ContactPerson, ContactPhone, Capacity, PricePerDay, Building, Street, City, County, Eircode, Status, CreateDate, UpdatedDate) 
VALUES 
(1, 'Concert Hall', 'A large venue for concerts', 'Laura Hayes', '+353874567890', 5000, 2500.00, 'Main Auditorium', '123 Music St', 'Dublin', 'Dublin', 'D01 A1B2', 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Venues 
VALUES 
(2, 'Art Gallery', 'Exhibits modern art', 'Sarah O`Connor', '+353876543210', 500, 1200.00, 'Art Building', '456 Art Rd', 'Cork', 'Cork', 'T12 C1D3', 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Venues 
VALUES 
(3, 'Community Center', 'Local events and activities', 'Mark Duffy', '+353869874562', 300, 800.00, 'Community Hall', '789 Community Ave', 'Galway', 'Galway', 'H91 G4F5', 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Venues 
VALUES 
(4, 'Theatre Royal', 'Venue for theatrical performances', 'Emma Kelly', '+353872134679', 500, 1800.00, 'Main Theatre', '101 Play St', 'Limerick', 'Limerick', 'V94 F2B9', 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Venues 
VALUES 
(5, 'Sports Arena', 'Home of many sporting events', 'John Murphy', '+353879654321', 1000, 3000.00, 'Arena Complex', '202 Sports Blvd', 'Belfast', 'Antrim', 'BT1 E4J5', 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Venues 
VALUES 
(6, 'Conference Center', 'Business and tech conferences', 'Aoife Byrne', '+353868439571', 100, 1500.00, 'Business Building', '303 Conference Rd', 'Waterford', 'Waterford', 'X91 K3N2', 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Venues 
VALUES 
(7, 'Open Air Stadium', 'Venue for large scale outdoor events', 'Liam Walsh', '+353875634109', 300, 2200.00, 'Main Stadium', '404 Stadium St', 'Cork', 'Cork', 'T12 C5E1', 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Venues 
VALUES 
(8, 'Cultural Center', 'Promotes cultural events', 'Laura Hayes', '+353874567890', 500, 1000.00, 'Cultural Hall', '505 Culture Way', 'Drogheda', 'Louth', 'A92 F2C3', 'A', SYSTIMESTAMP, SYSTIMESTAMP);

--Clients
INSERT INTO Clients 
(ClientID, OrganizationName, ContactPerson, Telephone, Email, Building, Street, City, County, Eircode, Status, CreateDate, UpdatedDate) 
VALUES 
(1, 'Bright Horizons Consulting', 'John Doe', '+353874567830', 'johndoe@example.com', '123 Elm St', 'Main St', 'Dublin', 'Dublin', 'D01 A1B2', 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Clients 
VALUES 
(2, 'GreenTech Solutions', 'Jane Smith', '+353864567891', 'janesmith@example.com', '456 Oak St', 'High St', 'Cork', 'Cork', 'T12 C1D3', 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Clients 
VALUES 
(3, 'Summit Innovations Ltd.', 'Michael Brown', '+353871567892', 'michaelbrown@example.com', '789 Pine St', 'Green St', 'Galway', 'Galway', 'H91 G4F5', 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Clients 
VALUES 
(4, 'BlueWave Enterprises', 'Emily White', '+353874566893', 'emilywhite@example.com', '101 Birch St', 'Park Ave', 'Limerick', 'Limerick', 'V94 F2B9', 'A', SYSTIMESTAMP, SYSTIMESTAMP);

INSERT INTO Clients 
VALUES 
(5, 'Phoenix Global Industries', 'David Green', '+353814567894', 'davidgreen@example.com', '202 Maple St', 'River Rd', 'Belfast', 'Antrim', 'BT1 E4J5', 'A', SYSTIMESTAMP, SYSTIMESTAMP);



-- Inserting events into the Event table
-- Insert for Rock Concert
INSERT INTO Events  (EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) VALUES (1, 'Rock Concert', 'MU', 1, 'A high-energy rock concert with loud music and live performances.', 1, TO_DATE('15-MAR-25', 'DD-MON-YY'), '19:30', 5, 1000, 500, 30.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 8);

-- Insert for Art Exhibition
INSERT INTO Events (EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) VALUES (2, 'Art Exhibition', 'EX', 2, 'Exhibition of contemporary art featuring modern artists.', 2, TO_DATE('10-APR-25', 'DD-MON-YY'), '18:00', 5, 500, 300, 15.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 13);

-- Insert for Soccer Match
INSERT INTO Events (EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) VALUES (3, 'Soccer Match', 'SP', 3, 'An exciting football match between two top teams.', 5, TO_DATE('20-MAY-25', 'DD-MON-YY'), '14:00', 3, 1500, 1000, 25.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 3);

-- Insert for Theater Play
INSERT INTO Events 
(EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) 
VALUES 
(4, 'Theater Play', 'TH', 4, 'A live theater performance with dramatic scenes and actors.', 4, TO_DATE('01-JUN-25', 'DD-MON-YY'), '20:00', 4, 250, 200, 45.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 10);

-- Insert for Tech Conference
INSERT INTO Events 
(EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) 
VALUES 
(5, 'Tech Conference', 'CO', 5, 'Technology and innovation conference featuring industry leaders.', 6, TO_DATE('10-JUL-25', 'DD-MON-YY'), '09:00', 3, 700, 500, 100.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 6);

-- 2023 Events

-- Jazz Night
INSERT INTO Events  
(EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) 
VALUES 
(101, 'Jazz Night', 'MU', 1, 'A relaxing night of smooth jazz.', 3, TO_DATE('12-MAY-23', 'DD-MON-YY'), '20:00', 3, 300, 200, 20.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 9);

-- Modern Art Fair
INSERT INTO Events  
(EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) 
VALUES 
(102, 'Modern Art Fair', 'EX', 2, 'Exhibition showcasing modern and abstract art.', 2, TO_DATE('13-MAY-23', 'DD-MON-YY'), '10:00', 6, 400, 350, 18.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 12);

-- City Marathon
INSERT INTO Events  
(EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) 
VALUES 
(103, 'City Marathon', 'SP', 3, 'Annual city marathon with thousands of runners.', 7, TO_DATE('15-SEP-23', 'DD-MON-YY'), '07:00', 6, 2000, 1800, 10.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 5);

-- Classic Drama
INSERT INTO Events  
(EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) 
VALUES 
(104, 'Classic Drama', 'TH', 4, 'A classic theater performance of Shakespearean drama.', 4, TO_DATE('22-OCT-23', 'DD-MON-YY'), '19:00', 3, 200, 150, 35.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 11);

-- Startup Summit
INSERT INTO Events  
(EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) 
VALUES 
(105, 'Startup Summit', 'CO', 5, 'A conference for startups, investors, and innovators.', 6, TO_DATE('30-NOV-23', 'DD-MON-YY'), '08:30', 4, 500, 450, 75.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 7);

-- 2024 Events

-- Indie Music Fest
INSERT INTO Events  
(EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) 
VALUES 
(106, 'Indie Music Fest', 'MU', 1, 'A celebration of indie bands and underground music.', 1, TO_DATE('05-APR-24', 'DD-MON-YY'), '16:00', 5, 1200, 900, 25.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 14);

-- Photography Expo
INSERT INTO Events  
(EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) 
VALUES 
(107, 'Photography Expo', 'EX', 2, 'A professional expo for photographers and gear enthusiasts.', 5, TO_DATE('06-MAY-24', 'DD-MON-YY'), '11:00', 5, 600, 500, 22.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 15);

-- Esports Championship
INSERT INTO Events  
(EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) 
VALUES 
(108, 'Esports Championship', 'SP', 3, 'National-level competitive gaming tournament.', 8, TO_DATE('18-JUL-24', 'DD-MON-YY'), '13:00', 4, 1000, 750, 40.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 2);

-- Broadway Revue
INSERT INTO Events  
(EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) 
VALUES 
(109, 'Broadway Revue', 'TH', 4, 'A showcase of Broadway hits performed live.', 3, TO_DATE('22-AUG-24', 'DD-MON-YY'), '19:30', 3, 350, 280, 50.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 16);

-- FutureTech Expo
INSERT INTO Events  
(EventID, Name, EventTypeID, ClientID, Description, VenueID, EventDate, StartTime, Duration, NumberOfTickets, AvailableTickets, TicketPrice, Status, CreateDate, UpdatedDate, PerformerID) 
VALUES 
(110, 'FutureTech Expo', 'CO', 5, 'Exploring future technologies in AI, robotics, and more.', 2, TO_DATE('14-NOV-24', 'DD-MON-YY'), '09:30', 5, 800, 700, 120.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP, 17);




--Bookings--
-- Booking 1
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate) VALUES (1, 'johndoe@example.com', 1, 2, 60.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 2
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (2, 'janesmith@example.com', 2, 3, 45.00, 'C', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 3
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (3, 'michaelbrown@example.com', 3, 4, 100.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 4
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (4, 'emilywhite@example.com', 4, 1, 45.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 5
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (5, 'davidgreen@example.com', 5, 2, 200.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 6
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (6, 'johndoe@example.com', 2, 5, 75.00, 'C', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 7
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (7, 'janesmith@example.com', 3, 2, 50.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 8
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (8, 'michaelbrown@example.com', 1, 6, 180.00, 'C', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 9
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (9, 'emilywhite@example.com', 2, 4, 60.00, 'C', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 10
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (10, 'davidgreen@example.com', 4, 3, 135.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 11
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (11, 'johndoe@example.com', 3, 5, 125.00, 'C', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 12
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (12, 'janesmith@example.com', 5, 3, 300.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 13
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (13, 'michaelbrown@example.com', 2, 2, 30.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 14
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (14, 'emilywhite@example.com', 5, 1, 100.00, 'C', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 15
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate)
VALUES (15, 'davidgreen@example.com', 1, 2, 60.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 16
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate) 
VALUES (16, 'alice.smith@example.com', 101, 3, 60.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 17
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate) 
VALUES (17, 'bob.johnson@example.com', 102, 2, 36.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 18
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate) 
VALUES (18, 'carol.white@example.com', 103, 4, 40.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 19
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate) 
VALUES (19, 'dave.brown@example.com', 104, 1, 35.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 20
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate) 
VALUES (20, 'ellen.davis@example.com', 105, 2, 150.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 21
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate) 
VALUES (21, 'frank.martin@example.com', 106, 3, 75.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 22
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate) 
VALUES (22, 'grace.miller@example.com', 107, 5, 110.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 23
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate) 
VALUES (23, 'hank.moore@example.com', 108, 2, 80.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 24
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate) 
VALUES (24, 'irene.lee@example.com', 109, 4, 200.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);

-- Booking 25
INSERT INTO Bookings (BookingID, Email, EventID, NumberOfTickets, Price, Status, CreateDate, UpdatedDate) 
VALUES (25, 'jack.turner@example.com', 110, 3, 360.00, 'A', SYSTIMESTAMP, SYSTIMESTAMP);
