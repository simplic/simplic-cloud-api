using Simplic.Cloud.API.BusinessPartner;
using System.Collections.Generic;

namespace Simplic.Cloud.API.HR
{
    public class EmployeeModel : ContactModel
    {
        public IList<EmployeeModel> Employments { get; set; } = new List<EmployeeModel>();
    }
}
