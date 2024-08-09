CREATE DATABASE RailwayReservation;
USE RailwayReservation;

CREATE TABLE Trains (
    TrainNumber INT PRIMARY KEY,
    TrainName NVARCHAR(100),
    FromDestination NVARCHAR(100),
    ToDestination NVARCHAR(100),
    Price DECIMAL(10, 2),
    ClassOfTravel NVARCHAR(10),
    TrainStatus NVARCHAR(10),
    SeatsAvailable INT
);
select * from Trains
select * from Cancellations
select * from Bookings

CREATE TABLE Bookings (
    BookingId INT IDENTITY PRIMARY KEY,
    TrainNumber INT,
    ClassOfTravel NVARCHAR(10),
    NumberOfSeats INT,
    BookingDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (TrainNumber) REFERENCES Trains(TrainNumber)
);
select * from Bookings

CREATE TABLE Cancellations (
    CancellationId INT IDENTITY PRIMARY KEY,
    BookingId INT,
    NumberOfSeatsCancelled INT,
    CancellationDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (BookingId) REFERENCES Bookings(BookingId)
);
select * from Cancellations

--Stored procedures 
--1.Adding new train 
CREATE or alter PROCEDURE AddTrain
    @TrainNumber INT,
    @TrainName NVARCHAR(100),
    @FromDestination NVARCHAR(100),
    @ToDestination NVARCHAR(100),
    @Price DECIMAL(10, 2),
    @ClassOfTravel NVARCHAR(10),
    @TrainStatus NVARCHAR(10),
    @SeatsAvailable INT
AS
BEGIN
    INSERT INTO Trains (TrainNumber, TrainName, FromDestination, ToDestination, Price, ClassOfTravel, TrainStatus, SeatsAvailable)
    VALUES (@TrainNumber, @TrainName, @FromDestination, @ToDestination, @Price, @ClassOfTravel, @TrainStatus, @SeatsAvailable);
END

--2.Update Train
CREATE or alter PROCEDURE UpdateTrain
    @TrainNumber INT,
    @TrainName NVARCHAR(100) = NULL,
    @FromDestination NVARCHAR(100) = NULL,
    @ToDestination NVARCHAR(100) = NULL,
    @Price DECIMAL(10, 2) = NULL,
    @ClassOfTravel NVARCHAR(10) = NULL,
    @TrainStatus NVARCHAR(10) = NULL,
    @SeatsAvailable INT = NULL
AS
BEGIN
    UPDATE Trains
    SET
        TrainName = ISNULL(@TrainName, TrainName),
        FromDestination = ISNULL(@FromDestination, FromDestination),
        ToDestination = ISNULL(@ToDestination, ToDestination),
        Price = ISNULL(@Price, Price),
        ClassOfTravel = ISNULL(@ClassOfTravel, ClassOfTravel),
        TrainStatus = ISNULL(@TrainStatus, TrainStatus),
        SeatsAvailable = ISNULL(@SeatsAvailable, SeatsAvailable)
    WHERE TrainNumber = @TrainNumber;
END

--3.Delete Train
CREATE or alter PROCEDURE DeleteTrain
    @TrainNumber INT
AS
BEGIN
    DELETE FROM Trains
    WHERE TrainNumber = @TrainNumber;
END


--4.Booking
CREATE PROCEDURE BookSeats
    @TrainNumber INT,
    @ClassOfTravel NVARCHAR(10),
    @NumberOfSeats INT,
    @BookingId INT OUTPUT
AS
BEGIN
    DECLARE @SeatsAvailable INT;

    -- Check if train exists and seats are available
    SELECT @SeatsAvailable = SeatsAvailable
    FROM Trains
    WHERE TrainNumber = @TrainNumber AND ClassOfTravel = @ClassOfTravel;

    IF @SeatsAvailable IS NULL
    BEGIN
        RAISERROR ('Train or Class of Travel not found.', 16, 1);
        RETURN;
    END

    IF @SeatsAvailable < @NumberOfSeats
    BEGIN
        RAISERROR ('Not enough seats available.', 16, 1);
        RETURN;
    END

    -- Insert booking
    INSERT INTO Bookings (TrainNumber, ClassOfTravel, NumberOfSeats)
    VALUES (@TrainNumber, @ClassOfTravel, @NumberOfSeats);

    SET @BookingId = SCOPE_IDENTITY();

    -- Update available seats
    UPDATE Trains
    SET SeatsAvailable = SeatsAvailable - @NumberOfSeats
    WHERE TrainNumber = @TrainNumber AND ClassOfTravel = @ClassOfTravel;
END

--5.Cancel  Booking
CREATE or alter PROCEDURE CancelBooking
    @BookingId INT,
    @NumberOfSeatsCancelled INT
AS
BEGIN
    DECLARE @TrainNumber INT;
    DECLARE @ClassOfTravel NVARCHAR(10);
    DECLARE @NumberOfSeats INT;

    -- Get booking details
    SELECT @TrainNumber = TrainNumber, @ClassOfTravel = ClassOfTravel, @NumberOfSeats = NumberOfSeats
    FROM Bookings
    WHERE BookingId = @BookingId;

    IF @TrainNumber IS NULL
    BEGIN
        RAISERROR ('Booking not found.', 16, 1);
        RETURN;
    END

    IF @NumberOfSeatsCancelled > @NumberOfSeats
    BEGIN
        RAISERROR ('Cannot cancel more seats than booked.', 16, 1);
        RETURN;
    END

    -- Insert cancellation
    INSERT INTO Cancellations (BookingId, NumberOfSeatsCancelled)
    VALUES (@BookingId, @NumberOfSeatsCancelled);

    -- Update available seats
    UPDATE Trains
    SET SeatsAvailable = SeatsAvailable + @NumberOfSeatsCancelled
    WHERE TrainNumber = @TrainNumber AND ClassOfTravel = @ClassOfTravel;

    -- Update booking seats
    UPDATE Bookings
    SET NumberOfSeats = NumberOfSeats - @NumberOfSeatsCancelled
    WHERE BookingId = @BookingId;
END

--5.Get Train Details
CREATE or alter PROCEDURE GetTrainDetails
    @TrainNumber INT
AS
BEGIN
    SELECT *
    FROM Trains
    WHERE TrainNumber = @TrainNumber;
END

--6.Get Booking Details
CREATE or alter PROCEDURE GetBookingDetails
    @BookingId INT
AS
BEGIN
    SELECT *
    FROM Bookings
    WHERE BookingId = @BookingId;
END

--7.Get Cancellation Details
CREATE or alter PROCEDURE GetCancellationDetails
    @CancellationId INT
AS
BEGIN
    SELECT *
    FROM Cancellations
    WHERE CancellationId = @CancellationId;
END


select * from trains






