using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CummingsApplication.Models
{
    public class ProvidingAgency
    {
        public int Id { get; set; }

        public int BailBondId { get; set; }

        public string AgentName { get; set; }

        public string AgencyName { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string MobileNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string County { get; set; }

        public virtual BailBondInfo BailBondInfo { get; set; }
    }
}
