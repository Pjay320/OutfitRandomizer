using Microsoft.EntityFrameworkCore;
using OutfitRandomizer.Api.Models;

namespace OutfitRandomizer.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<ClothingItem> Clothes { get; set; }

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<ClothingItem>().HasData(
        // SPODNIE ZWYKŁE
        new ClothingItem { Id = 1, Name = "sOliver niskie jeans", Category = "Spodnie Zwykłe" },
        new ClothingItem { Id = 2, Name = "szare jeans", Category = "Spodnie Zwykłe" },
        new ClothingItem { Id = 3, Name = "czarne jeans", Category = "Spodnie Zwykłe" },
        new ClothingItem { Id = 4, Name = "szare jeans niskie luźne", Category = "Spodnie Zwykłe" },
        new ClothingItem { Id = 5, Name = "kratka", Category = "Spodnie Zwykłe" },
        new ClothingItem { Id = 6, Name = "Ciasne jeans niebieskie", Category = "Spodnie Zwykłe" },
        new ClothingItem { Id = 7, Name = "niebieskie jeans", Category = "Spodnie Zwykłe" },
        new ClothingItem { Id = 8, Name = "bigstar niskie", Category = "Spodnie Zwykłe" },

        // LEGGINSY
        new ClothingItem { Id = 9, Name = "śliskie", Category = "Legginsy" },
        new ClothingItem { Id = 10, Name = "górskie", Category = "Legginsy" },
        new ClothingItem { Id = 11, Name = "ciasne", Category = "Legginsy" },

        // SPODNIE DRESOWE
        new ClothingItem { Id = 12, Name = "beżowe", Category = "Spodnie Dresowe" },
        new ClothingItem { Id = 13, Name = "różowe", Category = "Spodnie Dresowe" },
        new ClothingItem { Id = 14, Name = "czarne", Category = "Spodnie Dresowe" },
        new ClothingItem { Id = 15, Name = "brązowe", Category = "Spodnie Dresowe" },

        // SPÓDNICE
        new ClothingItem { Id = 16, Name = "plisowana czarna", Category = "Spódnice" },
        new ClothingItem { Id = 17, Name = "gotycka czarna", Category = "Spódnice" },
        new ClothingItem { Id = 18, Name = "prosta różowa", Category = "Spódnice" },

        // SUKIENKI
        new ClothingItem { Id = 19, Name = "polar ruda", Category = "Sukienki" },
        new ClothingItem { Id = 20, Name = "prosta czarna", Category = "Sukienki" },
        new ClothingItem { Id = 21, Name = "kwiaty ruda", Category = "Sukienki" },
        new ClothingItem { Id = 22, Name = "paski czarno-biała", Category = "Sukienki" },
        new ClothingItem { Id = 23, Name = "długa niebieska", Category = "Sukienki" },
        new ClothingItem { Id = 24, Name = "mini obcisła czarna", Category = "Sukienki" },
        new ClothingItem { Id = 25, Name = "kwiatowa ramiączka kolorowa", Category = "Sukienki" },
        new ClothingItem { Id = 26, Name = "sztruks czarna", Category = "Sukienki" },
        new ClothingItem { Id = 27, Name = "sztruks ruda", Category = "Sukienki" },
        new ClothingItem { Id = 28, Name = "kropki zielona", Category = "Sukienki" },
        new ClothingItem { Id = 29, Name = "paski stara letnia czarno-biała", Category = "Sukienki" },
        new ClothingItem { Id = 30, Name = "kropki czarna", Category = "Sukienki" },
        new ClothingItem { Id = 31, Name = "pastelowa kolorowa", Category = "Sukienki" },
        new ClothingItem { Id = 32, Name = "japońska pomarańczowa", Category = "Sukienki" },
        new ClothingItem { Id = 33, Name = "obcisła złote ramiączka ruda", Category = "Sukienki" },
        new ClothingItem { Id = 34, Name = "uczennica krata", Category = "Sukienki" },
        new ClothingItem { Id = 35, Name = "miękka długi rękaw ruda", Category = "Sukienki" },

        // BLUZKI (LUŹNIEJSZE)
        new ClothingItem { Id = 36, Name = "my little pony", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 37, Name = "długa czarna", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 38, Name = "biała twarz czarna", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 39, Name = "ramiączka czarna", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 40, Name = "jedwab wiśniowa", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 41, Name = "jedwab różowa", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 42, Name = "paski niebieska", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 43, Name = "kuromi czarna", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 44, Name = "napis słońce biała", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 45, Name = "jedwab ramiączka prosta czarna", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 46, Name = "różowa twarz czarna", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 47, Name = "jedwab falbanki czarna", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 48, Name = "ramiączka stara czarna", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 49, Name = "fioletowa twarz biała", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 50, Name = "barbie biała", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 51, Name = "gra dziewczynka czarna", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 52, Name = "ramiączka szara", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 53, Name = "koszula kwiaty zielona", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 54, Name = "koszula pomarańczowa", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 55, Name = "szkielety dziewczynka czarna", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 56, Name = "zioło dziewczynka czarna", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 57, Name = "ramiączka sztruks szara", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 58, Name = "hollister biała", Category = "Bluzki (Luźniejsze)" },
        new ClothingItem { Id = 59, Name = "liście biała", Category = "Bluzki (Luźniejsze)" },

        // BLUZKI (OBCISŁE)
        new ClothingItem { Id = 60, Name = "kuromi fioletowa", Category = "Bluzki (Obcisłe)" },
        new ClothingItem { Id = 61, Name = "Bambi różowa", Category = "Bluzki (Obcisłe)" },
        new ClothingItem { Id = 62, Name = "miś różowa", Category = "Bluzki (Obcisłe)" },
        new ClothingItem { Id = 63, Name = "cienka beżowa", Category = "Bluzki (Obcisłe)" },
        new ClothingItem { Id = 64, Name = "długa czarna", Category = "Bluzki (Obcisłe)" },
        new ClothingItem { Id = 65, Name = "kratka czarno-biała", Category = "Bluzki (Obcisłe)" },
        new ClothingItem { Id = 66, Name = "króliczek różowa", Category = "Bluzki (Obcisłe)" },
        new ClothingItem { Id = 67, Name = "diamenciki czarna", Category = "Bluzki (Obcisłe)" },
        new ClothingItem { Id = 68, Name = "winx różowa", Category = "Bluzki (Obcisłe)" },
        new ClothingItem { Id = 69, Name = "dziurawa beżowa", Category = "Bluzki (Obcisłe)" },
        new ClothingItem { Id = 70, Name = "paski pomarańczowo-szara", Category = "Bluzki (Obcisłe)" },
        new ClothingItem { Id = 71, Name = "sztruks czarna", Category = "Bluzki (Obcisłe)" },
        new ClothingItem { Id = 72, Name = "długa niebieska", Category = "Bluzki (Obcisłe)" },

        // BLUZY
        new ClothingItem { Id = 73, Name = "krótka zielona", Category = "Bluzy" },
        new ClothingItem { Id = 74, Name = "krótka czarna", Category = "Bluzy" },
        new ClothingItem { Id = 75, Name = "prosta czarna", Category = "Bluzy" },
        new ClothingItem { Id = 76, Name = "hollister żółta", Category = "Bluzy" },
        new ClothingItem { Id = 77, Name = "barbie biała", Category = "Bluzy" },
        new ClothingItem { Id = 78, Name = "prosta pomarańczowa", Category = "Bluzy" },
        new ClothingItem { Id = 79, Name = "golf biały", Category = "Bluzy" },
        new ClothingItem { Id = 80, Name = "sportowa szara", Category = "Bluzy" },
        new ClothingItem { Id = 81, Name = "róże czarna", Category = "Bluzy" },
        new ClothingItem { Id = 82, Name = "napisy brązowa", Category = "Bluzy" },
        new ClothingItem { Id = 83, Name = "prosta szara", Category = "Bluzy" },
        new ClothingItem { Id = 84, Name = "kws szara", Category = "Bluzy" },
        new ClothingItem { Id = 85, Name = "góry zielona", Category = "Bluzy" },
        new ClothingItem { Id = 86, Name = "komplet beżowa", Category = "Bluzy" },
        new ClothingItem { Id = 87, Name = "sweterek miękki biała", Category = "Bluzy" }
    );
}
}