using Microsoft.EntityFrameworkCore;
using fPOP_REST.Model;

namespace fPOP_REST.Data;

public class FirePopDbContext(DbContextOptions<FirePopDbContext> options) : DbContext(options)
{
    public DbSet<fPOP_REST.Model.Actor> Actor { get; set; } = default!;
    public DbSet<fPOP_REST.Model.Animal> Animal { get; set; } = default!;
    public DbSet<fPOP_REST.Model.Country> Country { get; set; } = default!;
    public DbSet<fPOP_REST.Model.DefaultCategory> DefaultCategory { get; set; } = default!;
    public DbSet<fPOP_REST.Model.Director> Director { get; set; } = default!;
    public DbSet<fPOP_REST.Model.Gender> Gender { get; set; } = default!;
    public DbSet<fPOP_REST.Model.ImageStore> ImageStore { get; set; } = default!;
    public DbSet<fPOP_REST.Model.Language> Language { get; set; } = default!;
    public DbSet<fPOP_REST.Model.PoliticalOrientation> PoliticalOrientation { get; set; } = default!;
    public DbSet<fPOP_REST.Model.Religion> Religion { get; set; } = default!;
    public DbSet<fPOP_REST.Model.SexualOrientation> SexualOrientation { get; set; } = default!;
    public DbSet<fPOP_REST.Model.StreamingService> StreamingService { get; set; } = default!;
    public DbSet<fPOP_REST.Model.TrendingMovie> TrendingMovie { get; set; } = default!;
    public DbSet<fPOP_REST.Model.User> User { get; set; } = default!;
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Create a single options instance to reuse
        var options = new System.Text.Json.JsonSerializerOptions();

        // Configure list properties to be stored as JSON
        modelBuilder.Entity<User>()
            .Property(u => u.ChosenDefaultPreferences)
            .HasConversion(
                v => System.Text.Json.JsonSerializer.Serialize(v, options),
                v => System.Text.Json.JsonSerializer.Deserialize<List<string>>(v, options));

        modelBuilder.Entity<User>()
            .Property(u => u.UserDefinedPreferences)
            .HasConversion(
                v => System.Text.Json.JsonSerializer.Serialize(v, options),
                v => System.Text.Json.JsonSerializer.Deserialize<List<string>>(v, options));

        modelBuilder.Entity<User>()
            .Property(u => u.StarredMovies)
            .HasConversion(
                v => System.Text.Json.JsonSerializer.Serialize(v, options),
                v => System.Text.Json.JsonSerializer.Deserialize<List<string>>(v, options));

        modelBuilder.Entity<User>()
            .Property(u => u.FavoriteDirectors)
            .HasConversion(
                v => System.Text.Json.JsonSerializer.Serialize(v, options),
                v => System.Text.Json.JsonSerializer.Deserialize<List<string>>(v, options));

        modelBuilder.Entity<User>()
            .Property(u => u.FavoriteActors)
            .HasConversion(
                v => System.Text.Json.JsonSerializer.Serialize(v, options),
                v => System.Text.Json.JsonSerializer.Deserialize<List<string>>(v, options));
    }
}

