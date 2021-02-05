using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CummingsApplication.Models
{
    public class Jail
    {
        public int Id { get; set; }

        public int BailBondId { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string County { get; set; }

        public virtual BailBondInfo BailBondInfo { get; set; }

    }
}
