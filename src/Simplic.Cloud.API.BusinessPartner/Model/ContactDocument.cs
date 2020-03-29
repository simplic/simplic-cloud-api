using System;
using System.Collections.Generic;

namespace Simplic.Cloud.API.BusinessPartner
{
    public class ContactModel
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public bool IsDeleted { get; set; }
        public string Matchcode { get; set; }
        public ContactType Type { get; set; }
        public List<ContactCategory> Categories { get; set; }
        public List<AddressModel> Addresses { get; set; }
    }
}
