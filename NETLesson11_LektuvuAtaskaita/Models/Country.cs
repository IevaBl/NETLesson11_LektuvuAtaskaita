using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLesson11_LektuvuAtaskaita.Models
{
    internal class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public bool InES { get; set; }

        public Country(string name,string code, bool inES)
        {
            Name = name;
            Code = code;
            InES = inES;
        }
    }
}
