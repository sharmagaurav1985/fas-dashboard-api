using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace fas_dashboard_api.Models
{
    public partial class TESTFASContext : DbContext
    {
        public TESTFASContext()
        {
        }

        public TESTFASContext(DbContextOptions<TESTFASContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Funds> Funds { get; set; }

    }
}
