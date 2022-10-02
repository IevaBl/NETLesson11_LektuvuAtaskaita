using NETLesson11_LektuvuAtaskaita.Models;
using System.Collections.Generic;

namespace NETLesson11_LektuvuAtaskaita.Services
{
    public class ReportItem
    {
        public int Tailnumber { get; set; }
        public string ModelNumber { get; set; }  
        public string Modeldescription { get;set; }
        public string CompanyName { get; set; } 
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public bool plainInES { get; set; }


    }
}