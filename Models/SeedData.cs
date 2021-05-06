using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace FinalProjectGameWebsite.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
                {
                    if (context.Games.Any())
                    {
                        return;
                    }

                    context.Games.AddRange(
                        new Game
                        {
                            Title = "The Last of Us",
                            Rating = "Mature 17+",
                            Description = "Set twenty years after a cataclysmic fungal infection outbreak decimates Earth's population, a survivor named Joel is tasked with bringing a fourteen year old girl (Ellie) across the country when it is discovered that she is immune.",
                            Characters = new List<Character> {
                                new Character {Name = "Ellie", WeaponOfChoice = "Switch-Blade"},
                                new Character {Name = "Joel", WeaponOfChoice = "Revolver"},
                                new Character {Name = "David", WeaponOfChoice = "Machete"},
                                new Character {Name = "Clicker", WeaponOfChoice = "Teeth"},
                                new Character {Name = "Runner", WeaponOfChoice = "Arms/Teeth"},
                                new Character {Name = "Bloater", WeaponOfChoice = "Acidic Throwable projectiles"}
                            }
                        },

                        new Game
                        {
                            Title = "God of War",
                            Rating = "Mature 17+",
                            Description = "Kratos, a Greek god trying to escape his past, sets out on a journey with his son Atreus after the death of their wife and mother respectivly. Along the way, they encounter gods and men alike... and many things in between. ",
                            Characters = new List<Character> {
                                new Character{Name = "Kratos", WeaponOfChoice = "Leviathan Axe"},
                                new Character{Name = "Atreus", WeaponOfChoice = "Bow and Arrow"},
                                new Character{Name = "Freya", WeaponOfChoice = "Magic"},
                                new Character{Name = "Baldur", WeaponOfChoice = "Fists"},
                                new Character{Name = "Mimir", WeaponOfChoice = "Quick Wit"}
                            }
                        },

                        new Game
                        {
                            Title = "The Legend of Zelda: Breath of the Wild",
                            Rating = "Everyone 10+",
                            Description = "Set 100 years after the great calmity, Link wakes from a century long rest to find Hyrule overrun with monsters and disaster caused by Calamity Ganon. He must stop Ganon and Zelda before time runs out.",
                            Characters = new List<Character> {
                                new Character{Name = "Link", WeaponOfChoice = "Master Sword"},
                                new Character{Name = "Zelda", WeaponOfChoice = "Magic"},
                                new Character{Name = "Daruk", WeaponOfChoice = "Boulder Breaker"},
                                new Character{Name = "Mipha", WeaponOfChoice = "Lightscale Trident"},
                                new Character{Name = "Urbosa", WeaponOfChoice = "Scimitar"},
                                new Character{Name = "Revali", WeaponOfChoice = "Great Eagle Bow"}
                            }
                        },

                        new Game
                        {
                            Title = "Red Dead Redemption 2",
                            Rating = "Mature 17+",
                            Description = "As a member of the infamous van der Linde gang, Arthur Morgan struggles morally between right and wrong while trying keep his tight knit band of outlaws together and out of harm's way.",
                            Characters = new List<Character> {
                                new Character{Name = "Arthur Morgan", WeaponOfChoice = "Revolver/Shotgun/Rifle"},
                                new Character{Name = "John Marsden", WeaponOfChoice = "Cattleman Revolver"},
                                new Character{Name = "Dutch van der Linde", WeaponOfChoice = "Twin Schofield Revolvers"},
                                new Character{Name = "Andrew Milton", WeaponOfChoice = "Schofield Revolver"},
                                new Character{Name = "Sadie Adler", WeaponOfChoice = "Twin Custom Cattleman Revolvers"}
                            }
                        },

                        new Game
                        {
                            Title = "Uncharted 4: A Thief's End",
                            Rating = "Mature 17+",
                            Description = "Retired treasure hunter Nathan Drake is dragged back into the life when his long thought dead brother returns from the grave. ",
                            Characters = new List<Character> {
                                new Character{Name = "Nathan Drake", WeaponOfChoice = "Para .45"},
                                new Character{Name = "Samual Drake", WeaponOfChoice = "Aegis 9mm"},
                                new Character{Name = "Victor 'Sully' Sullivan", WeaponOfChoice = "Wes-44"},
                                new Character{Name = "Elena Fisher-Drake", WeaponOfChoice = "Aegis 9mm"},
                                new Character{Name = "Rafe Adler", WeaponOfChoice = "Colt M1911"}
                            }
                        }

                    );
                    context.SaveChanges();
                }     
        }
    }
}