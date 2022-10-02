using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETLesson11_LektuvuAtaskaita.Models;

namespace NETLesson11_LektuvuAtaskaita.Repositories
{
    internal class CompanyRepository
    {
        public List<Company> Companies { get; set; }
        public CompanyRepository()
        {
            Companies = new List<Company>();
            Companies.Add(new Company("WizzAir", "UK"));
            Companies.Add(new Company("LOT", "PL"));
            Companies.Add(new Company("Boeing", "USA"));
            Companies.Add(new Company("Baltic AirLines", "LT"));
        }

        public List<Company> Retrieve()
        {
            return Companies;
        }

        public Company Retrieve(string country)
        {
            return Companies.Where(c => c.Country == country).FirstOrDefault();
        }
    }
}
