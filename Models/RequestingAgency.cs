﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CummingsApplication.Models
{
    public class RequestingAgency
    {
        public int Id { get; set; }

        public int BailBondId { get; set; }

        public string Name { get; set; }

        public string MobileNumber { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string County { get; set; }

        public virtual BailBondInfo BailBondInfo { get; set; }
    }
}
