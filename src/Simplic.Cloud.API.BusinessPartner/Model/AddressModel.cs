using System.Collections.Generic;

namespace Simplic.Cloud.API.BusinessPartner
{
    /// <summary>
    /// Represents an address
    /// </summary>
    public class AddressModel
    {
        public AddressType Type { get; set; }
        public string Salutation { get; set; }
        public string LetterSalutation { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string FriendlyName { get; set; }
        public string Additional01 { get; set; }
        public string Additional02 { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string CountryIso { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<MailAddressModel> MailAddresses { get; set; } = new List<MailAddressModel>();
        public List<PhoneNumberModel> PhoneNumbers { get; set; } = new List<PhoneNumberModel>();
        public List<OpeningHourModel> OpeningHours { get; set; } = new List<OpeningHourModel>();
        public List<GeoFenceModel> GeoFences { get; set; } = new List<GeoFenceModel>();

    }
}
