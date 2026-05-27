using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OutfitRandomizer.Api.Data;
using OutfitRandomizer.Api.Models;
using Microsoft.Extensions.Configuration; 

namespace OutfitRandomizer.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClothesController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IConfiguration _configuration;
    private readonly Random _random = new();

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

        // 2. Losujemy DÓŁ
        if (selectedTop != null)
        {
            if (selectedTop.Category == "Sukienki" || selectedTop.Category == "Onepiece") { /* nic */ }
            else if (selectedTop.Category == "Bluzki wąskie")
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

        // 3. Losujemy DODATKOWĄ GÓRĘ (ZAWSZE)
        var extraTopCategories = new[] { "Bluzy nakładane", "Bluzy rozpinane" };
        var extraTops = allItems.Where(i => extraTopCategories.Contains(i.Category)).ToList();
        if (extraTops.Any())
        {
            result.Add(extraTops[_random.Next(extraTops.Count)]);
        }

        return Ok(result);
    }

    // --- NOWY ENDPOINT DO POBIERANIA CAŁEJ TABELI ---
    [HttpGet("all")]
    public async Task<ActionResult<IEnumerable<ClothingItem>>> GetAllClothes([FromQuery] string password)
    {
        var correctPassword = _configuration["AppOptions:AccessPassword"];
        if (password != correctPassword) return Unauthorized("Błędne hasło!");

        var items = await _context.Clothes
            .OrderBy(c => c.Category)
            .ThenBy(c => c.Name)
            .ToListAsync();
            
        return Ok(items);
    }

    // --- ENDPOINT DO DODAWANIA UBRAŃ ---
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

// Klasa DTO potrzebna do dodawania ubrań
public class AddClothesDto
{
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public string Password { get; set; } = "";
}