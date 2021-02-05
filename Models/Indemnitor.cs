using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CummingsApplication.Models
{
    public class Indemnitor
    {
        public int Id { get; set; }

        public int BailBondId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Alias { get; set; }

        public string BirthDate { get; set; }

        public string Gender { get; set; }

        public string Ethnicity { get; set; }

        public string SocialSecurityNumber { get; set; }

        public string EmailAddress { get; set; }

        public string MobilePhoneNumber { get; set; }

        public virtual BailBondInfo BailBondInfo { get; set; }

    }
}
