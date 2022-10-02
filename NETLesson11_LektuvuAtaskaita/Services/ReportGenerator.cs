using NETLesson11_LektuvuAtaskaita.Models;
using NETLesson11_LektuvuAtaskaita.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLesson11_LektuvuAtaskaita.Services
{
    internal class ReportGenerator
    {

        List<ReportItem> listEuropean = new List<ReportItem>();
        AircraftModelRepository _aircraftModelRepository;
        AircraftRepository _aircraftRepository;
        CompanyRepository _companyRepository;
        CountryRepository _countryRepository;

        public ReportGenerator(AircraftModelRepository aircracftModelrepository,
            AircraftRepository airCracftRepository,
            CompanyRepository companyRepository,
            CountryRepository countryRepository)
        {
            _aircraftModelRepository = aircracftModelrepository;
            _aircraftRepository = airCracftRepository;
            _companyRepository = companyRepository;
            _countryRepository = countryRepository;


        }

        public List<ReportItem> GenerateReportAircraftInEurope()
        {
            //var listEuropean = new List<ReportItem>();
            var listEuropeanAircraft = new List<Aircraft>();
            var listCompany = _companyRepository.Retrieve();
            var listCountry = listCompany.Select(c => c.Country).ToList();

            foreach (var country in listCountry)
            {
                if (_countryRepository.Retrieve(_companyRepository.Retrieve(country).Country).InES)
                {
                //    Console.WriteLine($"Aircraft Tail Number:{_aircraftModelRepository.Retrieve(_companyRepository.Retrieve(country).Name).TailNumber}");
                //    Console.WriteLine($"Model Number: {_aircraftModelRepository.Retrieve(_companyRepository.Retrieve(country).Name).Number}");
                //    Console.WriteLine($"Model Description: {_aircraftRepository.Retrieve(_aircraftModelRepository.Retrieve(_companyRepository.Retrieve(country).Name).TailNumber.ToString()).Description}");
                //    Console.WriteLine($"Owner Company Name: {_companyRepository.Retrieve(country).Name}");
                //    Console.WriteLine($"Company Country Code: {_companyRepository.Retrieve(country).Country}");
                //    Console.WriteLine($"Company Country Name: {_countryRepository.Retrieve(_companyRepository.Retrieve(country).Country).Name}");
                //    Console.WriteLine();

                    var reportItem = new ReportItem();

                    reportItem.Tailnumber = _aircraftModelRepository.Retrieve(_companyRepository.Retrieve(country).Name).TailNumber;
                    reportItem.ModelNumber = _aircraftModelRepository.Retrieve(_companyRepository.Retrieve(country).Name).Number;
                    reportItem.Modeldescription = _aircraftRepository.Retrieve(_aircraftModelRepository.Retrieve(_companyRepository.Retrieve(country).Name).TailNumber.ToString()).Description;
                    reportItem.CompanyName = _companyRepository.Retrieve(country).Name;
                    reportItem.CountryCode = _companyRepository.Retrieve(country).Country;
                    reportItem.CountryName = _countryRepository.Retrieve(_companyRepository.Retrieve(country).Country).Name;
                    reportItem.plainInES = true;


                    listEuropean.Add(reportItem);
                }
            }

            return listEuropean;
        }

        public List<ReportItem> GenerateReportAircraft()
        {
            var listWorld = new List<ReportItem>();
            var listAircraft = new List<Aircraft>();
            var listCompany = _companyRepository.Retrieve();
            var listCountry = listCompany.Select(c => c.Country).ToList();

            foreach (var country in listCountry)
            {
                if (!_countryRepository.Retrieve(_companyRepository.Retrieve(country).Country).InES)
                {
                //    Console.WriteLine($"Aircraft Tail Number:{_aircraftModelRepository.Retrieve(_companyRepository.Retrieve(country).Name).TailNumber}");
                //    Console.WriteLine($"Model Number: {_aircraftModelRepository.Retrieve(_companyRepository.Retrieve(country).Name).Number}");
                //    Console.WriteLine($"Model Description: {_aircraftRepository.Retrieve(_aircraftModelRepository.Retrieve(_companyRepository.Retrieve(country).Name).TailNumber.ToString()).Description}");
                //    Console.WriteLine($"Owner Company Name: {_companyRepository.Retrieve(country).Name}");
                //    Console.WriteLine($"Company Country Code: {_companyRepository.Retrieve(country).Country}");
                //    Console.WriteLine($"Company Country Name: {_countryRepository.Retrieve(_companyRepository.Retrieve(country).Country).Name}");
                //    Console.WriteLine();

                    var reportItem = new ReportItem();

                    reportItem.Tailnumber = _aircraftModelRepository.Retrieve(_companyRepository.Retrieve(country).Name).TailNumber;
                    reportItem.ModelNumber = _aircraftModelRepository.Retrieve(_companyRepository.Retrieve(country).Name).Number;
                    reportItem.Modeldescription = _aircraftRepository.Retrieve(_aircraftModelRepository.Retrieve(_companyRepository.Retrieve(country).Name).TailNumber.ToString()).Description;
                    reportItem.CompanyName = _companyRepository.Retrieve(country).Name;
                    reportItem.CountryCode = _companyRepository.Retrieve(country).Country;
                    reportItem.CountryName = _countryRepository.Retrieve(_companyRepository.Retrieve(country).Country).Name;
                    reportItem.plainInES = false;


                    listWorld.Add(reportItem);
                }
            }

            return listWorld;
        }
    }
}
