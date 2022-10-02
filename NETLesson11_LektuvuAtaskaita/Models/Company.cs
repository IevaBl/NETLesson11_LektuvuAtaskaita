using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLesson11_LektuvuAtaskaita.Models
{
    internal class Company
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public Company(string name, string country)
        {
            Name = name;
            Country = country;
        }
    }
}
