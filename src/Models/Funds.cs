using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fas_dashboard_api.Models
{
    [Table("Funds", Schema = "Masters")]
    public partial class Funds
    {
        public int ClientId { get; set; }
        [Key]
        public int FundId { get; set; }
        public string FundName { get; set; }
        public int? GlobalFundId { get; set; }
        public byte? IsActive { get; set; }

    }
}
