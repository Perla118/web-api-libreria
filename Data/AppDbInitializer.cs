using librerias_PMRI.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace librerias_PMRI.Data
{
    public class AppDbInitialer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Titulo = "1st Boook",
                        Descripcion = "quso",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "terror",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,
                    },
                     new Book()
                     {
                         Titulo = "2nd book",
                         Descripcion = "queso",
                         IsRead = true,
                         DateRead = DateTime.Now.AddDays(-10),
                         Rate = 4,
                         Genero = "terror",
                         CoverUrl = "https...",
                         DateAdded = DateTime.Now,
                     });
                    context.SaveChanges();
                }
            }
        }

    }
}