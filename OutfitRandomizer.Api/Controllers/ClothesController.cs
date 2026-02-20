using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OutfitRandomizer.Api.Data;
using OutfitRandomizer.Api.Models;

namespace OutfitRandomizer.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClothesController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly Random _random = new();

    public ClothesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("random")]
    public async Task<ActionResult<IEnumerable<ClothingItem>>> GetRandomOutfit([FromQuery] string password, [FromQuery] bool includeHoodie = false)
    {
        if (password != "mojetajnehaslo") 
        {
            return Unauthorized("Błędne hasło!");
        }

        var allItems = await _context.Clothes.ToListAsync();
        var result = new List<ClothingItem>();

        if (includeHoodie)
        {
            // 1. Losujemy BLUZĘ
            var hoodies = allItems.Where(i => i.Category == "Bluzy").ToList();
            if (hoodies.Any()) result.Add(hoodies[_random.Next(hoodies.Count)]);

            // 2. Losujemy BLUZKĘ (pod bluzę)
            var tops = allItems.Where(i => i.Category.Contains("Bluzki")).ToList();
            if (tops.Any()) result.Add(tops[_random.Next(tops.Count)]);

            // 3. Losujemy DÓŁ (Spodnie/Spódnice/Legginsy)
            var bottoms = allItems.Where(i => i.Category.Contains("Spodnie") || i.Category == "Spódnice" || i.Category == "Legginsy").ToList();
            if (bottoms.Any()) result.Add(bottoms[_random.Next(bottoms.Count)]);
        }
        else
        {
            // Stara logika: Sukienka ALBO (Bluzka/Bluza + Dół)
            bool isDressDay = _random.Next(1, 101) <= 20;

            if (isDressDay)
            {
                var dresses = allItems.Where(i => i.Category == "Sukienki").ToList();
                if (dresses.Any()) result.Add(dresses[_random.Next(dresses.Count)]);
            }
            else
            {
                var tops = allItems.Where(i => i.Category.Contains("Bluzki") || i.Category == "Bluzy").ToList();
                if (tops.Any()) result.Add(tops[_random.Next(tops.Count)]);

                var bottoms = allItems.Where(i => i.Category.Contains("Spodnie") || i.Category == "Spódnice" || i.Category == "Legginsy").ToList();
                if (bottoms.Any()) result.Add(bottoms[_random.Next(bottoms.Count)]);
            }
        }

        return Ok(result);
    }
    [HttpPost("add")]
    public async Task<IActionResult> AddClothingItem([FromBody] AddClothesDto request)
    {
        var correctPassword = _configuration["AppOptions:AccessPassword"];
        if (request.Password != correctPassword) return Unauthorized("Błędne hasło.");

        var newItem = new ClothingItem { Name = request.Name, Category = request.Category };
            
        _context.Clothes.Add(newItem);
        await _context.SaveChangesAsync();

        return Ok(newItem);
    }
}
public class AddClothesDto
{
    public string Name { get; set; }
    public string Category { get; set; }
    public string Password { get; set; }
}
