﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RailwayReservation
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RailwayReservationEntities : DbContext
    {
        public RailwayReservationEntities()
            : base("name=RailwayReservationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Cancellation> Cancellations { get; set; }
        public virtual DbSet<Train> Trains { get; set; }
    
        public virtual int AddTrain(Nullable<int> trainNumber, string trainName, string fromDestination, string toDestination, Nullable<decimal> price, string classOfTravel, string trainStatus, Nullable<int> seatsAvailable)
        {
            var trainNumberParameter = trainNumber.HasValue ?
                new ObjectParameter("TrainNumber", trainNumber) :
                new ObjectParameter("TrainNumber", typeof(int));
    
            var trainNameParameter = trainName != null ?
                new ObjectParameter("TrainName", trainName) :
                new ObjectParameter("TrainName", typeof(string));
    
            var fromDestinationParameter = fromDestination != null ?
                new ObjectParameter("FromDestination", fromDestination) :
                new ObjectParameter("FromDestination", typeof(string));
    
            var toDestinationParameter = toDestination != null ?
                new ObjectParameter("ToDestination", toDestination) :
                new ObjectParameter("ToDestination", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            var classOfTravelParameter = classOfTravel != null ?
                new ObjectParameter("ClassOfTravel", classOfTravel) :
                new ObjectParameter("ClassOfTravel", typeof(string));
    
            var trainStatusParameter = trainStatus != null ?
                new ObjectParameter("TrainStatus", trainStatus) :
                new ObjectParameter("TrainStatus", typeof(string));
    
            var seatsAvailableParameter = seatsAvailable.HasValue ?
                new ObjectParameter("SeatsAvailable", seatsAvailable) :
                new ObjectParameter("SeatsAvailable", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddTrain", trainNumberParameter, trainNameParameter, fromDestinationParameter, toDestinationParameter, priceParameter, classOfTravelParameter, trainStatusParameter, seatsAvailableParameter);
        }
    
        public virtual int BookSeats(Nullable<int> trainNumber, string classOfTravel, Nullable<int> numberOfSeats, ObjectParameter bookingId)
        {
            var trainNumberParameter = trainNumber.HasValue ?
                new ObjectParameter("TrainNumber", trainNumber) :
                new ObjectParameter("TrainNumber", typeof(int));
    
            var classOfTravelParameter = classOfTravel != null ?
                new ObjectParameter("ClassOfTravel", classOfTravel) :
                new ObjectParameter("ClassOfTravel", typeof(string));
    
            var numberOfSeatsParameter = numberOfSeats.HasValue ?
                new ObjectParameter("NumberOfSeats", numberOfSeats) :
                new ObjectParameter("NumberOfSeats", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BookSeats", trainNumberParameter, classOfTravelParameter, numberOfSeatsParameter, bookingId);
        }
    
        public virtual int CancelBooking(Nullable<int> bookingId, Nullable<int> numberOfSeatsCancelled)
        {
            var bookingIdParameter = bookingId.HasValue ?
                new ObjectParameter("BookingId", bookingId) :
                new ObjectParameter("BookingId", typeof(int));
    
            var numberOfSeatsCancelledParameter = numberOfSeatsCancelled.HasValue ?
                new ObjectParameter("NumberOfSeatsCancelled", numberOfSeatsCancelled) :
                new ObjectParameter("NumberOfSeatsCancelled", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CancelBooking", bookingIdParameter, numberOfSeatsCancelledParameter);
        }
    
        public virtual int DeleteTrain(Nullable<int> trainNumber)
        {
            var trainNumberParameter = trainNumber.HasValue ?
                new ObjectParameter("TrainNumber", trainNumber) :
                new ObjectParameter("TrainNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTrain", trainNumberParameter);
        }
    
        public virtual ObjectResult<GetBookingDetails_Result> GetBookingDetails(Nullable<int> bookingId)
        {
            var bookingIdParameter = bookingId.HasValue ?
                new ObjectParameter("BookingId", bookingId) :
                new ObjectParameter("BookingId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBookingDetails_Result>("GetBookingDetails", bookingIdParameter);
        }
    
        public virtual ObjectResult<GetCancellationDetails_Result> GetCancellationDetails(Nullable<int> cancellationId)
        {
            var cancellationIdParameter = cancellationId.HasValue ?
                new ObjectParameter("CancellationId", cancellationId) :
                new ObjectParameter("CancellationId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCancellationDetails_Result>("GetCancellationDetails", cancellationIdParameter);
        }
    
        public virtual ObjectResult<GetTrainDetails_Result> GetTrainDetails(Nullable<int> trainNumber)
        {
            var trainNumberParameter = trainNumber.HasValue ?
                new ObjectParameter("TrainNumber", trainNumber) :
                new ObjectParameter("TrainNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTrainDetails_Result>("GetTrainDetails", trainNumberParameter);
        }
    
        public virtual int UpdateTrain(Nullable<int> trainNumber, string trainName, string fromDestination, string toDestination, Nullable<decimal> price, string classOfTravel, string trainStatus, Nullable<int> seatsAvailable)
        {
            var trainNumberParameter = trainNumber.HasValue ?
                new ObjectParameter("TrainNumber", trainNumber) :
                new ObjectParameter("TrainNumber", typeof(int));
    
            var trainNameParameter = trainName != null ?
                new ObjectParameter("TrainName", trainName) :
                new ObjectParameter("TrainName", typeof(string));
    
            var fromDestinationParameter = fromDestination != null ?
                new ObjectParameter("FromDestination", fromDestination) :
                new ObjectParameter("FromDestination", typeof(string));
    
            var toDestinationParameter = toDestination != null ?
                new ObjectParameter("ToDestination", toDestination) :
                new ObjectParameter("ToDestination", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            var classOfTravelParameter = classOfTravel != null ?
                new ObjectParameter("ClassOfTravel", classOfTravel) :
                new ObjectParameter("ClassOfTravel", typeof(string));
    
            var trainStatusParameter = trainStatus != null ?
                new ObjectParameter("TrainStatus", trainStatus) :
                new ObjectParameter("TrainStatus", typeof(string));
    
            var seatsAvailableParameter = seatsAvailable.HasValue ?
                new ObjectParameter("SeatsAvailable", seatsAvailable) :
                new ObjectParameter("SeatsAvailable", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTrain", trainNumberParameter, trainNameParameter, fromDestinationParameter, toDestinationParameter, priceParameter, classOfTravelParameter, trainStatusParameter, seatsAvailableParameter);
        }
    }
}
