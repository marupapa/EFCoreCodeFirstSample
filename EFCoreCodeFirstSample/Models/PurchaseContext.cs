using System;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCodeFirstSample.Models
{
    public class PurchaseContext : DbContext
    {
        public PurchaseContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Purchase> Purchases { get; set; }
    }
}

