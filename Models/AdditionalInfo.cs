using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CummingsApplication.Models
{
    public class AdditionalInfo
    {
        public int Id { get; set; }

        public int BailBondId { get; set; }

        public string Info { get; set; }

        public bool DisclaimerAccepted { get; set; }

        public virtual BailBondInfo BailBondInfo { get; set; }
    }
}
