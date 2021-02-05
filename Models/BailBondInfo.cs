using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CummingsApplication.Models
{
    public class BailBondInfo
    {
        public int Id { get; set; }

        public int ProvidingAgencyId { get; set; }

        public int JailId { get; set; }

        public int BondTransferId { get; set; }

        public int RequestingAgencyId { get; set; }

        public int DefendantId { get; set; }

        public int IndemnitorId { get; set; }

        public int AdditionalInfoId { get; set; }

        public virtual ProvidingAgency ProvidingAgency { get; set; }
        public virtual Jail Jail { get; set; }
        public virtual BondTransfer BondTransfer { get; set; }
        public virtual RequestingAgency RequestingAgency { get; set; }
        public virtual Defendant Defendant { get; set; }
        public virtual Indemnitor Indemnitor { get; set; }
        public virtual AdditionalInfo AdditionalInfo { get; set; }
    }
}