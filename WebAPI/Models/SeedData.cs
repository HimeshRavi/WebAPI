using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace WebAPI.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebAPIContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebAPIContext>>()))
            {
                // Look for any Products.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        Description = "Et et consequatur quisquam nisi quae est itaque.",
                        Model = "531805369",
                        Brand = "Heidenreich, Dietrich and Smitham"
                    },

                    new Product
                    {
                        Description = "Occaecati deserunt quia distinctio esse fugiat ad.",
                        Model = "80279",
                        Brand = "Wolff LLC"
                    },

                    new Product
                    {
                        Description = "Id ducimus ut consequuntur quo labore minima.",
                        Model = "54278642",
                        Brand = "Runolfsson PLC"
                    },

                    new Product
                    {
                        Description = "Et occaecati temporibus assumenda dignissimos.",
                        Model = "839675",
                        Brand = "Sipes-Gleason"
                    },

                    new Product
                    {
                        Description = "Quia sint iste sunt dolor earum ut voluptatibus et.",
                        Model = "97645",
                        Brand = "Schuster-Huels"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}