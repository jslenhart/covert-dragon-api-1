﻿
using Covert.Dragon.Domain.Orders;
using Covert.Dragon.Domain.Catalog;
using Microsoft.EntityFrameworkCore; 

namespace Covert.Dragon.Data 
{ 
    public class StoreContext: DbContext 
    { 
        public StoreContext( DbContextOptions< StoreContext> options)
           : base( options) 
{}
public DbSet<Item> Items { get; set; }

public DbSet<Order> Orders {get ; set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);

        }
    }
}
