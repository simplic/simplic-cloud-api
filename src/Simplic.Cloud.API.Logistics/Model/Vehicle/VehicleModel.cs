using System;
using System.Collections.Generic;

namespace Simplic.Cloud.API.Logistics
{
    public class VehicleModel
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public bool IsDeleted { get; set; }
        public string MatchCode { get; set; }
        public string RegistrationIdentifier { get; set; }
        public VehicleType Type { get; set; }
        public VehicleStatus Status { get; set; }
        public DateTime? ConstructionDate { get; set; }
        public double EmptyWeight { get; set; }
        public short? Length { get; set; }
        public short? Width { get; set; }
        public short? Height { get; set; }
        public RegistrationPlateModel RegistrationPlate { get; set; }
        public VehicleTelematicModel Telematic { get; set; }
        public IList<Guid> DefaultDriver { get; set; }
        public IList<Guid> DefaultTrailer { get; set; }
    }
}
