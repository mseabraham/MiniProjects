using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MidTrainingProj.Models
{
    public partial class Gam3Sp0tContext : DbContext
    {
        public Gam3Sp0tContext()
        {
        }

        public Gam3Sp0tContext(DbContextOptions<Gam3Sp0tContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Developer> Developers { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameDeveloper> GameDevelopers { get; set; }
        public virtual DbSet<GamePlatform> GamePlatforms { get; set; }
        public virtual DbSet<Platform> Platforms { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Gam3Sp0t;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Developer>(entity =>
            {
                entity.Property(e => e.DeveloperId).HasColumnName("developerID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("companyName");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.GameId).HasColumnName("gameID");

                entity.Property(e => e.GameTitle)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("gameTitle");

                entity.Property(e => e.Rating)
                    .HasColumnType("decimal(2, 1)")
                    .HasColumnName("rating");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnType("date")
                    .HasColumnName("releaseDate");
            });

            modelBuilder.Entity<GameDeveloper>(entity =>
            {
                entity.HasKey(e => new { e.DeveloperId, e.GameId })
                    .HasName("PK__GameDeve__9B67B0B5D750179F");

                entity.ToTable("GameDeveloper");

                entity.Property(e => e.DeveloperId).HasColumnName("developerID");

                entity.Property(e => e.GameId).HasColumnName("gameID");

                entity.HasOne(d => d.Developer)
                    .WithMany(p => p.GameDevelopers)
                    .HasForeignKey(d => d.DeveloperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GameDevel__devel__6A30C649");
            });

            modelBuilder.Entity<GamePlatform>(entity =>
            {
                entity.HasKey(e => new { e.PlatformId, e.GameId })
                    .HasName("PK__GamePlat__F8FD05E051FB80C2");

                entity.ToTable("GamePlatform");

                entity.Property(e => e.PlatformId).HasColumnName("platformID");

                entity.Property(e => e.GameId).HasColumnName("gameID");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.GamePlatforms)
                    .HasForeignKey(d => d.PlatformId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GamePlatf__platf__66603565");
            });

            modelBuilder.Entity<Platform>(entity =>
            {
                entity.Property(e => e.PlatformId).HasColumnName("platformID");

                entity.Property(e => e.Brand)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("brand");

                entity.Property(e => e.PlatformName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("platformName");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.ReviewId).HasColumnName("reviewID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("content");

                entity.Property(e => e.GameId).HasColumnName("gameID");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reviews__userID__6EF57B66");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Username, "UQ__Users__F3DBC57282DE6257")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.IsAdmin)
                    .HasColumnName("isAdmin")
                    .HasDefaultValueSql("('FALSE')");

                entity.Property(e => e.LastName)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.Password)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
