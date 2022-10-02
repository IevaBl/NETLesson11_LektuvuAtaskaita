using NETLesson11_LektuvuAtaskaita.Repositories;
using NETLesson11_LektuvuAtaskaita.Services;
using System;
using System.Collections.Generic;
using System.IO;

namespace NETLesson11_LektuvuAtaskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AircraftModelRepository aircraftModelRepository = new AircraftModelRepository();
            AircraftRepository aircraftRepository = new AircraftRepository(); 
            CompanyRepository companyRepository = new CompanyRepository();
            CountryRepository countryRepository = new CountryRepository();
            HTMLGenerator hTMLGenerator = new HTMLGenerator();

            ReportGenerator reportGenerator = new ReportGenerator(aircraftModelRepository,
                aircraftRepository,
                companyRepository,
                countryRepository);
            
            List<ReportItem> europeList = reportGenerator.GenerateReportAircraftInEurope();
            List<ReportItem> nonEuropeList = reportGenerator.GenerateReportAircraft();

            String reportEurope = hTMLGenerator.GenerateHtml(europeList);
            String reportNonEurope = hTMLGenerator.GenerateHtml(nonEuropeList);


            File.WriteAllText("HtmlGeneratorEurope.html", reportEurope);
            File.WriteAllText("HtmlGeneratorNonEurpe.html", reportNonEurope);

        }
    }
}
