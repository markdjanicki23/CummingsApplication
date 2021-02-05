using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CummingsApplication.Models
{
    public class BondTransfer
    {
        public int Id { get; set; }

        public int BailBondId { get; set; }

        public string Amount { get; set; }

        public string SerialNumber { get; set; }

        public virtual BailBondInfo BailBondInfo { get; set; }
    }
}
