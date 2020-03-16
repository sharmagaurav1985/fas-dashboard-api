using System;
using System.Collections.Generic;

namespace fas_dashboard_api.Models
{
    public partial class Funds
    {
        public int ClientId { get; set; }
        public int FundId { get; set; }
        public string FundName { get; set; }
        public int? GlobalFundId { get; set; }
        public byte? IsActive { get; set; }

        public virtual Clients Client { get; set; }
    }
}
