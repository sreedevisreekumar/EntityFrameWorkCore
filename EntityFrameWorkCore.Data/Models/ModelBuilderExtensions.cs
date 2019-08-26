using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkCore.Data.Models
{
   public static class ModelBuilderExtensions
    {
        public static void seed(this ModelBuilder modelBuilder)
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
