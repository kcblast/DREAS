﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Settlement: BaseModel
    {
        public Guid UserId { get; set; }
        public DateTime SettlementDate { get; set; }
        public decimal SettlementAmount { get; set; }
        public string SettlementCategory { get; set; }
        public Guid RoleId { get; set; }


    }
}
