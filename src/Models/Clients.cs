using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fas_dashboard_api.Models
{
    [Table("Clients", Schema = "Masters")]
    public partial class Clients
    {
        [Key]
        public int ClientId { get; set; }
        public string ClientName { get; set; }
    }
}
