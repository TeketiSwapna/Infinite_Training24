//------------------------------------------------------------------------------
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
    
    public partial class GetTrainDetails_Result
    {
        public int TrainNumber { get; set; }
        public string TrainName { get; set; }
        public string FromDestination { get; set; }
        public string ToDestination { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string ClassOfTravel { get; set; }
        public string TrainStatus { get; set; }
        public Nullable<int> SeatsAvailable { get; set; }
    }
}
