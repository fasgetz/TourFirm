﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TourFirm.Models.DataBase;

namespace TourFirm.Migrations
{
    [DbContext(typeof(TourFirmDBContext))]
    partial class TourFirmDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TourFirm.Models.DataBase.CategoryRoomHotel", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CategoryRoomHotel");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.CategoryService", b =>
                {
                    b.Property<short>("Id")
                        .HasColumnType("smallint");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageCategoryNamePath")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CategoryServices");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.CitiesCountry", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("IdCountry")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCountry");

                    b.ToTable("CitiesCountry");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.CountryHotel", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CountryHotel");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionTour")
                        .HasColumnType("text");

                    b.Property<short?>("DistanceToSea")
                        .HasColumnType("smallint");

                    b.Property<short>("IdCity")
                        .HasColumnType("smallint");

                    b.Property<bool?>("IsPopular")
                        .HasColumnType("bit");

                    b.Property<short?>("LineNumber")
                        .HasColumnType("smallint");

                    b.Property<string>("NameHotel")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool?>("NeedVisa")
                        .HasColumnType("bit");

                    b.Property<string>("PresentImagePath")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float?>("RatingHotel")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("IdCity");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.HotelPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("IdCategoryHotelNumber")
                        .HasColumnType("smallint");

                    b.Property<int?>("IdHotel")
                        .HasColumnType("int");

                    b.Property<decimal?>("PriceDay")
                        .HasColumnType("money");

                    b.HasKey("Id")
                        .HasName("PK_TourPrices");

                    b.HasIndex("IdCategoryHotelNumber");

                    b.HasIndex("IdHotel");

                    b.ToTable("HotelPrices");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.ImagesHotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FolderPath")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("IdHotel")
                        .HasColumnType("int");

                    b.Property<string>("ImagePathName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdHotel");

                    b.ToTable("ImagesHotel");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.Service", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<short>("IdCategory")
                        .HasColumnType("smallint");

                    b.Property<bool?>("IsPayed")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdCategory");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.ServicesHotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdHotel")
                        .HasColumnType("int");

                    b.Property<short?>("IdService")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("IdHotel");

                    b.HasIndex("IdService");

                    b.ToTable("ServicesHotel");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.CitiesCountry", b =>
                {
                    b.HasOne("TourFirm.Models.DataBase.CountryHotel", "IdCountryNavigation")
                        .WithMany("CitiesCountries")
                        .HasForeignKey("IdCountry")
                        .HasConstraintName("FK_CitiesCountry_CountryTour");

                    b.Navigation("IdCountryNavigation");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.Hotel", b =>
                {
                    b.HasOne("TourFirm.Models.DataBase.CitiesCountry", "IdCityNavigation")
                        .WithMany("Hotels")
                        .HasForeignKey("IdCity")
                        .HasConstraintName("FK_Tour_CitiesCountry")
                        .IsRequired();

                    b.Navigation("IdCityNavigation");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.HotelPrice", b =>
                {
                    b.HasOne("TourFirm.Models.DataBase.CategoryRoomHotel", "IdCategoryHotelNumberNavigation")
                        .WithMany("HotelPrices")
                        .HasForeignKey("IdCategoryHotelNumber")
                        .HasConstraintName("FK_HotelPrices_CategoryRoomHotel");

                    b.HasOne("TourFirm.Models.DataBase.Hotel", "IdHotelNavigation")
                        .WithMany("HotelPrices")
                        .HasForeignKey("IdHotel")
                        .HasConstraintName("FK_HotelPrices_Hotel");

                    b.Navigation("IdCategoryHotelNumberNavigation");

                    b.Navigation("IdHotelNavigation");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.ImagesHotel", b =>
                {
                    b.HasOne("TourFirm.Models.DataBase.Hotel", "IdHotelNavigation")
                        .WithMany("ImagesHotels")
                        .HasForeignKey("IdHotel")
                        .HasConstraintName("FK_ImagesHotel_Hotel");

                    b.Navigation("IdHotelNavigation");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.Service", b =>
                {
                    b.HasOne("TourFirm.Models.DataBase.CategoryService", "IdCategoryNavigation")
                        .WithMany("Services")
                        .HasForeignKey("IdCategory")
                        .HasConstraintName("FK_Services_CategoryServices")
                        .IsRequired();

                    b.Navigation("IdCategoryNavigation");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.ServicesHotel", b =>
                {
                    b.HasOne("TourFirm.Models.DataBase.Hotel", "IdHotelNavigation")
                        .WithMany("ServicesHotels")
                        .HasForeignKey("IdHotel")
                        .HasConstraintName("FK_ServicesTour_Tour");

                    b.HasOne("TourFirm.Models.DataBase.Service", "IdServiceNavigation")
                        .WithMany("ServicesHotels")
                        .HasForeignKey("IdService")
                        .HasConstraintName("FK_ServicesTour_Services");

                    b.Navigation("IdHotelNavigation");

                    b.Navigation("IdServiceNavigation");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.CategoryRoomHotel", b =>
                {
                    b.Navigation("HotelPrices");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.CategoryService", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.CitiesCountry", b =>
                {
                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.CountryHotel", b =>
                {
                    b.Navigation("CitiesCountries");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.Hotel", b =>
                {
                    b.Navigation("HotelPrices");

                    b.Navigation("ImagesHotels");

                    b.Navigation("ServicesHotels");
                });

            modelBuilder.Entity("TourFirm.Models.DataBase.Service", b =>
                {
                    b.Navigation("ServicesHotels");
                });
#pragma warning restore 612, 618
        }
    }
}
