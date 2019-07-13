using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore1.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app) {

            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();


            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product {
                        Name="Kayak",
                        Description=" A boat",
                        Category="Watersports",
                        Price=275
                    },
                     new Product
                     {
                         Name = "LifeJackect",
                         Description = "A Protective",
                         Category = "Watersports",
                         Price = 75
                     },
                      new Product
                      {
                          Name = "Soccer Ball",
                          Description = " A ball",
                          Category = "Soccer",
                          Price = 25
                      },
                       new Product
                       {
                           Name = "Corner Flag",
                           Description = " A flag",
                           Category = "Soccer",
                           Price = 275
                       },
                        new Product
                        {
                            Name = "Thinking Cap",
                            Description = " A Cap",
                            Category = "Chess",
                            Price = 5
                        },
                         new Product
                         {
                             Name = "Chess Board",
                             Description = " A board",
                             Category = "Chess",
                             Price = 20
                         },
                          new Product
                          {
                              Name = "Time Clock",
                              Description = " A Clock",
                              Category = "Chess",
                              Price = 7
                          },
                           new Product
                           {
                               Name = "Whistle",
                               Description = " A Whistle",
                               Category = "Soccer",
                               Price = 2
                           },
                            new Product
                            {
                                Name = "Surf Board",
                                Description = " A board",
                                Category = "Watersport",
                                Price = 25
                            }




                    );
                context.SaveChanges();
    
            }


        }


    }
}
