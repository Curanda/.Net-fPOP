using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using fPOP_REST.Model;

namespace fPOP_REST.Data;

public partial class fPOP_Context : DbContext
{
    public fPOP_Context()
    {
    }

    public fPOP_Context(DbContextOptions<fPOP_Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Animal> Animals { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<DefaultCategory> DefaultCategories { get; set; }

    public virtual DbSet<Director> Directors { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<ImageStore> ImageStores { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<PoliticalOrientation> PoliticalOrientations { get; set; }

    public virtual DbSet<Religion> Religions { get; set; }

    public virtual DbSet<SexualOrientation> SexualOrientations { get; set; }

    public virtual DbSet<StreamingService> StreamingServices { get; set; }

    public virtual DbSet<TrendingMovie> TrendingMovies { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=fPOP-DB;User ID=admin;Password=YourStrongPassword123!;TrustServerCertificate=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.ToTable("Actor");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<Animal>(entity =>
        {
            entity.ToTable("Animal");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<DefaultCategory>(entity =>
        {
            entity.ToTable("DefaultCategory");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<Director>(entity =>
        {
            entity.ToTable("Director");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.ToTable("Gender");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<ImageStore>(entity =>
        {
            entity.ToTable("ImageStore");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.ToTable("Language");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<PoliticalOrientation>(entity =>
        {
            entity.ToTable("PoliticalOrientation");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<Religion>(entity =>
        {
            entity.ToTable("Religion");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<SexualOrientation>(entity =>
        {
            entity.ToTable("SexualOrientation");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<StreamingService>(entity =>
        {
            entity.ToTable("StreamingService");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<TrendingMovie>(entity =>
        {
            entity.ToTable("TrendingMovie");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.ChosenDefaultPreferences).HasMaxLength(4000);
            entity.Property(e => e.CountryOfBirth).HasMaxLength(20);
            entity.Property(e => e.CountryOfResidence).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FavoriteActors).HasMaxLength(4000);
            entity.Property(e => e.FavoriteAnimal).HasMaxLength(20);
            entity.Property(e => e.FavoriteDirectors).HasMaxLength(4000);
            entity.Property(e => e.FirstLanguage).HasMaxLength(20);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.PoliticalOrientation).HasMaxLength(20);
            entity.Property(e => e.ProfilePicture).HasMaxLength(500);
            entity.Property(e => e.Religion).HasMaxLength(20);
            entity.Property(e => e.SecondLanguage).HasMaxLength(20);
            entity.Property(e => e.SexualOrientation).HasMaxLength(20);
            entity.Property(e => e.StarredMovies).HasMaxLength(4000);
            entity.Property(e => e.UserDefinedPreferences).HasMaxLength(4000);
            

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
