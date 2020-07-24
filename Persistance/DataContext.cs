using System.Collections.Immutable;
using System;
using domain;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class DataContext:DbContext
    {

          public DataContext(DbContextOptions<DataContext> options) : base(options)
          {  
          }

          public DbSet<Value> values {get; set;}

          protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
       modelBuilder.Entity<Value>().HasData(
             new Value{ Id=1,Name="tushar"},
             new Value {Id=2,Name="raj"}
    );
   }
    }
}
