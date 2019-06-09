using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DVDMovie.Models
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            if (context.Database.GetMigrations().Count() > 0
                && context.Database.GetPendingMigrations().Count() == 0
                && context.Movies.Count() == 0)
            {
                var s1 = new Studio
                {
                    Name = "Moonlight Entertainnment",
                    City = "San Jose",
                    State = "CA"
                };
                var s2 = new Studio
                {
                    Name = "Paramount",
                    City = "SChicargo",
                    State = "IL"
                };
                var s3 = new Studio
                {
                    Name = "MGM",
                    City = "New York",
                    State = "NY "
                };

                context.Movies.AddRange(
                    new Movie
                    {
                        Name = "Titanc",
                        Description = "A 17-year-old aristocrat falls in love with a stow away",
                        Category = "Drama",
                        Price = 75,
                        Studio = s1,
                        Ratings = new System.Collections.Generic.List<Rating> {
                            new Rating {Stars = 4},  new Rating {Stars = 3}
                        }
                    },
                    new Movie
                    {
                        Name = "The Godfather",
                        Description = "The aging pattiach of an organized crime family",
                        Category = "Drama",
                        Price = 48.95m,
                        Studio = s1,
                        Ratings = new System.Collections.Generic.List<Rating> {
                            new Rating {Stars = 2},  new Rating {Stars = 5}
                        }
                    },
                    new Movie
                    {
                        Name = "Wedding Crashers",
                        Description = "Commited womanizers sneak into weddings",
                        Category = "Comedy",
                        Price = 34.95m,
                        Studio = s2,
                        Ratings = new System.Collections.Generic.List<Rating> {
                            new Rating {Stars = 3} 
                        }
                    },
                    new Movie
                    {
                        Name = "Superbad",
                        Description = "Two co-dependent high school seniors",
                        Category = "Comedy",
                        Price = 70,
                        Studio = s2,
                        Ratings = new System.Collections.Generic.List<Rating> {
                            new Rating {Stars = 1}, new Rating {Stars = 4}, new Rating {Stars = 3}   
                        }
                    },
                    new Movie
                    {
                        Name = "Bridget Jones's Diary",
                        Description = "A British women is determind to improve",
                        Category = "Romance",
                        Price = 16,
                        Studio = s3,
                        Ratings = new System.Collections.Generic.List<Rating> {
                            new Rating {Stars = 4}   
                        }
                    },
                    new Movie
                    {
                        Name = "Love Actually",
                        Description = "Eight very different couples deal with love",
                        Category = "Romance",
                        Price = 75,
                        Studio = s3,
                        Ratings = new System.Collections.Generic.List<Rating> {
                            new Rating {Stars = 3}, new Rating {Stars = 4}, new Rating {Stars = 3}   
                        }
                    },
                    new Movie
                    {
                        Name = "The Way We Were",
                        Description = "Two desperate people have a wonderful adventure",
                        Category = "Romance",
                        Price = 75,
                        Studio = s3,
                        Ratings = new System.Collections.Generic.List<Rating> {
                            new Rating {Stars = 5}, new Rating {Stars = 4}, new Rating {Stars = 3}   
                        }
                    },
                    new Movie
                    {
                        Name = "Ghost",
                        Description = "A young man is murdered",
                        Category = "Romance",
                        Price = 10,
                        Studio = s3   
                    });
                context.SaveChanges();
            }
        }
    }
}
