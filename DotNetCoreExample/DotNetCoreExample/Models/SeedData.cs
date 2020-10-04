using DotNetCoreExample.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreExample.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DotNetCoreExampleContext(serviceProvider.GetRequiredService<DbContextOptions<DotNetCoreExampleContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(new Movie()
                {
                    Title = "我不是药神",
                    Country = "中国",
                    ReleaseDate = new DateTime(2018, 06, 19),
                    Genre = "Comedy/Drama",
                    Price = 10900000.00m
                },
                new Movie()
                {
                    Title = "Tropa de Elite - Missão Dada é Missão Cumprida",
                    Country = "Brasil",
                    ReleaseDate = new DateTime(2017, 5, 10),
                    Genre = "Policial/Drama",
                    Price = 10500000.00m
                });
                context.SaveChanges();
            }
        }
    }
}
