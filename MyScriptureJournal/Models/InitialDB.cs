using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public static class InitialDB
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Date = DateTime.Parse("2020-2-12"),
                        BookModels = "1 Nephi",
                        Chapter = 1,
                        Verse = 1,
                        Note = "I, Nephi, having been aborn of goodly parents"
                    },
                    new Scripture
                    {
                        Date = DateTime.Parse("2020-1-01"),
                        BookModels = "2 Nephi",
                        Chapter = 2,
                        Verse = 1,
                        Note = "Blessed art thou Lehi, because of the things which thou hast done;"
                    },
                   new Scripture
                   {
                       Date = DateTime.Parse("2020-1-02"),
                       BookModels = "Jacob",
                       Chapter = 2,
                       Verse = 1,
                       Note = "Ready to edit"
                   },
                    new Scripture
                    {
                        Date = DateTime.Parse("2020-1-03"),
                        BookModels = "Enos",
                        Chapter = 1,
                        Verse = 1,
                        Note = "Ready to edit"
                    },
                     new Scripture
                     {
                         Date = DateTime.Parse("2020-1-05"),
                         BookModels = "Jarom",
                         Chapter = 1,
                         Verse = 1,
                         Note = "Ready to edit"
                     },
                      new Scripture
                      {
                          Date = DateTime.Parse("2020-1-06"),
                          BookModels = "Omni",
                          Chapter = 1,
                          Verse = 1,
                          Note = "Ready to edit"
                      },
                       new Scripture
                       {
                           Date = DateTime.Parse("2020-1-09"),
                           BookModels = "Mosiah",
                           Chapter = 2,
                           Verse = 1,
                           Note = "Ready to edit"
                       },
                        new Scripture
                        {
                            Date = DateTime.Parse("2020-1-20"),
                            BookModels = "Alma",
                            Chapter = 2,
                            Verse = 1,
                            Note = "Ready to edit"
                        }
                );
                context.SaveChanges();
            }
        }
    }
}