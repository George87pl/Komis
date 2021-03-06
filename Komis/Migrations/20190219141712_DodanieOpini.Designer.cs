﻿// <auto-generated />
using Komis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Komis.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190219141712_DodanieOpini")]
    partial class DodanieOpini
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("Komis.Models.Opinia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NazwaUżytkownika")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("OczekujeOdpowiedzi");

                    b.Property<string>("Wiadomosc")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.HasKey("Id");

                    b.ToTable("Opinia");
                });

            modelBuilder.Entity("Komis.Models.Samochod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cena");

                    b.Property<bool>("JestSamochodemTygodnia");

                    b.Property<bool>("JestWCentrali");

                    b.Property<string>("Marka");

                    b.Property<string>("MiniaturkaUrl");

                    b.Property<string>("Moc");

                    b.Property<string>("Model");

                    b.Property<string>("Opis");

                    b.Property<string>("Pojemnosc");

                    b.Property<string>("Przebieg");

                    b.Property<string>("RodzajPaliwa");

                    b.Property<int>("RokProdukcji");

                    b.Property<string>("ZdjecieUrl");

                    b.HasKey("Id");

                    b.ToTable("Samochody");
                });
#pragma warning restore 612, 618
        }
    }
}
