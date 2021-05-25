using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMonsters.Data;

namespace RazorPagesMonsters.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMonstersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMonstersContext>>()))
            {
                // Look for any Monsters.
                if (context.Monster.Any())
                {
                    return;   // DB has been seeded
                }

                context.Monster.AddRange(
                    new Monster
                    {
                        MonsterName = "When Harry Met Sally",
                        YearPopularized = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Monster
                    {
                        MonsterName = "Pikachu",
                        YearPopularized = DateTime.Parse("1996-2-27"),
                        Genre = "Pokemon",
                        Price = 5.67M
                    },

                    new Monster
                    {
                        MonsterName = "Slimer",
                        YearPopularized = DateTime.Parse("1984-6-15"),
                        Genre = "Ghostbusters",
                        Price = 34.55M
                    },

                    new Monster
                    {
                        MonsterName = "Alien",
                        YearPopularized = DateTime.Parse("1979-5-25"),
                        Genre = "Space Monsters",
                        Price = 10.00M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
