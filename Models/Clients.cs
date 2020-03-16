using System;
using System.Collections.Generic;

namespace fas_dashboard_api.Models
{
    public partial class Clients
    {
        public Clients()
        {
            Funds = new HashSet<Funds>();
        }

        public int ClientId { get; set; }
        public string ClientName { get; set; }

        public virtual ICollection<Funds> Funds { get; set; }
    }
}
