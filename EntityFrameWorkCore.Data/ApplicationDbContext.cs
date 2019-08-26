using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkCore.Data
{
    /// <summary>
    /// The  database representational model of this application
    /// </summary>
  public  class ApplicationDbContext:DbContext
    {
        /// <summary>
        /// Default constructor expecting database options passed in.
        /// </summary>
        /// <param name="dbContextOptions"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions):base(dbContextOptions)
        {

        }

        //Representation of table
        public DbSet<SettingsModel> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SettingsModel>().HasData(
                new SettingsModel
                {
                    Id = "1",
                    Name = "back-ground-color",
                    Value = "green"

                },
                 new SettingsModel
                 {
                     Id = "2",
                     Name = "border",
                     Value = "solid 1px black"

                 }
                );
        }

    }
}
