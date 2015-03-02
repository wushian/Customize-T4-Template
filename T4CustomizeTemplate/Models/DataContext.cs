using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace WebTemplate.Models
{
   public class DataContext: DbContext
    {

       //Setting Database Connection
       public DataContext()
           : base("name=T4WebAppConnection") { }

       //Context
       public DbSet<Sample> Samples { get; set; }
       protected override void OnModelCreating(DbModelBuilder modelBuilder)

       {
          // modelBuilder.Entity<Employee>().HasKey(k => k.Id);
   
     
          
       }

      

    }
}
