using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Komis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Komis.ViewModels
{
    public class HomeVM
    {
        public string Tytul { get; set; }
        public List<Samochod> Samochody { get; set; }
    }
}
