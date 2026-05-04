using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OutfitRandomizer.Api.Data;
using OutfitRandomizer.Api.Models;
using Microsoft.Extensions.Configuration; // <-- Dodałem to, żeby czytać ustawienia z Azure

namespace OutfitRandomizer.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClothesController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IConfiguration _configuration; // <-- Zmienna do trzymania konfiguracji
    private readonly Random _random = new();

    // Dodaliśmy IConfiguration do konstruktora!
    public ClothesController(AppDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    [HttpGet("random")]
    public async Task<ActionResult<IEnumerable<ClothingItem>>> GetRandomOutfit([FromQuery] string password)
    {
        var correctPassword = _configuration["AppOptions:AccessPassword"];
        if (password != correctPassword) 
        {
            return Unauthorized("Błędne hasło!");
        }

        var allItems = await _context.Clothes.ToListAsync();
        var result = new List<ClothingItem>();

        // 1. Losujemy GÓRĘ
        var topCategories = new[] { "Bluzki luźne", "Bluzki wąskie", "Sukienki", "Onepiece" };
        var tops = allItems.Where(i => topCategories.Contains(i.Category)).ToList();
        
        ClothingItem? selectedTop = null;
        if (tops.Any())
        {
            selectedTop = tops[_random.Next(tops.Count)];
            result.Add(selectedTop);
        }

        // 2. Losujemy DÓŁ (zależnie od wylosowanej góry)
        if (selectedTop != null)
        {
            if (selectedTop.Category == "Sukienki" || selectedTop.Category == "Onepiece")
            {
                // Zgodnie z zasadą: nie losujemy dołu dla sukienek i onepiece
            }
            else if (selectedTop.Category == "Bluzki wąskie") // W wytycznych nazwane "obcisłe", ale kategoria to "Bluzki wąskie"
            {
                var allowedBottoms = new[] { "Spodnie zwykłe", "Spodnie dresowe", "Spódnice" };
                var bottoms = allItems.Where(i => allowedBottoms.Contains(i.Category)).ToList();
                if (bottoms.Any()) result.Add(bottoms[_random.Next(bottoms.Count)]);
            }
            else if (selectedTop.Category == "Bluzki luźne")
            {
                var allBottomCategories = new[] { "Spodnie zwykłe", "Spodnie obcisłe", "Spodnie dresowe", "Spodnie/spódnice krótkie", "Spódnice" };
                var bottoms = allItems.Where(i => allBottomCategories.Contains(i.Category)).ToList();
                if (bottoms.Any()) result.Add(bottoms[_random.Next(bottoms.Count)]);
            }
        }

        // 3. Losujemy DODATKOWĄ GÓRĘ (zawsze)
        var extraTopCategories = new[] { "Bluzy nakładane", "Bluzy rozpinane" };
        var extraTops = allItems.Where(i => extraTopCategories.Contains(i.Category)).ToList();
        if (extraTops.Any())
        {
            result.Add(extraTops[_random.Next(extraTops.Count)]);
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

// Klasa DTO (Data Transfer Object) zostaje na dole
public class AddClothesDto
{
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public string Password { get; set; } = "";
}