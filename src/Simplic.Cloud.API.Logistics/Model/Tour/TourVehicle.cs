using System;

namespace Simplic.Cloud.API.Logistics
{
    public class TourVehicleModel
    {
        public Guid Id { get; set; }
        public string MatchCode { get; set; }
        public TourRegistrationPlateModel RegistrationPlate { get; set; }
    }
}