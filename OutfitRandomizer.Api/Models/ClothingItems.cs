namespace OutfitRandomizer.Api.Models;

public class ClothingItem
{
    public int Id { get; set; } // Unikalny numer (Klucz główny)
    public string Name { get; set; } = string.Empty; // Nazwa, np. "sOliver niskie jeans"
    public string Category { get; set; } = string.Empty; // Kategoria, np. "Spodnie Zwykłe"
}