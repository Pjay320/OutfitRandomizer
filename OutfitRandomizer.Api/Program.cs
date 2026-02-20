using Microsoft.EntityFrameworkCore;
using OutfitRandomizer.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// --- 1. TU DODAJESZ USŁUGI (Przed builder.Build()) ---
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Zadziała po instalacji NuGet

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options => {
    options.AddDefaultPolicy(policy => {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

// --- 2. TU BUDUJESZ APLIKACJĘ ---
var app = builder.Build();

// --- 3. TU KONFIGURUJESZ DZIAŁANIE (Po builder.Build()) ---
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(); // Musi być przed MapControllers
app.MapControllers();

app.Run();