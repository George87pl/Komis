using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Samochody.Any())
            {
                context.AddRange(
                    new Samochod { Marka = "Ford", Model = "Mustang", RokProdukcji = 2016, Przebieg = "34 000 km", Pojemnosc = "4 900 cm3", RodzajPaliwa = "benzyna", Moc = "421 KM", Opis = "Mam do sprzedania Mustanga 5.0 GT V8 bla bla bla", Cena = 160000M, ZdjecieUrl = "/images/fordMustang.jpg", MiniaturkaUrl = "/images/fordMustang.jpg", JestSamochodemTygodnia = true },
                    new Samochod { Marka = "Audi", Model = "S5", RokProdukcji = 2013, Przebieg = "112 000 km", Pojemnosc = "3 000 cm3", RodzajPaliwa = "benzyna", Moc = "280 KM", Opis = "Mam do sprzedania super samochód", Cena = 115000M, ZdjecieUrl = "/images/audiS5.jpg", MiniaturkaUrl = "/images/audiS5.jpg", JestSamochodemTygodnia = true },
                    new Samochod { Marka = "BMV", Model = "X4", RokProdukcji = 2014, Przebieg = "4 300 km", Pojemnosc = "1 995 cm3", RodzajPaliwa = "benzyna", Moc = "190 KM", Opis = "Sprzedam samochód brum brum", Cena = 190000M, ZdjecieUrl = "/images/bmvx4.jpg", MiniaturkaUrl = "/images/bmvx4.jpg", JestSamochodemTygodnia = true },
                    new Samochod { Marka = "Chevrolet", Model = "Corvette", RokProdukcji = 1972, Przebieg = "28 000 km", Pojemnosc = "5 700 cm3", RodzajPaliwa = "benzyna", Moc = "300 KM", Opis = "Ale jaja do sprzedania świeże", Cena = 120000M, ZdjecieUrl = "/images/chevroletCorvete.jpg", MiniaturkaUrl = "/images/chevroletCorvete.jpg", JestSamochodemTygodnia = true },
                    new Samochod { Marka = "Nissan", Model = "Skyline", RokProdukcji = 1995, Przebieg = "144 000 km", Pojemnosc = "2 500 cm3", RodzajPaliwa = "benzyna", Moc = "410 KM", Opis = "Jedziemy panowie", Cena = 80000M, ZdjecieUrl = "/images/nissan.jpg", MiniaturkaUrl = "/images/nissan.jpg", JestSamochodemTygodnia = true },
                    new Samochod { Marka = "Jaguar", Model = "ZX", RokProdukcji = 2006, Przebieg = "78 000 km", Pojemnosc = "5 000 cm3", RodzajPaliwa = "benzyna", Moc = "510 KM", Opis = "Niemiec płakał jak sprzedawał", Cena = 14000M, ZdjecieUrl = "/images/jaguar.jpg", MiniaturkaUrl = "/images/jaguar.jpg", JestSamochodemTygodnia = true }
                    );
            }

            context.SaveChanges();
        }
    }
}
