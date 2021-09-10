using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TourFirm.Models.DataBase
{
    public partial class TourFirmDBContext : DbContext
    {
        public TourFirmDBContext()
        {
        }

        public TourFirmDBContext(DbContextOptions<TourFirmDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryRoomHotel> CategoryRoomHotels { get; set; }
        public virtual DbSet<CategoryService> CategoryServices { get; set; }
        public virtual DbSet<CitiesCountry> CitiesCountries { get; set; }
        public virtual DbSet<CountryHotel> CountryHotels { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<HotelPrice> HotelPrices { get; set; }
        public virtual DbSet<ImagesHotel> ImagesHotels { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServicesHotel> ServicesHotels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp: 192.168.1.66, 1433;Database=TourFirmDB;Trusted_Connection=False;MultipleActiveResultSets=false;User ID=fasgetz;Password=andrey061");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<CategoryRoomHotel>(entity =>
            {
                entity.ToTable("CategoryRoomHotel");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CategoryService>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImageCategoryNamePath).HasMaxLength(50);
            });

            modelBuilder.Entity<CitiesCountry>(entity =>
            {
                entity.ToTable("CitiesCountry");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.CitiesCountries)
                    .HasForeignKey(d => d.IdCountry)
                    .HasConstraintName("FK_CitiesCountry_CountryTour");
            });

            modelBuilder.Entity<CountryHotel>(entity =>
            {
                entity.ToTable("CountryHotel");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.ToTable("Hotel");

                entity.Property(e => e.DescriptionTour).HasColumnType("text");

                entity.Property(e => e.NameHotel)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.PresentImagePath).HasMaxLength(50);

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Hotels)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tour_CitiesCountry");
            });

            modelBuilder.Entity<HotelPrice>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_TourPrices");

                entity.Property(e => e.PriceDay).HasColumnType("money");

                entity.HasOne(d => d.IdCategoryHotelNumberNavigation)
                    .WithMany(p => p.HotelPrices)
                    .HasForeignKey(d => d.IdCategoryHotelNumber)
                    .HasConstraintName("FK_HotelPrices_CategoryRoomHotel");

                entity.HasOne(d => d.IdHotelNavigation)
                    .WithMany(p => p.HotelPrices)
                    .HasForeignKey(d => d.IdHotel)
                    .HasConstraintName("FK_HotelPrices_Hotel");
            });

            modelBuilder.Entity<ImagesHotel>(entity =>
            {
                entity.ToTable("ImagesHotel");

                entity.Property(e => e.FolderPath).HasMaxLength(150);

                entity.Property(e => e.ImagePathName).HasMaxLength(50);

                entity.HasOne(d => d.IdHotelNavigation)
                    .WithMany(p => p.ImagesHotels)
                    .HasForeignKey(d => d.IdHotel)
                    .HasConstraintName("FK_ImagesHotel_Hotel");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Description).HasColumnType("text");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.IdCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Services_CategoryServices");
            });

            modelBuilder.Entity<ServicesHotel>(entity =>
            {
                entity.ToTable("ServicesHotel");

                entity.HasOne(d => d.IdHotelNavigation)
                    .WithMany(p => p.ServicesHotels)
                    .HasForeignKey(d => d.IdHotel)
                    .HasConstraintName("FK_ServicesTour_Tour");

                entity.HasOne(d => d.IdServiceNavigation)
                    .WithMany(p => p.ServicesHotels)
                    .HasForeignKey(d => d.IdService)
                    .HasConstraintName("FK_ServicesTour_Services");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
