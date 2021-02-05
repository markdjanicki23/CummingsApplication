using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CummingsApplication.Models
{
    public class Defendant
    {
        public int Id { get; set; }

        public int BailBondId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string BirthDate { get; set; }

        public string SocialSecurityNumber { get; set; }

        public virtual BailBondInfo BailBondInfo { get; set; }

    }
}
