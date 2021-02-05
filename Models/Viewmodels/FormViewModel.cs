using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CummingsApplication.Models.Viewmodels
{
    public class FormViewModel
    {
        public BailBondInfo BailBondInfo { get; set; }
        public ProvidingAgency ProvidingAgency { get; set; }
        public Jail Jail { get; set; }
        public BondTransfer BondTransfer { get; set; }
        public RequestingAgency RequestingAgency { get; set; }
        public Defendant Defendant { get; set; }
        public Indemnitor Indemnitor { get; set; }
        public AdditionalInfo AdditionalInfo { get; set; }

        public FormViewModel()
        {
            BailBondInfo = new BailBondInfo();
            ProvidingAgency = new ProvidingAgency();
            Jail = new Jail();
            BondTransfer = new BondTransfer();
            RequestingAgency = new RequestingAgency();
            Defendant = new Defendant();
            Indemnitor = new Indemnitor();
            AdditionalInfo = new AdditionalInfo();
        }
    }
}
