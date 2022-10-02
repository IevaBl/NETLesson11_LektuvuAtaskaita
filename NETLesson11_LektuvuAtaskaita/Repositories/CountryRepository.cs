using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETLesson11_LektuvuAtaskaita.Models;

namespace NETLesson11_LektuvuAtaskaita.Repositories
{
    internal class CountryRepository
    {
        List<Country> Countries { get; set; }

        public CountryRepository()
        {
            Countries = new List<Country>();
            Countries.Add(new Country("Uited Kingdom","UK", false));
            Countries.Add(new Country("Poland","PL",true));
            Countries.Add(new Country("United States of America","USA",false));
            Countries.Add(new Country("Lithunia", "LT", true));
        }

        public List<Country> Retrieve()
        {
            return Countries;
        }

        public Country Retrieve(string code)
        {
            return Countries.Where(c => c.Code == code).FirstOrDefault();
        }
    }
}
